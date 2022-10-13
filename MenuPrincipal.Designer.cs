namespace grupoB_TP
{
    partial class MenuPrincipal
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
            this.rboSolicitudDeServicio = new System.Windows.Forms.RadioButton();
            this.rboConsultarEstadoDeServicio = new System.Windows.Forms.RadioButton();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rboConsultarEstadoDeCuenta = new System.Windows.Forms.RadioButton();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rboSolicitudDeServicio
            // 
            this.rboSolicitudDeServicio.AutoSize = true;
            this.rboSolicitudDeServicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rboSolicitudDeServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rboSolicitudDeServicio.Location = new System.Drawing.Point(23, 42);
            this.rboSolicitudDeServicio.Name = "rboSolicitudDeServicio";
            this.rboSolicitudDeServicio.Size = new System.Drawing.Size(168, 25);
            this.rboSolicitudDeServicio.TabIndex = 0;
            this.rboSolicitudDeServicio.TabStop = true;
            this.rboSolicitudDeServicio.Text = "Solicitud de Servicio";
            this.rboSolicitudDeServicio.UseVisualStyleBackColor = true;
            // 
            // rboConsultarEstadoDeServicio
            // 
            this.rboConsultarEstadoDeServicio.AutoSize = true;
            this.rboConsultarEstadoDeServicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rboConsultarEstadoDeServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rboConsultarEstadoDeServicio.Location = new System.Drawing.Point(23, 137);
            this.rboConsultarEstadoDeServicio.Name = "rboConsultarEstadoDeServicio";
            this.rboConsultarEstadoDeServicio.Size = new System.Drawing.Size(225, 25);
            this.rboConsultarEstadoDeServicio.TabIndex = 1;
            this.rboConsultarEstadoDeServicio.TabStop = true;
            this.rboConsultarEstadoDeServicio.Text = "Consultar Estado de Servicio";
            this.rboConsultarEstadoDeServicio.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnContinuar.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContinuar.Location = new System.Drawing.Point(25, 209);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(125, 39);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(224, 209);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 39);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // rboConsultarEstadoDeCuenta
            // 
            this.rboConsultarEstadoDeCuenta.AutoSize = true;
            this.rboConsultarEstadoDeCuenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rboConsultarEstadoDeCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rboConsultarEstadoDeCuenta.Location = new System.Drawing.Point(23, 89);
            this.rboConsultarEstadoDeCuenta.Name = "rboConsultarEstadoDeCuenta";
            this.rboConsultarEstadoDeCuenta.Size = new System.Drawing.Size(219, 25);
            this.rboConsultarEstadoDeCuenta.TabIndex = 4;
            this.rboConsultarEstadoDeCuenta.TabStop = true;
            this.rboConsultarEstadoDeCuenta.Text = "Consultar Estado de Cuenta";
            this.rboConsultarEstadoDeCuenta.UseVisualStyleBackColor = true;
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenuPrincipal.ForeColor = System.Drawing.Color.Purple;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(12, 20);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(0, 25);
            this.lblMenuPrincipal.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rboConsultarEstadoDeCuenta);
            this.groupBox1.Controls.Add(this.rboConsultarEstadoDeServicio);
            this.groupBox1.Controls.Add(this.rboSolicitudDeServicio);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Purple;
            this.groupBox1.Location = new System.Drawing.Point(25, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 183);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona la operación a realizar:";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(374, 265);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnContinuar);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rboSolicitudDeServicio;
        private RadioButton rboConsultarEstadoDeServicio;
        private Button btnContinuar;
        private Button btnSalir;
        private RadioButton rboConsultarEstadoDeCuenta;
        private RadioButton rboS;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label lblMenuPrincipal;
        private GroupBox groupBox1;
    }
}