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
            System.Windows.Forms.TextBox txtDirrecion;
            System.Windows.Forms.TextBox txtAltura;
            System.Windows.Forms.TextBox textBox1;
            System.Windows.Forms.TextBox textBox2;
            this.cmbRangoPeso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkUrgente = new System.Windows.Forms.CheckBox();
            this.rboEntregaSucursal = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rboNacional = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbPaisInternacional = new System.Windows.Forms.ComboBox();
            this.cmbRegionInteracional = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rboInteracional = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            txtDirrecion = new System.Windows.Forms.TextBox();
            txtAltura = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRangoPeso
            // 
            this.cmbRangoPeso.FormattingEnabled = true;
            this.cmbRangoPeso.Items.AddRange(new object[] {
            "Correspondencia  de Hasta 500 gr",
            "Encomiendas de hasta 10 kg"});
            this.cmbRangoPeso.Location = new System.Drawing.Point(131, 35);
            this.cmbRangoPeso.Name = "cmbRangoPeso";
            this.cmbRangoPeso.Size = new System.Drawing.Size(121, 29);
            this.cmbRangoPeso.TabIndex = 0;
            this.cmbRangoPeso.SelectedIndexChanged += new System.EventHandler(this.cmbRangoPeso_SelectedIndexChanged);
            // 
            // txtDirrecion
            // 
            txtDirrecion.Location = new System.Drawing.Point(117, 152);
            txtDirrecion.Name = "txtDirrecion";
            txtDirrecion.Size = new System.Drawing.Size(333, 29);
            txtDirrecion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rango de Peso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkUrgente
            // 
            this.chkUrgente.AutoSize = true;
            this.chkUrgente.Location = new System.Drawing.Point(391, 38);
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
            this.rboEntregaSucursal.Size = new System.Drawing.Size(165, 25);
            this.rboEntregaSucursal.TabIndex = 4;
            this.rboEntregaSucursal.TabStop = true;
            this.rboEntregaSucursal.Text = "Entrega en Sucursal";
            this.rboEntregaSucursal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbRangoPeso);
            this.groupBox1.Controls.Add(this.chkUrgente);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 73);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(509, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 313);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Entrega";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(txtAltura);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(txtDirrecion);
            this.groupBox4.Location = new System.Drawing.Point(6, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(470, 222);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "A domicilio";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCiudad);
            this.panel1.Controls.Add(this.cmbProvincia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rboNacional);
            this.panel1.Location = new System.Drawing.Point(6, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 113);
            this.panel1.TabIndex = 10;
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
            this.groupBox3.Controls.Add(this.cmbSucursales);
            this.groupBox3.Controls.Add(this.rboEntregaSucursal);
            this.groupBox3.Location = new System.Drawing.Point(6, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 47);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sucursal";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(242, 15);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(208, 29);
            this.cmbSucursales.TabIndex = 5;
            this.cmbSucursales.SelectedIndexChanged += new System.EventHandler(this.cmbSucursales_SelectedIndexChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad : ";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(87, 34);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 29);
            this.cmbProvincia.TabIndex = 3;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(87, 78);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(121, 29);
            this.cmbCiudad.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbPaisInternacional);
            this.panel2.Controls.Add(this.cmbRegionInteracional);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.rboInteracional);
            this.panel2.Location = new System.Drawing.Point(239, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 113);
            this.panel2.TabIndex = 11;
            // 
            // cmbPaisInternacional
            // 
            this.cmbPaisInternacional.FormattingEnabled = true;
            this.cmbPaisInternacional.Location = new System.Drawing.Point(87, 78);
            this.cmbPaisInternacional.Name = "cmbPaisInternacional";
            this.cmbPaisInternacional.Size = new System.Drawing.Size(121, 29);
            this.cmbPaisInternacional.TabIndex = 4;
            // 
            // cmbRegionInteracional
            // 
            this.cmbRegionInteracional.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbRegionInteracional.FormattingEnabled = true;
            this.cmbRegionInteracional.Location = new System.Drawing.Point(87, 34);
            this.cmbRegionInteracional.Name = "cmbRegionInteracional";
            this.cmbRegionInteracional.Size = new System.Drawing.Size(121, 29);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dirrecion : ";
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
            // txtAltura
            // 
            txtAltura.Location = new System.Drawing.Point(117, 186);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new System.Drawing.Size(111, 29);
            txtAltura.TabIndex = 14;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(14, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(489, 313);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tipo de Entrega";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(textBox1);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.panel3);
            this.groupBox6.Controls.Add(this.panel4);
            this.groupBox6.Controls.Add(textBox2);
            this.groupBox6.Location = new System.Drawing.Point(6, 82);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(470, 222);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "A domicilio";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(117, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(111, 29);
            textBox1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Altura : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Dirrecion : ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Location = new System.Drawing.Point(239, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 113);
            this.panel3.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(87, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 29);
            this.comboBox2.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Pais : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "Region : ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Purple;
            this.radioButton1.Location = new System.Drawing.Point(45, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(118, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Internacional";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox3);
            this.panel4.Controls.Add(this.comboBox4);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.radioButton2);
            this.panel4.Location = new System.Drawing.Point(6, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 113);
            this.panel4.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(87, 78);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 29);
            this.comboBox3.TabIndex = 4;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(87, 34);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 29);
            this.comboBox4.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ciudad : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "Provincia : ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Purple;
            this.radioButton2.Location = new System.Drawing.Point(62, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 25);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nacional";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(117, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(333, 29);
            textBox2.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBox5);
            this.groupBox7.Controls.Add(this.radioButton3);
            this.groupBox7.Location = new System.Drawing.Point(6, 27);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(470, 47);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sucursal";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(242, 15);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(208, 29);
            this.comboBox5.TabIndex = 5;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(26, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(165, 25);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Entrega en Sucursal";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // SolicitudDeServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "SolicitudDeServicio";
            this.Text = "Solicitud de Servicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmbRangoPeso;
        private TextBox txtDirrecion;
        private Label label1;
        private CheckBox chkUrgente;
        private RadioButton rboEntregaSucursal;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox cmbSucursales;
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
        private ComboBox cmbCiudad;
        private Label label6;
        private Label label7;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Label label8;
        private Label label9;
        private Panel panel3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label10;
        private Label label11;
        private RadioButton radioButton1;
        private Panel panel4;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label12;
        private Label label13;
        private RadioButton radioButton2;
        private GroupBox groupBox7;
        private ComboBox comboBox5;
        private RadioButton radioButton3;
    }
}