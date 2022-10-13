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
            txtDirrecion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.chkUrgente.Location = new System.Drawing.Point(56, 145);
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
            this.button1.Location = new System.Drawing.Point(656, 394);
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
            this.groupBox1.Size = new System.Drawing.Size(281, 186);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(299, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 310);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Entrega";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox4
            // 
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
            this.rboInteracional.Location = new System.Drawing.Point(62, 3);
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
            // SolicitudDeServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}