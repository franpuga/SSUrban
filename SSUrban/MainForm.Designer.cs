using System;

namespace SSUrban
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabClientes = new MetroFramework.Controls.MetroTabPage();
            this.estatesListView = new System.Windows.Forms.ListView();
            this.columnExpediente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLocalidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblClientes = new MetroFramework.Controls.MetroLabel();
            this.lblEstates = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblAddress = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.clientsView = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTelephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSaveCustomer = new MetroFramework.Controls.MetroButton();
            this.txtObservaciones = new MetroFramework.Controls.MetroTextBox();
            this.lblObservaciones = new MetroFramework.Controls.MetroLabel();
            this.txtMail = new MetroFramework.Controls.MetroTextBox();
            this.lblMail = new MetroFramework.Controls.MetroLabel();
            this.txtTelephone = new MetroFramework.Controls.MetroTextBox();
            this.lblTelephone = new MetroFramework.Controls.MetroLabel();
            this.txtDNI = new MetroFramework.Controls.MetroTextBox();
            this.lblDni = new MetroFramework.Controls.MetroLabel();
            this.txtSurname = new MetroFramework.Controls.MetroTextBox();
            this.lblSurname = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroTabVenta = new MetroFramework.Controls.MetroTabPage();
            this.lvEstatesSale = new System.Windows.Forms.ListView();
            this.headerExpediente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerLocalidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchEstateSale = new MetroFramework.Controls.MetroTextBox();
            this.btnNewEstateSale = new MetroFramework.Controls.MetroButton();
            this.metroTabAlquiler = new MetroFramework.Controls.MetroTabPage();
            this.lvEstatesRent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchEstateRent = new MetroFramework.Controls.MetroTextBox();
            this.btnNewEstateRent = new MetroFramework.Controls.MetroButton();
            this.metroTabAlquilerOpcionCompra = new MetroFramework.Controls.MetroTabPage();
            this.lvEstatesSaleOption = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchEstateSaleOption = new MetroFramework.Controls.MetroTextBox();
            this.btnNewEstateSaleOption = new MetroFramework.Controls.MetroButton();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.metroStyleManagerMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblVersion = new System.Windows.Forms.Label();
            this.metroTabControl.SuspendLayout();
            this.metroTabClientes.SuspendLayout();
            this.metroTabVenta.SuspendLayout();
            this.metroTabAlquiler.SuspendLayout();
            this.metroTabAlquilerOpcionCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerMain)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabClientes);
            this.metroTabControl.Controls.Add(this.metroTabVenta);
            this.metroTabControl.Controls.Add(this.metroTabAlquiler);
            this.metroTabControl.Controls.Add(this.metroTabAlquilerOpcionCompra);
            this.metroTabControl.Location = new System.Drawing.Point(24, 63);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 3;
            this.metroTabControl.Size = new System.Drawing.Size(1096, 573);
            this.metroTabControl.TabIndex = 0;
            this.metroTabControl.UseSelectable = true;
            // 
            // metroTabClientes
            // 
            this.metroTabClientes.Controls.Add(this.estatesListView);
            this.metroTabClientes.Controls.Add(this.lblClientes);
            this.metroTabClientes.Controls.Add(this.lblEstates);
            this.metroTabClientes.Controls.Add(this.txtSearch);
            this.metroTabClientes.Controls.Add(this.lblAddress);
            this.metroTabClientes.Controls.Add(this.txtAddress);
            this.metroTabClientes.Controls.Add(this.btnNew);
            this.metroTabClientes.Controls.Add(this.btnDelete);
            this.metroTabClientes.Controls.Add(this.clientsView);
            this.metroTabClientes.Controls.Add(this.btnSaveCustomer);
            this.metroTabClientes.Controls.Add(this.txtObservaciones);
            this.metroTabClientes.Controls.Add(this.lblObservaciones);
            this.metroTabClientes.Controls.Add(this.txtMail);
            this.metroTabClientes.Controls.Add(this.lblMail);
            this.metroTabClientes.Controls.Add(this.txtTelephone);
            this.metroTabClientes.Controls.Add(this.lblTelephone);
            this.metroTabClientes.Controls.Add(this.txtDNI);
            this.metroTabClientes.Controls.Add(this.lblDni);
            this.metroTabClientes.Controls.Add(this.txtSurname);
            this.metroTabClientes.Controls.Add(this.lblSurname);
            this.metroTabClientes.Controls.Add(this.lblName);
            this.metroTabClientes.Controls.Add(this.txtName);
            this.metroTabClientes.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTabClientes.HorizontalScrollbarBarColor = true;
            this.metroTabClientes.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabClientes.HorizontalScrollbarSize = 10;
            this.metroTabClientes.Location = new System.Drawing.Point(4, 38);
            this.metroTabClientes.Name = "metroTabClientes";
            this.metroTabClientes.Size = new System.Drawing.Size(1088, 531);
            this.metroTabClientes.TabIndex = 0;
            this.metroTabClientes.Text = "Clientes";
            this.metroTabClientes.VerticalScrollbarBarColor = true;
            this.metroTabClientes.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabClientes.VerticalScrollbarSize = 10;
            // 
            // estatesListView
            // 
            this.estatesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnExpediente,
            this.columnLocalidad,
            this.columnDireccion,
            this.columnType,
            this.columnDate});
            this.estatesListView.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estatesListView.FullRowSelect = true;
            this.estatesListView.Location = new System.Drawing.Point(457, 309);
            this.estatesListView.MultiSelect = false;
            this.estatesListView.Name = "estatesListView";
            this.estatesListView.Size = new System.Drawing.Size(628, 219);
            this.estatesListView.TabIndex = 29;
            this.estatesListView.UseCompatibleStateImageBehavior = false;
            this.estatesListView.View = System.Windows.Forms.View.Details;
            this.estatesListView.DoubleClick += new System.EventHandler(this.estatesListView_DoubleClick);
            // 
            // columnExpediente
            // 
            this.columnExpediente.Text = "Expediente";
            this.columnExpediente.Width = 100;
            // 
            // columnLocalidad
            // 
            this.columnLocalidad.Text = "Localidad";
            this.columnLocalidad.Width = 100;
            // 
            // columnDireccion
            // 
            this.columnDireccion.Text = "Dirección";
            this.columnDireccion.Width = 200;
            // 
            // columnType
            // 
            this.columnType.Text = "Tipo Inmueble";
            this.columnType.Width = 115;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Fecha";
            this.columnDate.Width = 110;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblClientes.Location = new System.Drawing.Point(457, 14);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(57, 19);
            this.lblClientes.TabIndex = 26;
            this.lblClientes.Text = "Clientes";
            // 
            // lblEstates
            // 
            this.lblEstates.AutoSize = true;
            this.lblEstates.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEstates.Location = new System.Drawing.Point(460, 287);
            this.lblEstates.Name = "lblEstates";
            this.lblEstates.Size = new System.Drawing.Size(72, 19);
            this.lblEstates.TabIndex = 25;
            this.lblEstates.Text = "Inmuebles";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(541, 259);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Buscar Cliente...";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(220, 23);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Buscar Cliente...";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.filterTxt_TexChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAddress.Location = new System.Drawing.Point(-4, 100);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 19);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Dirección";
            this.lblAddress.UseMnemonic = false;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(289, 2);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(94, 100);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(331, 44);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(457, 259);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(194, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // clientsView
            // 
            this.clientsView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnSurname,
            this.columnAddress,
            this.columnDNI,
            this.columnTelephone});
            this.clientsView.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsView.FullRowSelect = true;
            this.clientsView.Location = new System.Drawing.Point(457, 36);
            this.clientsView.MultiSelect = false;
            this.clientsView.Name = "clientsView";
            this.clientsView.Size = new System.Drawing.Size(628, 217);
            this.clientsView.TabIndex = 15;
            this.clientsView.UseCompatibleStateImageBehavior = false;
            this.clientsView.View = System.Windows.Forms.View.Details;
            this.clientsView.SelectedIndexChanged += new System.EventHandler(this.clientsList_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Nombre";
            this.columnName.Width = 140;
            // 
            // columnSurname
            // 
            this.columnSurname.Text = "Apellidos";
            this.columnSurname.Width = 140;
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "Dirección";
            this.columnAddress.Width = 140;
            // 
            // columnDNI
            // 
            this.columnDNI.Text = "DNI";
            this.columnDNI.Width = 90;
            // 
            // columnTelephone
            // 
            this.columnTelephone.Text = "Teléfono";
            this.columnTelephone.Width = 90;
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Location = new System.Drawing.Point(94, 360);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(94, 23);
            this.btnSaveCustomer.TabIndex = 8;
            this.btnSaveCustomer.Text = "Guardar";
            this.btnSaveCustomer.UseSelectable = true;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // txtObservaciones
            // 
            // 
            // 
            // 
            this.txtObservaciones.CustomButton.Image = null;
            this.txtObservaciones.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.txtObservaciones.CustomButton.Name = "";
            this.txtObservaciones.CustomButton.Size = new System.Drawing.Size(115, 115);
            this.txtObservaciones.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObservaciones.CustomButton.TabIndex = 1;
            this.txtObservaciones.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObservaciones.CustomButton.UseSelectable = true;
            this.txtObservaciones.CustomButton.Visible = false;
            this.txtObservaciones.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtObservaciones.Lines = new string[0];
            this.txtObservaciones.Location = new System.Drawing.Point(94, 237);
            this.txtObservaciones.MaxLength = 2500;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PasswordChar = '\0';
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservaciones.SelectedText = "";
            this.txtObservaciones.SelectionLength = 0;
            this.txtObservaciones.SelectionStart = 0;
            this.txtObservaciones.ShortcutsEnabled = true;
            this.txtObservaciones.Size = new System.Drawing.Size(331, 117);
            this.txtObservaciones.TabIndex = 7;
            this.txtObservaciones.UseSelectable = true;
            this.txtObservaciones.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservaciones.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblObservaciones.Location = new System.Drawing.Point(-4, 237);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(98, 19);
            this.lblObservaciones.TabIndex = 12;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtMail
            // 
            // 
            // 
            // 
            this.txtMail.CustomButton.Image = null;
            this.txtMail.CustomButton.Location = new System.Drawing.Point(309, 1);
            this.txtMail.CustomButton.Name = "";
            this.txtMail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMail.CustomButton.TabIndex = 1;
            this.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMail.CustomButton.UseSelectable = true;
            this.txtMail.CustomButton.Visible = false;
            this.txtMail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMail.Lines = new string[0];
            this.txtMail.Location = new System.Drawing.Point(94, 208);
            this.txtMail.MaxLength = 200;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.ShortcutsEnabled = true;
            this.txtMail.Size = new System.Drawing.Size(331, 23);
            this.txtMail.TabIndex = 6;
            this.txtMail.UseSelectable = true;
            this.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMail.Location = new System.Drawing.Point(-4, 208);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 19);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "Email";
            // 
            // txtTelephone
            // 
            // 
            // 
            // 
            this.txtTelephone.CustomButton.Image = null;
            this.txtTelephone.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtTelephone.CustomButton.Name = "";
            this.txtTelephone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelephone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelephone.CustomButton.TabIndex = 1;
            this.txtTelephone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelephone.CustomButton.UseSelectable = true;
            this.txtTelephone.CustomButton.Visible = false;
            this.txtTelephone.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTelephone.Lines = new string[0];
            this.txtTelephone.Location = new System.Drawing.Point(94, 179);
            this.txtTelephone.MaxLength = 50;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.PasswordChar = '\0';
            this.txtTelephone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelephone.SelectedText = "";
            this.txtTelephone.SelectionLength = 0;
            this.txtTelephone.SelectionStart = 0;
            this.txtTelephone.ShortcutsEnabled = true;
            this.txtTelephone.Size = new System.Drawing.Size(174, 23);
            this.txtTelephone.TabIndex = 5;
            this.txtTelephone.UseSelectable = true;
            this.txtTelephone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelephone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTelephone.Location = new System.Drawing.Point(-4, 179);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(60, 19);
            this.lblTelephone.TabIndex = 8;
            this.lblTelephone.Text = "Teléfono";
            // 
            // txtDNI
            // 
            // 
            // 
            // 
            this.txtDNI.CustomButton.Image = null;
            this.txtDNI.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtDNI.CustomButton.Name = "";
            this.txtDNI.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDNI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDNI.CustomButton.TabIndex = 1;
            this.txtDNI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDNI.CustomButton.UseSelectable = true;
            this.txtDNI.CustomButton.Visible = false;
            this.txtDNI.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDNI.Lines = new string[0];
            this.txtDNI.Location = new System.Drawing.Point(94, 150);
            this.txtDNI.MaxLength = 9;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.PasswordChar = '\0';
            this.txtDNI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDNI.SelectedText = "";
            this.txtDNI.SelectionLength = 0;
            this.txtDNI.SelectionStart = 0;
            this.txtDNI.ShortcutsEnabled = true;
            this.txtDNI.Size = new System.Drawing.Size(174, 23);
            this.txtDNI.TabIndex = 4;
            this.txtDNI.UseSelectable = true;
            this.txtDNI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDNI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDni.Location = new System.Drawing.Point(-4, 150);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 19);
            this.lblDni.TabIndex = 6;
            this.lblDni.Text = "DNI";
            // 
            // txtSurname
            // 
            // 
            // 
            // 
            this.txtSurname.CustomButton.Image = null;
            this.txtSurname.CustomButton.Location = new System.Drawing.Point(309, 1);
            this.txtSurname.CustomButton.Name = "";
            this.txtSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSurname.CustomButton.TabIndex = 1;
            this.txtSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSurname.CustomButton.UseSelectable = true;
            this.txtSurname.CustomButton.Visible = false;
            this.txtSurname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSurname.Lines = new string[0];
            this.txtSurname.Location = new System.Drawing.Point(94, 70);
            this.txtSurname.MaxLength = 300;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSurname.SelectedText = "";
            this.txtSurname.SelectionLength = 0;
            this.txtSurname.SelectionStart = 0;
            this.txtSurname.ShortcutsEnabled = true;
            this.txtSurname.Size = new System.Drawing.Size(331, 23);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.UseSelectable = true;
            this.txtSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSurname.Location = new System.Drawing.Point(-4, 70);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 19);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Apellidos";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblName.Location = new System.Drawing.Point(-4, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 19);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nombre";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(309, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(94, 41);
            this.txtName.MaxLength = 200;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(331, 23);
            this.txtName.TabIndex = 1;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabVenta
            // 
            this.metroTabVenta.Controls.Add(this.lvEstatesSale);
            this.metroTabVenta.Controls.Add(this.txtSearchEstateSale);
            this.metroTabVenta.Controls.Add(this.btnNewEstateSale);
            this.metroTabVenta.HorizontalScrollbarBarColor = true;
            this.metroTabVenta.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabVenta.HorizontalScrollbarSize = 10;
            this.metroTabVenta.Location = new System.Drawing.Point(4, 38);
            this.metroTabVenta.Name = "metroTabVenta";
            this.metroTabVenta.Size = new System.Drawing.Size(1088, 531);
            this.metroTabVenta.TabIndex = 1;
            this.metroTabVenta.Text = "Venta";
            this.metroTabVenta.VerticalScrollbarBarColor = true;
            this.metroTabVenta.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabVenta.VerticalScrollbarSize = 10;
            // 
            // lvEstatesSale
            // 
            this.lvEstatesSale.BackColor = System.Drawing.SystemColors.Window;
            this.lvEstatesSale.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerExpediente,
            this.headerDescripcion,
            this.headerDireccion,
            this.headerLocalidad,
            this.headerFecha});
            this.lvEstatesSale.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEstatesSale.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvEstatesSale.FullRowSelect = true;
            this.lvEstatesSale.Location = new System.Drawing.Point(58, 18);
            this.lvEstatesSale.MultiSelect = false;
            this.lvEstatesSale.Name = "lvEstatesSale";
            this.lvEstatesSale.Size = new System.Drawing.Size(970, 382);
            this.lvEstatesSale.TabIndex = 30;
            this.lvEstatesSale.UseCompatibleStateImageBehavior = false;
            this.lvEstatesSale.View = System.Windows.Forms.View.Details;
            this.lvEstatesSale.DoubleClick += new System.EventHandler(this.lvSaleEstates_DoubleClick);
            // 
            // headerExpediente
            // 
            this.headerExpediente.Text = "Expediente";
            this.headerExpediente.Width = 100;
            // 
            // headerDescripcion
            // 
            this.headerDescripcion.Text = "Descripción Inmueble";
            this.headerDescripcion.Width = 325;
            // 
            // headerDireccion
            // 
            this.headerDireccion.Text = "Dirección Inmueble";
            this.headerDireccion.Width = 325;
            // 
            // headerLocalidad
            // 
            this.headerLocalidad.Text = "Localidad";
            this.headerLocalidad.Width = 100;
            // 
            // headerFecha
            // 
            this.headerFecha.Text = "Fecha";
            this.headerFecha.Width = 110;
            // 
            // txtSearchEstateSale
            // 
            // 
            // 
            // 
            this.txtSearchEstateSale.CustomButton.Image = null;
            this.txtSearchEstateSale.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txtSearchEstateSale.CustomButton.Name = "";
            this.txtSearchEstateSale.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchEstateSale.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchEstateSale.CustomButton.TabIndex = 1;
            this.txtSearchEstateSale.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchEstateSale.CustomButton.UseSelectable = true;
            this.txtSearchEstateSale.CustomButton.Visible = false;
            this.txtSearchEstateSale.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearchEstateSale.Lines = new string[0];
            this.txtSearchEstateSale.Location = new System.Drawing.Point(139, 418);
            this.txtSearchEstateSale.MaxLength = 32767;
            this.txtSearchEstateSale.Name = "txtSearchEstateSale";
            this.txtSearchEstateSale.PasswordChar = '\0';
            this.txtSearchEstateSale.PromptText = "Buscar Inmueble...";
            this.txtSearchEstateSale.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchEstateSale.SelectedText = "";
            this.txtSearchEstateSale.SelectionLength = 0;
            this.txtSearchEstateSale.SelectionStart = 0;
            this.txtSearchEstateSale.ShortcutsEnabled = true;
            this.txtSearchEstateSale.Size = new System.Drawing.Size(220, 23);
            this.txtSearchEstateSale.TabIndex = 24;
            this.txtSearchEstateSale.UseSelectable = true;
            this.txtSearchEstateSale.WaterMark = "Buscar Inmueble...";
            this.txtSearchEstateSale.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchEstateSale.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchEstateSale.TextChanged += new System.EventHandler(this.searchSaleEstates_TexChanged);
            // 
            // btnNewEstateSale
            // 
            this.btnNewEstateSale.Location = new System.Drawing.Point(58, 418);
            this.btnNewEstateSale.Name = "btnNewEstateSale";
            this.btnNewEstateSale.Size = new System.Drawing.Size(75, 23);
            this.btnNewEstateSale.TabIndex = 3;
            this.btnNewEstateSale.Text = "Nuevo";
            this.btnNewEstateSale.UseSelectable = true;
            this.btnNewEstateSale.Click += new System.EventHandler(this.btnNewEstateSale_Click);
            // 
            // metroTabAlquiler
            // 
            this.metroTabAlquiler.Controls.Add(this.lvEstatesRent);
            this.metroTabAlquiler.Controls.Add(this.txtSearchEstateRent);
            this.metroTabAlquiler.Controls.Add(this.btnNewEstateRent);
            this.metroTabAlquiler.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabAlquiler.HorizontalScrollbarBarColor = true;
            this.metroTabAlquiler.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabAlquiler.HorizontalScrollbarSize = 10;
            this.metroTabAlquiler.Location = new System.Drawing.Point(4, 38);
            this.metroTabAlquiler.Name = "metroTabAlquiler";
            this.metroTabAlquiler.Size = new System.Drawing.Size(1088, 531);
            this.metroTabAlquiler.TabIndex = 2;
            this.metroTabAlquiler.Text = "Alquiler";
            this.metroTabAlquiler.VerticalScrollbarBarColor = true;
            this.metroTabAlquiler.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabAlquiler.VerticalScrollbarSize = 10;
            // 
            // lvEstatesRent
            // 
            this.lvEstatesRent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvEstatesRent.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEstatesRent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvEstatesRent.FullRowSelect = true;
            this.lvEstatesRent.Location = new System.Drawing.Point(58, 18);
            this.lvEstatesRent.MultiSelect = false;
            this.lvEstatesRent.Name = "lvEstatesRent";
            this.lvEstatesRent.Size = new System.Drawing.Size(970, 382);
            this.lvEstatesRent.TabIndex = 31;
            this.lvEstatesRent.UseCompatibleStateImageBehavior = false;
            this.lvEstatesRent.View = System.Windows.Forms.View.Details;
            this.lvEstatesRent.DoubleClick += new System.EventHandler(this.lvEstatesRent_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Expediente";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripción Inmueble";
            this.columnHeader2.Width = 325;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Dirección Inmueble";
            this.columnHeader3.Width = 325;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Localidad";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fecha";
            this.columnHeader5.Width = 110;
            // 
            // txtSearchEstateRent
            // 
            // 
            // 
            // 
            this.txtSearchEstateRent.CustomButton.Image = null;
            this.txtSearchEstateRent.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txtSearchEstateRent.CustomButton.Name = "";
            this.txtSearchEstateRent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchEstateRent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchEstateRent.CustomButton.TabIndex = 1;
            this.txtSearchEstateRent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchEstateRent.CustomButton.UseSelectable = true;
            this.txtSearchEstateRent.CustomButton.Visible = false;
            this.txtSearchEstateRent.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearchEstateRent.Lines = new string[0];
            this.txtSearchEstateRent.Location = new System.Drawing.Point(139, 417);
            this.txtSearchEstateRent.MaxLength = 32767;
            this.txtSearchEstateRent.Name = "txtSearchEstateRent";
            this.txtSearchEstateRent.PasswordChar = '\0';
            this.txtSearchEstateRent.PromptText = "Buscar Inmueble...";
            this.txtSearchEstateRent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchEstateRent.SelectedText = "";
            this.txtSearchEstateRent.SelectionLength = 0;
            this.txtSearchEstateRent.SelectionStart = 0;
            this.txtSearchEstateRent.ShortcutsEnabled = true;
            this.txtSearchEstateRent.Size = new System.Drawing.Size(220, 23);
            this.txtSearchEstateRent.TabIndex = 24;
            this.txtSearchEstateRent.UseSelectable = true;
            this.txtSearchEstateRent.WaterMark = "Buscar Inmueble...";
            this.txtSearchEstateRent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchEstateRent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchEstateRent.TextChanged += new System.EventHandler(this.searchRentEstates_TexChanged);
            // 
            // btnNewEstateRent
            // 
            this.btnNewEstateRent.Location = new System.Drawing.Point(58, 417);
            this.btnNewEstateRent.Name = "btnNewEstateRent";
            this.btnNewEstateRent.Size = new System.Drawing.Size(75, 23);
            this.btnNewEstateRent.TabIndex = 4;
            this.btnNewEstateRent.Text = "Nuevo";
            this.btnNewEstateRent.UseSelectable = true;
            this.btnNewEstateRent.Click += new System.EventHandler(this.btnNewEstateRent_Click);
            // 
            // metroTabAlquilerOpcionCompra
            // 
            this.metroTabAlquilerOpcionCompra.Controls.Add(this.lvEstatesSaleOption);
            this.metroTabAlquilerOpcionCompra.Controls.Add(this.txtSearchEstateSaleOption);
            this.metroTabAlquilerOpcionCompra.Controls.Add(this.btnNewEstateSaleOption);
            this.metroTabAlquilerOpcionCompra.HorizontalScrollbarBarColor = true;
            this.metroTabAlquilerOpcionCompra.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabAlquilerOpcionCompra.HorizontalScrollbarSize = 10;
            this.metroTabAlquilerOpcionCompra.Location = new System.Drawing.Point(4, 38);
            this.metroTabAlquilerOpcionCompra.Name = "metroTabAlquilerOpcionCompra";
            this.metroTabAlquilerOpcionCompra.Size = new System.Drawing.Size(1088, 531);
            this.metroTabAlquilerOpcionCompra.TabIndex = 3;
            this.metroTabAlquilerOpcionCompra.Text = "Alquiler Opción Compra";
            this.metroTabAlquilerOpcionCompra.VerticalScrollbarBarColor = true;
            this.metroTabAlquilerOpcionCompra.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabAlquilerOpcionCompra.VerticalScrollbarSize = 10;
            // 
            // lvEstatesSaleOption
            // 
            this.lvEstatesSaleOption.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvEstatesSaleOption.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEstatesSaleOption.FullRowSelect = true;
            this.lvEstatesSaleOption.Location = new System.Drawing.Point(58, 18);
            this.lvEstatesSaleOption.MultiSelect = false;
            this.lvEstatesSaleOption.Name = "lvEstatesSaleOption";
            this.lvEstatesSaleOption.Size = new System.Drawing.Size(970, 382);
            this.lvEstatesSaleOption.TabIndex = 31;
            this.lvEstatesSaleOption.UseCompatibleStateImageBehavior = false;
            this.lvEstatesSaleOption.View = System.Windows.Forms.View.Details;
            this.lvEstatesSaleOption.DoubleClick += new System.EventHandler(this.lvEstatesSaleOption_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Expediente";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Descripción Inmueble";
            this.columnHeader7.Width = 325;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Dirección Inmueble";
            this.columnHeader8.Width = 325;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Localidad";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Fecha";
            this.columnHeader10.Width = 110;
            // 
            // txtSearchEstateSaleOption
            // 
            // 
            // 
            // 
            this.txtSearchEstateSaleOption.CustomButton.Image = null;
            this.txtSearchEstateSaleOption.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txtSearchEstateSaleOption.CustomButton.Name = "";
            this.txtSearchEstateSaleOption.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchEstateSaleOption.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchEstateSaleOption.CustomButton.TabIndex = 1;
            this.txtSearchEstateSaleOption.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchEstateSaleOption.CustomButton.UseSelectable = true;
            this.txtSearchEstateSaleOption.CustomButton.Visible = false;
            this.txtSearchEstateSaleOption.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearchEstateSaleOption.Lines = new string[0];
            this.txtSearchEstateSaleOption.Location = new System.Drawing.Point(139, 417);
            this.txtSearchEstateSaleOption.MaxLength = 32767;
            this.txtSearchEstateSaleOption.Name = "txtSearchEstateSaleOption";
            this.txtSearchEstateSaleOption.PasswordChar = '\0';
            this.txtSearchEstateSaleOption.PromptText = "Buscar Inmueble...";
            this.txtSearchEstateSaleOption.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchEstateSaleOption.SelectedText = "";
            this.txtSearchEstateSaleOption.SelectionLength = 0;
            this.txtSearchEstateSaleOption.SelectionStart = 0;
            this.txtSearchEstateSaleOption.ShortcutsEnabled = true;
            this.txtSearchEstateSaleOption.Size = new System.Drawing.Size(220, 23);
            this.txtSearchEstateSaleOption.TabIndex = 24;
            this.txtSearchEstateSaleOption.UseSelectable = true;
            this.txtSearchEstateSaleOption.WaterMark = "Buscar Inmueble...";
            this.txtSearchEstateSaleOption.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchEstateSaleOption.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchEstateSaleOption.TextChanged += new System.EventHandler(this.searchSaleOptionEstates_TexChanged);
            // 
            // btnNewEstateSaleOption
            // 
            this.btnNewEstateSaleOption.Location = new System.Drawing.Point(58, 417);
            this.btnNewEstateSaleOption.Name = "btnNewEstateSaleOption";
            this.btnNewEstateSaleOption.Size = new System.Drawing.Size(75, 23);
            this.btnNewEstateSaleOption.TabIndex = 4;
            this.btnNewEstateSaleOption.Text = "Nuevo";
            this.btnNewEstateSaleOption.UseSelectable = true;
            this.btnNewEstateSaleOption.Click += new System.EventHandler(this.btnNewEstateSaleOption_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::SSUrban.Properties.Resources.ssurban_horizontal;
            this.picBoxLogo.Location = new System.Drawing.Point(31, 13);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(285, 53);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 1;
            this.picBoxLogo.TabStop = false;
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pBoxLogo.TabIndex = 0;
            this.pBoxLogo.TabStop = false;
            // 
            // metroStyleManagerMain
            // 
            this.metroStyleManagerMain.Owner = this;
            this.metroStyleManagerMain.Style = MetroFramework.MetroColorStyle.Yellow;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(1080, 636);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 13);
            this.lblVersion.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 654);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.metroTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroTabControl.ResumeLayout(false);
            this.metroTabClientes.ResumeLayout(false);
            this.metroTabClientes.PerformLayout();
            this.metroTabVenta.ResumeLayout(false);
            this.metroTabAlquiler.ResumeLayout(false);
            this.metroTabAlquilerOpcionCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabClientes;
        private MetroFramework.Controls.MetroTextBox txtObservaciones;
        private MetroFramework.Controls.MetroLabel lblObservaciones;
        private MetroFramework.Controls.MetroTextBox txtMail;
        private MetroFramework.Controls.MetroLabel lblMail;
        private MetroFramework.Controls.MetroTextBox txtTelephone;
        private MetroFramework.Controls.MetroLabel lblTelephone;
        private MetroFramework.Controls.MetroTextBox txtDNI;
        private MetroFramework.Controls.MetroLabel lblDni;
        private MetroFramework.Controls.MetroTextBox txtSurname;
        private MetroFramework.Controls.MetroLabel lblSurname;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroButton btnSaveCustomer;
        private System.Windows.Forms.ListView clientsView;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnSurname;
        private System.Windows.Forms.ColumnHeader columnDNI;
        private System.Windows.Forms.ColumnHeader columnTelephone;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroLabel lblAddress;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.ColumnHeader columnAddress;
        private MetroFramework.Controls.MetroLabel lblEstates;
        private MetroFramework.Controls.MetroLabel lblClientes;
        private System.Windows.Forms.ListView estatesListView;
        private System.Windows.Forms.ColumnHeader columnExpediente;
        private System.Windows.Forms.ColumnHeader columnLocalidad;
        private System.Windows.Forms.ColumnHeader columnDireccion;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private MetroFramework.Components.MetroStyleManager metroStyleManagerMain;
        private MetroFramework.Controls.MetroTabPage metroTabVenta;
        private MetroFramework.Controls.MetroTabPage metroTabAlquiler;
        private MetroFramework.Controls.MetroTabPage metroTabAlquilerOpcionCompra;
        private MetroFramework.Controls.MetroTextBox txtSearchEstateSale;
        private MetroFramework.Controls.MetroButton btnNewEstateSale;
        private MetroFramework.Controls.MetroTextBox txtSearchEstateRent;
        private MetroFramework.Controls.MetroButton btnNewEstateRent;
        private MetroFramework.Controls.MetroTextBox txtSearchEstateSaleOption;
        private MetroFramework.Controls.MetroButton btnNewEstateSaleOption;
        private System.Windows.Forms.ListView lvEstatesSale;
        private System.Windows.Forms.ColumnHeader headerExpediente;
        private System.Windows.Forms.ColumnHeader headerDescripcion;
        private System.Windows.Forms.ColumnHeader headerDireccion;
        private System.Windows.Forms.ColumnHeader headerLocalidad;
        private System.Windows.Forms.ColumnHeader headerFecha;
        private System.Windows.Forms.ListView lvEstatesRent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvEstatesSaleOption;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label lblVersion;
    }
}

