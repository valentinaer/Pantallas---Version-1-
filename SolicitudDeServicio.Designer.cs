namespace grupoB_TP
{
    partial class SolicitudDeServicio
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
            System.Windows.Forms.TextBox txtDirrecionDestino;
            System.Windows.Forms.TextBox txtAlturaDestino;
            System.Windows.Forms.TextBox txtDirrecionOrigen;
            System.Windows.Forms.TextBox txtAlturaOrigen;
            this.cmbRangoPeso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkUrgente = new System.Windows.Forms.CheckBox();
            this.rboEntregaSucursal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbPaisInternacional = new System.Windows.Forms.ComboBox();
            this.cmbRegionInteracional = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rboInteracional = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCiudadDestino = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rboNacional = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbSucursalesDestino = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCiudadOrigen = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSucursalOrigen = new System.Windows.Forms.ComboBox();
            this.rboRetiroDomicilio = new System.Windows.Forms.RadioButton();
            this.cmbProvinciaOrigen = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rboRecibeSucursal = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.grpCotizacion = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblUrgente = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            txtDirrecionDestino = new System.Windows.Forms.TextBox();
            txtAlturaDestino = new System.Windows.Forms.TextBox();
            txtDirrecionOrigen = new System.Windows.Forms.TextBox();
            txtAlturaOrigen = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grpCotizacion.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDirrecionDestino
            // 
            txtDirrecionDestino.Location = new System.Drawing.Point(117, 152);
            txtDirrecionDestino.Name = "txtDirrecionDestino";
            txtDirrecionDestino.Size = new System.Drawing.Size(333, 29);
            txtDirrecionDestino.TabIndex = 1;
            // 
            // txtAlturaDestino
            // 
            txtAlturaDestino.Location = new System.Drawing.Point(117, 186);
            txtAlturaDestino.Name = "txtAlturaDestino";
            txtAlturaDestino.Size = new System.Drawing.Size(111, 29);
            txtAlturaDestino.TabIndex = 14;
            // 
            // txtDirrecionOrigen
            // 
            txtDirrecionOrigen.Location = new System.Drawing.Point(133, 194);
            txtDirrecionOrigen.Name = "txtDirrecionOrigen";
            txtDirrecionOrigen.Size = new System.Drawing.Size(294, 29);
            txtDirrecionOrigen.TabIndex = 1;
            txtDirrecionOrigen.TextChanged += new System.EventHandler(this.txtOrigen_TextChanged);
            // 
            // txtAlturaOrigen
            // 
            txtAlturaOrigen.Location = new System.Drawing.Point(133, 234);
            txtAlturaOrigen.Name = "txtAlturaOrigen";
            txtAlturaOrigen.Size = new System.Drawing.Size(111, 29);
            txtAlturaOrigen.TabIndex = 14;
            // 
            // cmbRangoPeso
            // 
            this.cmbRangoPeso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRangoPeso.FormattingEnabled = true;
            this.cmbRangoPeso.Items.AddRange(new object[] {
            "Correspondencia  de Hasta 500 gr",
            "Encomiendas de Hasta 10 kg",
            "Encomiendas de Hasta 20 kg",
            "Encomiendas de Hasta 30 kg"});
            this.cmbRangoPeso.Location = new System.Drawing.Point(136, 26);
            this.cmbRangoPeso.Name = "cmbRangoPeso";
            this.cmbRangoPeso.Size = new System.Drawing.Size(262, 29);
            this.cmbRangoPeso.TabIndex = 0;
            this.cmbRangoPeso.SelectedIndexChanged += new System.EventHandler(this.cmbRangoPeso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rango de Peso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkUrgente
            // 
            this.chkUrgente.AutoSize = true;
            this.chkUrgente.Location = new System.Drawing.Point(456, 28);
            this.chkUrgente.Name = "chkUrgente";
            this.chkUrgente.Size = new System.Drawing.Size(186, 25);
            this.chkUrgente.TabIndex = 3;
            this.chkUrgente.Text = "Urgente (Recargo X %)";
            this.chkUrgente.UseVisualStyleBackColor = true;
            this.chkUrgente.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rboEntregaSucursal
            // 
            this.rboEntregaSucursal.AutoSize = true;
            this.rboEntregaSucursal.Location = new System.Drawing.Point(26, 19);
            this.rboEntregaSucursal.Name = "rboEntregaSucursal";
            this.rboEntregaSucursal.Size = new System.Drawing.Size(109, 25);
            this.rboEntregaSucursal.TabIndex = 4;
            this.rboEntregaSucursal.TabStop = true;
            this.rboEntregaSucursal.Text = "Entrega en :";
            this.rboEntregaSucursal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbRangoPeso);
            this.groupBox1.Controls.Add(this.chkUrgente);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caracteristica del Servicio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(462, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 313);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Entrega";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(txtAlturaDestino);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(txtDirrecionDestino);
            this.groupBox4.Location = new System.Drawing.Point(6, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(470, 222);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "A domicilio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Altura : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dirrecion : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbPaisInternacional);
            this.panel2.Controls.Add(this.cmbRegionInteracional);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.rboInteracional);
            this.panel2.Location = new System.Drawing.Point(242, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 113);
            this.panel2.TabIndex = 11;
            // 
            // cmbPaisInternacional
            // 
            this.cmbPaisInternacional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaisInternacional.FormattingEnabled = true;
            this.cmbPaisInternacional.Items.AddRange(new object[] {
            "Madrid, España",
            "Paris, Francia",
            "Roma, Italia",
            "Londres, UK",
            "Berlin, Alemania"});
            this.cmbPaisInternacional.Location = new System.Drawing.Point(75, 71);
            this.cmbPaisInternacional.Name = "cmbPaisInternacional";
            this.cmbPaisInternacional.Size = new System.Drawing.Size(144, 29);
            this.cmbPaisInternacional.TabIndex = 4;
            // 
            // cmbRegionInteracional
            // 
            this.cmbRegionInteracional.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbRegionInteracional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegionInteracional.FormattingEnabled = true;
            this.cmbRegionInteracional.Items.AddRange(new object[] {
            "Países limítrofes.",
            "Resto de América Latina",
            "America del Norte",
            "Europa",
            "Asia"});
            this.cmbRegionInteracional.Location = new System.Drawing.Point(75, 36);
            this.cmbRegionInteracional.Name = "cmbRegionInteracional";
            this.cmbRegionInteracional.Size = new System.Drawing.Size(144, 29);
            this.cmbRegionInteracional.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pais : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Region : ";
            // 
            // rboInteracional
            // 
            this.rboInteracional.AutoSize = true;
            this.rboInteracional.ForeColor = System.Drawing.Color.Purple;
            this.rboInteracional.Location = new System.Drawing.Point(45, 3);
            this.rboInteracional.Name = "rboInteracional";
            this.rboInteracional.Size = new System.Drawing.Size(118, 25);
            this.rboInteracional.TabIndex = 0;
            this.rboInteracional.TabStop = true;
            this.rboInteracional.Text = "Internacional";
            this.rboInteracional.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCiudadDestino);
            this.panel1.Controls.Add(this.cmbProvincia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rboNacional);
            this.panel1.Location = new System.Drawing.Point(6, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 113);
            this.panel1.TabIndex = 10;
            // 
            // cmbCiudadDestino
            // 
            this.cmbCiudadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudadDestino.FormattingEnabled = true;
            this.cmbCiudadDestino.Items.AddRange(new object[] {
            "Mar del Plata",
            "Quilmes",
            "Bahia Blanca",
            "Salto"});
            this.cmbCiudadDestino.Location = new System.Drawing.Point(87, 78);
            this.cmbCiudadDestino.Name = "cmbCiudadDestino";
            this.cmbCiudadDestino.Size = new System.Drawing.Size(121, 29);
            this.cmbCiudadDestino.TabIndex = 4;
            this.cmbCiudadDestino.SelectedIndexChanged += new System.EventHandler(this.cmbCiudad_SelectedIndexChanged);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Items.AddRange(new object[] {
            "BUENOS AIRES",
            "CIUDAD AUTÓNOMA DE BUENOS AIRES",
            "CATAMARCA",
            "CHACO",
            "CHUBUT",
            "CÓRDOBA",
            "CORRIENTES",
            "ENTRE RÍOS",
            "FORMOSA",
            "JUJUY",
            "LA PAMPA",
            "LA RIOJA",
            "MENDOZA",
            "MISIONES",
            "NEUQUÉN",
            "RÍO NEGRO",
            "SALTA",
            "SAN JUAN",
            "SAN LUIS",
            "SANTA CRUZ",
            "SANTA FE",
            "SANTIAGO DEL ESTERO",
            "TIERRA DEL FUEGO, ANTÁRTIDA E ISLAS DEL ATLÁNTICO SUR",
            "TUCUMÁN"});
            this.cmbProvincia.Location = new System.Drawing.Point(87, 34);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 29);
            this.cmbProvincia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provincia : ";
            // 
            // rboNacional
            // 
            this.rboNacional.AutoSize = true;
            this.rboNacional.ForeColor = System.Drawing.Color.Purple;
            this.rboNacional.Location = new System.Drawing.Point(62, 3);
            this.rboNacional.Name = "rboNacional";
            this.rboNacional.Size = new System.Drawing.Size(89, 25);
            this.rboNacional.TabIndex = 0;
            this.rboNacional.TabStop = true;
            this.rboNacional.Text = "Nacional";
            this.rboNacional.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbSucursalesDestino);
            this.groupBox3.Controls.Add(this.rboEntregaSucursal);
            this.groupBox3.Location = new System.Drawing.Point(6, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 47);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sucursal";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cmbSucursalesDestino
            // 
            this.cmbSucursalesDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursalesDestino.FormattingEnabled = true;
            this.cmbSucursalesDestino.Items.AddRange(new object[] {
            "1 - Cordoba 6571, CABA",
            "2 - Av. San Martín 2871, Viedma, Rio Negro",
            "3 - Juana Azurduy 850, Resistencia, Chaco",
            "4 - Goyeneche 724, Córdoba, Córdoba"});
            this.cmbSucursalesDestino.Location = new System.Drawing.Point(141, 15);
            this.cmbSucursalesDestino.Name = "cmbSucursalesDestino";
            this.cmbSucursalesDestino.Size = new System.Drawing.Size(323, 29);
            this.cmbSucursalesDestino.TabIndex = 5;
            this.cmbSucursalesDestino.SelectedIndexChanged += new System.EventHandler(this.cmbSucursales_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(txtDirrecionOrigen);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(txtAlturaOrigen);
            this.groupBox5.Controls.Add(this.cmbCiudadOrigen);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.cmbSucursalOrigen);
            this.groupBox5.Controls.Add(this.rboRetiroDomicilio);
            this.groupBox5.Controls.Add(this.cmbProvinciaOrigen);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.rboRecibeSucursal);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(12, 104);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(442, 313);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tipo de Recepcion";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Dirrecion : ";
            // 
            // cmbCiudadOrigen
            // 
            this.cmbCiudadOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudadOrigen.FormattingEnabled = true;
            this.cmbCiudadOrigen.Items.AddRange(new object[] {
            "Mar del Plata",
            "Quilmes",
            "Bahia Blanca",
            "Salto"});
            this.cmbCiudadOrigen.Location = new System.Drawing.Point(133, 146);
            this.cmbCiudadOrigen.Name = "cmbCiudadOrigen";
            this.cmbCiudadOrigen.Size = new System.Drawing.Size(180, 29);
            this.cmbCiudadOrigen.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Altura : ";
            // 
            // cmbSucursalOrigen
            // 
            this.cmbSucursalOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursalOrigen.FormattingEnabled = true;
            this.cmbSucursalOrigen.Items.AddRange(new object[] {
            "1 - Cordoba 6571, CABA",
            "2 - Av. San Martín 2871, Viedma, Rio Negro",
            "3 - Juana Azurduy 850, Resistencia, Chaco",
            "4 - Goyeneche 724, Córdoba, Córdoba"});
            this.cmbSucursalOrigen.Location = new System.Drawing.Point(116, 28);
            this.cmbSucursalOrigen.Name = "cmbSucursalOrigen";
            this.cmbSucursalOrigen.Size = new System.Drawing.Size(320, 29);
            this.cmbSucursalOrigen.TabIndex = 5;
            // 
            // rboRetiroDomicilio
            // 
            this.rboRetiroDomicilio.AutoSize = true;
            this.rboRetiroDomicilio.Location = new System.Drawing.Point(6, 72);
            this.rboRetiroDomicilio.Name = "rboRetiroDomicilio";
            this.rboRetiroDomicilio.Size = new System.Drawing.Size(152, 25);
            this.rboRetiroDomicilio.TabIndex = 15;
            this.rboRetiroDomicilio.TabStop = true;
            this.rboRetiroDomicilio.Text = "Retiro a Domicilio";
            this.rboRetiroDomicilio.UseVisualStyleBackColor = true;
            // 
            // cmbProvinciaOrigen
            // 
            this.cmbProvinciaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvinciaOrigen.FormattingEnabled = true;
            this.cmbProvinciaOrigen.Items.AddRange(new object[] {
            "BUENOS AIRES",
            "CIUDAD AUTÓNOMA DE BUENOS AIRES",
            "CATAMARCA",
            "CHACO",
            "CHUBUT",
            "CÓRDOBA",
            "CORRIENTES",
            "ENTRE RÍOS",
            "FORMOSA",
            "JUJUY",
            "LA PAMPA",
            "LA RIOJA",
            "MENDOZA",
            "MISIONES",
            "NEUQUÉN",
            "RÍO NEGRO",
            "SALTA",
            "SAN JUAN",
            "SAN LUIS",
            "SANTA CRUZ",
            "SANTA FE",
            "SANTIAGO DEL ESTERO",
            "TIERRA DEL FUEGO, ANTÁRTIDA E ISLAS DEL ATLÁNTICO SUR",
            "TUCUMÁN"});
            this.cmbProvinciaOrigen.Location = new System.Drawing.Point(133, 104);
            this.cmbProvinciaOrigen.Name = "cmbProvinciaOrigen";
            this.cmbProvinciaOrigen.Size = new System.Drawing.Size(180, 29);
            this.cmbProvinciaOrigen.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ciudad : ";
            // 
            // rboRecibeSucursal
            // 
            this.rboRecibeSucursal.AutoSize = true;
            this.rboRecibeSucursal.Location = new System.Drawing.Point(6, 27);
            this.rboRecibeSucursal.Name = "rboRecibeSucursal";
            this.rboRecibeSucursal.Size = new System.Drawing.Size(113, 25);
            this.rboRecibeSucursal.TabIndex = 4;
            this.rboRecibeSucursal.TabStop = true;
            this.rboRecibeSucursal.Text = "En sucursal: ";
            this.rboRecibeSucursal.UseVisualStyleBackColor = true;
            this.rboRecibeSucursal.CheckedChanged += new System.EventHandler(this.rboRecibeSucursal_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Provincia : ";
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenuPrincipal.ForeColor = System.Drawing.Color.Purple;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(212, 5);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(545, 25);
            this.lblMenuPrincipal.TabIndex = 11;
            this.lblMenuPrincipal.Text = "Ingrese los Siguientes Datos para realizar la Cotizacion del Servicio :";
            this.lblMenuPrincipal.Click += new System.EventHandler(this.lblMenuPrincipal_Click);
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.Color.Chocolate;
            this.btnCotizar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCotizar.Location = new System.Drawing.Point(150, 421);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(151, 30);
            this.btnCotizar.TabIndex = 12;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = false;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // grpCotizacion
            // 
            this.grpCotizacion.Controls.Add(this.btnConfirmar);
            this.grpCotizacion.Controls.Add(this.groupBox9);
            this.grpCotizacion.Controls.Add(this.groupBox8);
            this.grpCotizacion.Controls.Add(this.groupBox7);
            this.grpCotizacion.Controls.Add(this.groupBox6);
            this.grpCotizacion.Controls.Add(this.label15);
            this.grpCotizacion.Controls.Add(this.label14);
            this.grpCotizacion.Controls.Add(this.label13);
            this.grpCotizacion.Controls.Add(this.label12);
            this.grpCotizacion.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpCotizacion.ForeColor = System.Drawing.Color.Purple;
            this.grpCotizacion.Location = new System.Drawing.Point(974, 104);
            this.grpCotizacion.Name = "grpCotizacion";
            this.grpCotizacion.Size = new System.Drawing.Size(265, 275);
            this.grpCotizacion.TabIndex = 13;
            this.grpCotizacion.TabStop = false;
            this.grpCotizacion.Text = "Datos del pedido";
            this.grpCotizacion.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Chocolate;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmar.Location = new System.Drawing.Point(81, 226);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(97, 32);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblCotizacion);
            this.groupBox9.Location = new System.Drawing.Point(99, 168);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(146, 39);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Location = new System.Drawing.Point(21, 11);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(20, 25);
            this.lblCotizacion.TabIndex = 0;
            this.lblCotizacion.Text = "x";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblUrgente);
            this.groupBox8.Location = new System.Drawing.Point(99, 117);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(146, 39);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            // 
            // lblUrgente
            // 
            this.lblUrgente.AutoSize = true;
            this.lblUrgente.Location = new System.Drawing.Point(21, 11);
            this.lblUrgente.Name = "lblUrgente";
            this.lblUrgente.Size = new System.Drawing.Size(20, 25);
            this.lblUrgente.TabIndex = 0;
            this.lblUrgente.Text = "x";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblDestino);
            this.groupBox7.Location = new System.Drawing.Point(99, 72);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(146, 39);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(21, 11);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(20, 25);
            this.lblDestino.TabIndex = 0;
            this.lblDestino.Text = "x";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblOrigen);
            this.groupBox6.Location = new System.Drawing.Point(99, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(146, 39);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(21, 11);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(20, 25);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "x";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(8, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 21);
            this.label15.TabIndex = 3;
            this.label15.Text = "Cotización:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(8, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 21);
            this.label14.TabIndex = 2;
            this.label14.Text = "Urgente:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(8, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "Destino:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(8, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Origen:";
            // 
            // SolicitudDeServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1251, 463);
            this.Controls.Add(this.grpCotizacion);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SolicitudDeServicio";
            this.Text = "Solicitud de Servicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grpCotizacion.ResumeLayout(false);
            this.grpCotizacion.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbRangoPeso;
        private TextBox txtDirrecionDestino;
        private Label label1;
        private CheckBox chkUrgente;
        private RadioButton rboEntregaSucursal;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox cmbSucursalesDestino;
        private GroupBox groupBox4;
        private Panel panel1;
        private RadioButton rboNacional;
        private Label label3;
        private Label label2;
        private ComboBox cmbProvincia;
        private Panel panel2;
        private ComboBox cmbPaisInternacional;
        private ComboBox cmbRegionInteracional;
        private Label label4;
        private Label label5;
        private RadioButton rboInteracional;
        private ComboBox cmbCiudadDestino;
        private Label label6;
        private Label label7;
        private GroupBox groupBox5;
        private ComboBox cmbSucursalOrigen;
        private RadioButton rboRecibeSucursal;
        private RadioButton rboRetiroDomicilio;
        private ComboBox cmbCiudadOrigen;
        private ComboBox cmbProvinciaOrigen;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label lblMenuPrincipal;
        private Button btnCotizar;
        private GroupBox grpCotizacion;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private GroupBox groupBox6;
        private Label lblOrigen;
        private GroupBox groupBox9;
        private Label lblCotizacion;
        private GroupBox groupBox8;
        private Label lblUrgente;
        private GroupBox groupBox7;
        private Label lblDestino;
        private Button btnConfirmar;
    }
}