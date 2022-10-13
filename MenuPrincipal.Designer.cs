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
            this.SuspendLayout();
            // 
            // rboSolicitudDeServicio
            // 
            this.rboSolicitudDeServicio.AutoSize = true;
            this.rboSolicitudDeServicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rboSolicitudDeServicio.Location = new System.Drawing.Point(49, 67);
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
            this.rboConsultarEstadoDeServicio.Location = new System.Drawing.Point(49, 101);
            this.rboConsultarEstadoDeServicio.Name = "rboConsultarEstadoDeServicio";
            this.rboConsultarEstadoDeServicio.Size = new System.Drawing.Size(225, 25);
            this.rboConsultarEstadoDeServicio.TabIndex = 1;
            this.rboConsultarEstadoDeServicio.TabStop = true;
            this.rboConsultarEstadoDeServicio.Text = "Consultar Estado de Servicio";
            this.rboConsultarEstadoDeServicio.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinuar.Location = new System.Drawing.Point(35, 194);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(125, 39);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(181, 194);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 39);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // rboConsultarEstadoDeCuenta
            // 
            this.rboConsultarEstadoDeCuenta.AutoSize = true;
            this.rboConsultarEstadoDeCuenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rboConsultarEstadoDeCuenta.Location = new System.Drawing.Point(49, 137);
            this.rboConsultarEstadoDeCuenta.Name = "rboConsultarEstadoDeCuenta";
            this.rboConsultarEstadoDeCuenta.Size = new System.Drawing.Size(238, 25);
            this.rboConsultarEstadoDeCuenta.TabIndex = 4;
            this.rboConsultarEstadoDeCuenta.TabStop = true;
            this.rboConsultarEstadoDeCuenta.Text = "Consulta del Estado de Cuenta";
            this.rboConsultarEstadoDeCuenta.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(348, 295);
            this.Controls.Add(this.rboConsultarEstadoDeCuenta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.rboConsultarEstadoDeServicio);
            this.Controls.Add(this.rboSolicitudDeServicio);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rboSolicitudDeServicio;
        private RadioButton rboConsultarEstadoDeServicio;
        private Button btnContinuar;
        private Button btnSalir;
        private RadioButton rboConsultarEstadoDeCuenta;
    }
}