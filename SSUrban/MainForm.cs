using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.ListViewItem;
using log4net;
using System.Reflection;
using System.Net.NetworkInformation;
using System.Configuration;
using System.Diagnostics;
using SSUrbanModelo;
using SSUrban.Helpers;

namespace SSUrban
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        #region Atributos

        private SSUrbanEntities _ctx;
        private SplashForm m_splashForm;
        private Thread m_th;

        #endregion

        #region Propiedades

        public ILog Logger { get; set; }

        #endregion

        public MainForm()
        {
            InitializeLog();
            InitializeProgram();
            this.StyleManager = metroStyleManagerMain;
        }

        private void InitializeProgram()
        {
            m_th = new Thread(new ThreadStart(OpenSplash));
            m_th.Start();
            Thread.Sleep(1000);

            InitializeComponent();
        }

        private void OpenSplash()
        {
            m_splashForm = new SplashForm();
            m_splashForm.ShowDialog();
        }

        private void CloseSplash()
        {
            m_splashForm.Close();
            m_th.Abort();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (!VerifyDatabaseConnectivity())
                {
                    //Si no hay BD cerramos el splash y la app
                    ForceToCloseMainForm();
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate () { m_splashForm.LabelInfo = "Cargando los datos..."; });
                    Thread.Sleep(500);
                    LoadData();
                    this.Invoke((MethodInvoker)delegate () { m_splashForm.LabelInfo = "Carga de datos finalizada, arrancando!"; });
                    Thread.Sleep(500);
                    this.Invoke(new MethodInvoker(CloseSplash));
                }
            }
            catch (Exception ex)
            {
                this.Logger.Error(ex.Message, ex);
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ForceToCloseMainForm();
            }
        }

        private void LoadData()
        {
            try
            {
                WebRequestHelper.CallPostMethod();
                _ctx = new SSUrbanEntities();
                var cust = _ctx.Clientes.OrderBy(x => x.Nombre).ToList();
                clientsView.Items.Clear();
                foreach (var c in cust)
                {
                    ListViewItem lvi = new ListViewItem(c.Nombre);
                    lvi.SubItems.Add(c.Apellidos);
                    lvi.SubItems.Add(c.Direccion);
                    lvi.SubItems.Add(c.DNI);
                    lvi.SubItems.Add(c.Telefono);
                    clientsView.Items.Add(lvi);
                }

                //lvSale 1=venta-2=alquiler-3=alquiler opción compra
                //listViewEstatesSale
                var estatesSale = (from i in _ctx.Inmuebles
                                   where i.TipoInmueble == 1
                                   select i).ToList();

                lvEstatesSale.Items.Clear();
                foreach (var e in estatesSale)
                {
                    ListViewItem lvi = new ListViewItem(e.Expediente);
                    lvi.SubItems.Add(e.Descripcion);
                    lvi.SubItems.Add(e.Direccion);
                    lvi.SubItems.Add(e.Localidad);
                    lvi.SubItems.Add(e.Fecha.Value.ToShortDateString());
                    lvEstatesSale.Items.Add(lvi);
                }

                //listViewEstatesRent
                var estatesRent = (from i in _ctx.Inmuebles
                                   where i.TipoInmueble == 2
                                   select i).ToList();

                lvEstatesRent.Items.Clear();
                foreach (var e in estatesRent)
                {
                    ListViewItem lvi = new ListViewItem(e.Expediente);
                    lvi.SubItems.Add(e.Descripcion);
                    lvi.SubItems.Add(e.Direccion);
                    lvi.SubItems.Add(e.Localidad);
                    lvi.SubItems.Add(e.Fecha.Value.ToShortDateString());
                    lvEstatesRent.Items.Add(lvi);
                }

                //listViewEstatesSaleOption
                var estatesSaleOption = (from i in _ctx.Inmuebles
                                         where i.TipoInmueble == 3
                                         select i).ToList();

                lvEstatesSaleOption.Items.Clear();
                foreach (var e in estatesSaleOption)
                {
                    ListViewItem lvi = new ListViewItem(e.Expediente);
                    lvi.SubItems.Add(e.Descripcion);
                    lvi.SubItems.Add(e.Direccion);
                    lvi.SubItems.Add(e.Localidad);
                    lvi.SubItems.Add(e.Fecha.Value.ToShortDateString());
                    lvEstatesSaleOption.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                this.Logger.Error(ex.Message, ex);
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void clientsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientsView.SelectedIndices.Count <= 0)
                return;

            int index = clientsView.SelectedIndices[0];
            if (index >= 0)
            {
                try
                {
                    _ctx = new SSUrbanEntities();
                    var dni = clientsView.Items[index].SubItems[3].Text;
                    var cust = (from c in _ctx.Clientes
                                where c.DNI == dni
                                select c).FirstOrDefault();

                    txtName.Text = cust.Nombre;
                    txtSurname.Text = cust.Apellidos;
                    txtAddress.Text = cust.Direccion;
                    txtDNI.Text = cust.DNI;
                    txtTelephone.Text = cust.Telefono;
                    txtMail.Text = cust.Email;
                    txtObservaciones.Text = cust.Observaciones;

                    LoadRelationalEstates(dni);
                }
                catch(Exception ex)
                {
                    this.Logger.Error(ex.Message, ex);
                    MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControls();
            txtName.Select();
        }

        private void ClearControls()
        {
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
        }

        private void LoadRelationalEstates(string dni)
        {
            try
            {
                _ctx = new SSUrbanEntities();
                var estates = (from i in _ctx.Inmuebles
                               where i.Vendedor_Arrendador == dni ||
                               i.Comprador_Arrendatario == dni
                               select i).ToList();

                estatesListView.Items.Clear();
                foreach (var e in estates)
                {
                    ListViewItem lvi = new ListViewItem(e.Expediente);
                    lvi.SubItems.Add(e.Localidad);
                    lvi.SubItems.Add(e.Direccion);
                    string tipo = _ctx.TipoInmuebles.Where(ti => ti.Id == e.TipoInmueble).Select(l => l.Description).FirstOrDefault();
                    lvi.SubItems.Add(tipo);
                    lvi.SubItems.Add(e.Fecha.Value.ToShortDateString());
                    estatesListView.Items.Add(lvi);
                }
            }
            catch(Exception ex)
            {
                this.Logger.Error(ex.Message, ex);
                throw ex;
            }
        }

        private void OpenEstateForm()
        {
            EstateForm frm = new EstateForm();
            frm.ShowDialog(this);
        }

        private void InitializeLog()
        {
            this.Logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().GetTypes().First());
            log4net.Config.XmlConfigurator.Configure();

            this.Logger.Info("Inicio de la app de gestión S&S Urban.");
        }

        private bool VerifyDatabaseConnectivity()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ssurban"].ConnectionString;
            this.Invoke((MethodInvoker)delegate () { m_splashForm.LabelInfo = "Verificando conexión con la base de datos..."; });
            Thread.Sleep(500);
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                try
                {
                    connection.Open();
                }
                catch (SqlException ex)
                {
                    this.Logger.Error(ex.Message);
                    MetroMessageBox.Show(this, "Fallo al conectar con el servidor de base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                this.Invoke((MethodInvoker)delegate () { m_splashForm.LabelInfo = "Conexión con la base de datos OK!"; });
                Thread.Sleep(500);
                return true;
            }

        }

        #region Form Events

        private void lvEstatesRent_DoubleClick(object sender, EventArgs e)
        {
            EstateForm frm = new EstateForm(lvEstatesRent.SelectedItems[0].Text);
            frm.ShowDialog(this);
            LoadData();
        }

        private void lvSaleEstates_DoubleClick(object sender, EventArgs e)
        {
            EstateForm frm = new EstateForm(lvEstatesSale.SelectedItems[0].Text);
            frm.ShowDialog(this);
            LoadData();
        }

        private void lvEstatesSaleOption_DoubleClick(object sender, EventArgs e)
        {
            EstateForm frm = new EstateForm(lvEstatesSaleOption.SelectedItems[0].Text);
            frm.ShowDialog(this);
            LoadData();
        }

        private void btnNewEstateSale_Click(object sender, EventArgs e)
        {
            EstateForm frm = new EstateForm(estateType: 1);
            if (frm.DialogResult != DialogResult.Cancel)
            {
                frm.ShowDialog(this);
                LoadData();
            }
        }

        private void btnNewEstateRent_Click(object sender, EventArgs e)
        {
            EstateForm frm = new EstateForm(estateType: 2);
            if (frm.DialogResult != DialogResult.Cancel)
            {
                frm.ShowDialog(this);
                LoadData();
            }
        }

        private void btnNewEstateSaleOption_Click(object sender, EventArgs e)
        {
            EstateForm frm = new EstateForm(estateType: 3);
            if (frm.DialogResult != DialogResult.Cancel)
            {
                frm.ShowDialog(this);
                LoadData();
            }
        }

        private void searchSaleEstates_TexChanged(object sender, EventArgs e)
        {
            _ctx = new SSUrbanEntities();
            var estatesSales = _ctx.Inmuebles.OrderBy(x => x.Expediente).Where(i => i.TipoInmueble == 1).ToList();
            lvEstatesSale.Items.Clear();
            lvEstatesSale.Items.AddRange(estatesSales.Where(x => x.Expediente.StartsWith(txtSearchEstateSale.Text, StringComparison.InvariantCultureIgnoreCase) ||
                                                            x.Descripcion.StartsWith(txtSearchEstateSale.Text, StringComparison.InvariantCultureIgnoreCase) ||
                                                            x.Direccion.StartsWith(txtSearchEstateSale.Text, StringComparison.InvariantCultureIgnoreCase) ||
                                                            x.Localidad.StartsWith(txtSearchEstateSale.Text, StringComparison.InvariantCultureIgnoreCase)).ToList().Select(l =>
                                                            new ListViewItem(new[] { l.Expediente,
                                                                                     l.Descripcion,
                                                                                     l.Direccion,
                                                                                     l.Localidad,
                                                                                     l.Fecha.Value.ToString() })).ToArray());
        }

        private void searchRentEstates_TexChanged(object sender, EventArgs e)
        {
            _ctx = new SSUrbanEntities();
            var estatesRent = _ctx.Inmuebles.OrderBy(x => x.Expediente).Where(i => i.TipoInmueble == 2).ToList();
            lvEstatesRent.Items.Clear();
            lvEstatesRent.Items.AddRange(estatesRent.Where(x => x.Expediente.StartsWith(txtSearchEstateRent.Text, StringComparison.InvariantCultureIgnoreCase) ||
                                                            x.Descripcion.StartsWith(txtSearchEstateRent.Text, StringComparison.InvariantCultureIgnoreCase) ||
                                                            x.Direccion.StartsWith(txtSearchEstateRent.Text, StringComparison.InvariantCultureIgnoreCase) ||
                                                            x.Localidad.StartsWith(txtSearchEstateRent.Text, StringComparison.InvariantCultureIgnoreCase)).ToList().Select(l =>
                                                            new ListViewItem(new[] { l.Expediente,
                                                                                     l.Descripcion,
                                                                                     l.Direccion,
                                                                                     l.Localidad,
                                                                                     l.Fecha.Value.ToString() })).ToArray());
        }

        private void searchSaleOptionEstates_TexChanged(object sender, EventArgs e)
        {
            _ctx = new SSUrbanEntities();
            var estatesSaleOption = _ctx.Inmuebles.OrderBy(x => x.Expediente).Where(i => i.TipoInmueble == 3).ToList();
            lvEstatesSaleOption.Items.Clear();
            lvEstatesSaleOption.Items.AddRange(estatesSaleOption.Where(x => x.Expediente.StartsWith(txtSearchEstateSaleOption.Text, StringComparison.InvariantCultureIgnoreCase) ||
                                                            x.Descripcion.StartsWith(txtSearchEstateSaleOption.Text, StringComparison.InvariantCultureIgnoreCase) ||
                                                            x.Direccion.StartsWith(txtSearchEstateSaleOption.Text, StringComparison.InvariantCultureIgnoreCase) ||
                                                            x.Localidad.StartsWith(txtSearchEstateSaleOption.Text, StringComparison.InvariantCultureIgnoreCase)).ToList().Select(l =>
                                                            new ListViewItem(new[] { l.Expediente,
                                                                                     l.Descripcion,
                                                                                     l.Direccion,
                                                                                     l.Localidad,
                                                                                     l.Fecha.Value.ToString() })).ToArray());
        }

        private void estatesListView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                EstateForm frm = new EstateForm(estatesListView.SelectedItems[0].Text);
                frm.ShowDialog(this);
                //Recargamos vista con inmuebles de cliente seleccionado
                if (clientsView.SelectedItems.Count > 0)
                    LoadRelationalEstates(clientsView.SelectedItems[0].SubItems[3].Text);
                LoadData();
            }
            catch(Exception ex)
            {
                {
                    this.Logger.Error(ex.Message, ex);
                    MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDNI.Text))
                {
                    MetroMessageBox.Show(this, "Debe seleccionar un registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult delResult = MetroMessageBox.Show(this, "¿Seguro que desea eliminar este cliente y TODOS sus inmuebles?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (delResult == DialogResult.Yes)
                {
                    try
                    {
                        _ctx = new SSUrbanEntities();
                        clientsView.BeginUpdate();
                        clientsView.Items.Clear();
                        Clientes cust = (from c in _ctx.Clientes
                                         where c.DNI == txtDNI.Text
                                         select c).FirstOrDefault();
                        //Inmuebles relacionados
                        foreach (var i in _ctx.Inmuebles.Where(p => p.Vendedor_Arrendador == cust.DNI))
                        {
                            _ctx.Inmuebles.Remove(i);
                        }
                        _ctx.SaveChanges();

                        //Cliente propietario
                        _ctx.Clientes.Remove(cust);

                        estatesListView.BeginUpdate();
                        estatesListView.Items.Clear();
                        
                        _ctx.SaveChanges();
                        LoadData();
                        ClearControls();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        clientsView.EndUpdate();
                        estatesListView.EndUpdate();
                        MetroMessageBox.Show(this, "Cliente y sus inmuebles eliminados correctamente.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                this.Logger.Error(ex.Message, ex);
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void filterTxt_TexChanged(object sender, EventArgs e)
        {
            _ctx = new SSUrbanEntities();
            var cust = _ctx.Clientes.OrderBy(x => x.Nombre).ToList();
            clientsView.Items.Clear();
            clientsView.Items.AddRange(cust.Where(x => x.Nombre.StartsWith(txtSearch.Text, StringComparison.InvariantCultureIgnoreCase) ||
                                                       x.Apellidos.StartsWith(txtSearch.Text, StringComparison.InvariantCultureIgnoreCase) ||
                                                       x.Direccion.StartsWith(txtSearch.Text, StringComparison.InvariantCultureIgnoreCase) ||
                                                       x.Telefono.StartsWith(txtSearch.Text, StringComparison.InvariantCultureIgnoreCase) ||
                                                       x.DNI.StartsWith(txtSearch.Text, StringComparison.InvariantCultureIgnoreCase)).ToList().Select(l =>
                                                                                                                                                      new ListViewItem(new[] { l.Nombre,
                                                                                                                                                                               l.Apellidos,
                                                                                                                                                                               l.Direccion,
                                                                                                                                                                               l.DNI,
                                                                                                                                                                               l.Telefono })).ToArray());
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                MetroMessageBox.Show(this, 
                    "Número de documento de indentidad obligatorio.", 
                    "Notificación", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Question);
                return;
            }

            try
            {
                _ctx = new SSUrbanEntities();
                clientsView.BeginUpdate();
                clientsView.Items.Clear();
                Clientes cust = _ctx.Clientes.Find(txtDNI.Text);
                if (cust != null)
                {
                    cust.Nombre = txtName.Text;
                    cust.Apellidos = txtSurname.Text;
                    cust.Direccion = txtAddress.Text;
                    cust.Telefono = txtTelephone.Text;
                    cust.Email = txtMail.Text;
                    cust.Observaciones = txtObservaciones.Text;
                    _ctx.Entry(cust).CurrentValues.SetValues(cust);
                    MetroMessageBox.Show(this, "Cliente actualizado correctamente.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    cust = new Clientes();
                    cust.Nombre = txtName.Text;
                    cust.Apellidos = txtSurname.Text;
                    cust.Direccion = txtAddress.Text;
                    cust.DNI = txtDNI.Text;
                    cust.Telefono = txtTelephone.Text;
                    cust.Email = txtMail.Text;
                    cust.Observaciones = txtObservaciones.Text;
                    _ctx.Clientes.Add(cust);
                }

                _ctx.SaveChanges();
                LoadData();
            }
            catch (Exception ex)
            {
                this.Logger.Error(ex.Message, ex);
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                clientsView.EndUpdate();
            }
        }

        private void ForceToCloseMainForm()
        {
            this.Invoke(new MethodInvoker(CloseSplash));
            this.BeginInvoke(new MethodInvoker(this.Close));
        }

        #endregion
    }
}