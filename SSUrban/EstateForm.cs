using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using SSUrbanModelo;
using log4net;
using System.Reflection;

namespace SSUrban
{
    public partial class EstateForm : MetroFramework.Forms.MetroForm
    {
        private SSUrbanEntities _ctx;

        public ILog Logger { get; set; }

        //estateType 1 = venta, 2 = alquiler, 3 alquiler opción compra
        public EstateForm(string expediente = null, int estateType = 1)
        {
            InitializeLog();
            InitializeComponent();
            PopulateControls(expediente, estateType);
            this.StyleManager = metroStyleManagerEstate;
        }

        private void PopulateControls(string expediente, int estateType)
        {
            using (_ctx = new SSUrbanEntities())
            {
                var muns = _ctx.Municipios.OrderBy(x => x.Nombre).ToList();
                cmbLocalidad.DataSource = new BindingSource(muns, null);
                cmbLocalidad.DisplayMember = "Nombre";
                cmbLocalidad.ValueMember = "Nombre";
            }
            //Foco inicial
            txtDesc.Select();
            try
            {

                if (!string.IsNullOrEmpty(expediente))
                {

                    using (_ctx = new SSUrbanEntities())
                    {
                        var estateData = (from i in _ctx.Inmuebles
                                          join ti in _ctx.TipoInmuebles on i.TipoInmueble equals ti.Id
                                          join prop in _ctx.Clientes on i.Vendedor_Arrendador equals prop.DNI
                                          where i.Expediente == expediente
                                          select new { Inmuebles = i, TipoInmuebles = ti, Propietario = prop }).FirstOrDefault();

                        var compraData = (from c in _ctx.Clientes
                                          where c.DNI == estateData.Inmuebles.Comprador_Arrendatario
                                          select c).FirstOrDefault();
                        //INMUEBLE
                        txtExpediente.Text = estateData.Inmuebles.Expediente;
                        dtEstate.Value = estateData.Inmuebles.Fecha.Value;
                        cmbLocalidad.SelectedValue = estateData.Inmuebles.Localidad;
                        txtDesc.Text = estateData.Inmuebles.Descripcion;
                        txtAddressEstate.Text = estateData.Inmuebles.Direccion;

                        switch (estateData.TipoInmuebles.Id)
                        {
                            case 1:
                                radioButtonSale.Checked = true;
                                break;
                            case 2:
                                radioButtonRent.Checked = true;
                                break;
                            case 3:
                                radioButtonAlquilerCompra.Checked = true;
                                break;
                        }

                        //PROPIETARIO
                        if (estateData.Propietario != null)
                        {
                            txtOwnerName.Text = estateData.Propietario.Nombre;
                            txtOwnerSurname.Text = estateData.Propietario.Apellidos;
                            txtDniOwner.Text = estateData.Propietario.DNI;
                            txtAddressOwner.Text = estateData.Propietario.Direccion;
                            txtPhoneOwner.Text = estateData.Propietario.Telefono;
                            txtEmailOwner.Text = estateData.Propietario.Email;
                        }

                        if (compraData != null)
                        {
                            //COMPRADOR
                            txtNameBuyer.Text = compraData.Nombre;
                            txtSurnameBuyer.Text = compraData.Apellidos;
                            txtDniBuyer.Text = compraData.DNI;
                            txtAddressBuyer.Text = compraData.Direccion;
                            txtPhoneBuyer.Text = compraData.Telefono;
                            txtMailBuyer.Text = compraData.Email;
                        }
                    }
                }
                else
                {
                    using (_ctx = new SSUrbanEntities())
                    {
                        switch (estateType)
                        {
                            case 1:
                                radioButtonSale.Checked = true;
                                txtExpediente.Text = string.Format("V{0}", (++_ctx.TipoInmuebles.Where(x => x.Id == 1).FirstOrDefault().Counter).ToString());
                                break;
                            case 2:
                                radioButtonRent.Checked = true;
                                txtExpediente.Text = string.Format("A{0}", (++_ctx.TipoInmuebles.Where(x => x.Id == 2).FirstOrDefault().Counter).ToString());
                                break;
                            case 3:
                                radioButtonAlquilerCompra.Checked = true;
                                txtExpediente.Text = string.Format("AOC{0}", (++_ctx.TipoInmuebles.Where(x => x.Id == 3).FirstOrDefault().Counter).ToString());
                                break;
                        }
                    }
                    txtDesc.Select();
                }
            }
            catch (Exception ex)
            {
                this.Logger.Error(ex.Message, ex);
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnSaveEstate_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtDniOwner.Text))
                {
                    MetroMessageBox.Show(this, "Debe introducir un propietario para el inmueble.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (SSUrbanEntities ctx = new SSUrbanEntities())
                {
                    //VENDEDOR
                    Clientes vendedor = ctx.Clientes.Find(txtDniOwner.Text);
                    if (!string.IsNullOrEmpty(txtDniOwner.Text))
                    {
                        if (vendedor != null)
                        {
                            vendedor.Nombre = txtOwnerName.Text;
                            vendedor.Apellidos = txtOwnerSurname.Text;
                            vendedor.Direccion = txtAddressOwner.Text;
                            vendedor.Telefono = txtPhoneOwner.Text;
                            vendedor.Email = txtEmailOwner.Text;
                            ctx.Entry(vendedor).CurrentValues.SetValues(vendedor);
                        }
                        else
                        {
                            vendedor = new Clientes();
                            vendedor.Nombre = txtOwnerName.Text;
                            vendedor.Apellidos = txtOwnerSurname.Text;
                            vendedor.Direccion = txtAddressOwner.Text;
                            vendedor.DNI = txtDniOwner.Text;
                            vendedor.Telefono = txtPhoneOwner.Text;
                            vendedor.Email = txtEmailOwner.Text;
                            ctx.Clientes.Add(vendedor);
                        }

                        ctx.SaveChanges();
                    }

                    //COMPRADOR
                    Clientes comprador = ctx.Clientes.Find(txtDniBuyer.Text);
                    if (!string.IsNullOrEmpty(txtDniBuyer.Text))
                    {
                        if (comprador != null)
                        {
                            comprador.Nombre = txtNameBuyer.Text;
                            comprador.Apellidos = txtSurnameBuyer.Text;
                            comprador.Direccion = txtAddressBuyer.Text;
                            comprador.Telefono = txtPhoneBuyer.Text;
                            comprador.Email = txtMailBuyer.Text;
                            ctx.Entry(comprador).CurrentValues.SetValues(comprador);
                        }
                        else
                        {
                            comprador = new Clientes();
                            comprador.Nombre = txtNameBuyer.Text;
                            comprador.Apellidos = txtSurnameBuyer.Text;
                            comprador.Direccion = txtAddressBuyer.Text;
                            comprador.DNI = txtDniBuyer.Text;
                            comprador.Telefono = txtPhoneBuyer.Text;
                            comprador.Email = txtMailBuyer.Text;
                            ctx.Clientes.Add(comprador);
                        }

                        ctx.SaveChanges();
                    }

                    //INMUEBLE
                    Inmuebles estate = ctx.Inmuebles.Find(txtExpediente.Text);
                    if (!string.IsNullOrEmpty(txtExpediente.Text))
                    {
                        string transaction = string.Empty;
                        if (estate != null)
                        {
                            estate.Fecha = dtEstate.Value;
                            estate.Localidad = cmbLocalidad.SelectedValue.ToString();
                            estate.Direccion = txtAddressEstate.Text;
                            estate.Descripcion = txtDesc.Text;
                            transaction = panelTransaction.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
                            estate.TipoInmueble = ctx.TipoInmuebles.Where(x => x.Description == transaction).FirstOrDefault().Id;
                            estate.Vendedor_Arrendador = txtDniOwner.Text;
                            estate.Comprador_Arrendatario = txtDniBuyer.Text;
                            ctx.Entry(estate).CurrentValues.SetValues(estate);
                        }
                        else
                        {
                            estate = new Inmuebles();
                            estate.Expediente = txtExpediente.Text;
                            estate.Fecha = dtEstate.Value;
                            estate.Localidad = cmbLocalidad.SelectedValue.ToString();
                            estate.Direccion = txtAddressEstate.Text;
                            estate.Descripcion = txtDesc.Text;
                            transaction = panelTransaction.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
                            estate.TipoInmueble = ctx.TipoInmuebles.Where(x => x.Description == transaction).FirstOrDefault().Id;
                            estate.Vendedor_Arrendador = txtDniOwner.Text;
                            estate.Comprador_Arrendatario = txtDniBuyer.Text;
                            estate.EstateCounter = ++(ctx.TipoInmuebles.Where(i => i.Id == estate.TipoInmueble).FirstOrDefault().Counter);

                            ctx.Inmuebles.Add(estate);
                        }
                        ctx.SaveChanges();
                    }
                    MetroMessageBox.Show(this, "Inmueble guardado correctamente.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                this.Logger.Error(ex.Message, ex);
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LeaveDniOwner_FindCustomer(object sender, EventArgs e)
        {
            using (_ctx = new SSUrbanEntities())
            {
                Clientes cust = _ctx.Clientes.Find(txtDniOwner.Text);
                if (cust != null)
                {
                    txtOwnerName.Text = cust.Nombre;
                    txtOwnerSurname.Text = cust.Apellidos;
                    txtAddressOwner.Text = cust.Direccion;
                    txtPhoneOwner.Text = cust.Telefono;
                    txtEmailOwner.Text = cust.Email;
                }
            }
        }

        private void LeaveDniBuyer_FindCustomer(object sender, EventArgs e)
        {
            using (_ctx = new SSUrbanEntities())
            {
                Clientes cust = _ctx.Clientes.Find(txtDniBuyer.Text);
                if (cust != null)
                {
                    txtNameBuyer.Text = cust.Nombre;
                    txtSurnameBuyer.Text = cust.Apellidos;
                    txtAddressBuyer.Text = cust.Direccion;
                    txtPhoneBuyer.Text = cust.Telefono;
                    txtMailBuyer.Text = cust.Email;
                }
            }
        }

        private void radioButtonSale_Click(object sender, EventArgs e)
        {
            long expNum = CheckExpediente(txtExpediente.Text);
            txtExpediente.Text = string.Format("V{0}", expNum);
        }

        private void radioButtonAlquilerCompra_Click(object sender, EventArgs e)
        {
            long expNum = CheckExpediente(txtExpediente.Text);
            txtExpediente.Text = string.Format("AOC{0}", expNum);
        }

        private void radioButtonRent_Click(object sender, EventArgs e)
        {
            long expNum = CheckExpediente(txtExpediente.Text);
            txtExpediente.Text = string.Format("A{0}", expNum);
        }

        private long CheckExpediente(string exp)
        {
            using (_ctx = new SSUrbanEntities())
            {
                string transaction = panelTransaction.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
                int tipo = _ctx.TipoInmuebles.Where(x => x.Description == transaction).FirstOrDefault().Id;
                return (++_ctx.TipoInmuebles.Where(x => x.Id == tipo).FirstOrDefault().Counter);
            }
        }

        private void btnDeleteEstate_Click(object sender, EventArgs e)
        {
            DialogResult delResult = MetroMessageBox.Show(this, "¿Seguro que desea eliminar el inmueble?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (delResult == DialogResult.Yes)
            {
                try
                {
                    using (_ctx = new SSUrbanEntities())
                    {
                        var estateToDelete = _ctx.Inmuebles.Where(x => x.Expediente == txtExpediente.Text).FirstOrDefault();
                        _ctx.Inmuebles.Remove(estateToDelete);
                        _ctx.SaveChanges();
                    }
                    MetroMessageBox.Show(this, "Inmueble eliminado correctamente.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                catch (Exception ex)
                {
                    this.Logger.Error(ex.Message, ex);
                    MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
                return;
        }

        private void InitializeLog()
        {
            this.Logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().GetTypes().First());
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}