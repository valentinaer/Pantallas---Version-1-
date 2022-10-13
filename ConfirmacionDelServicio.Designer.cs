namespace grupoB_TP
{
    partial class ConfirmacionDelServicio
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnConfirmarPedido = new System.Windows.Forms.Button();
            this.gbDatosDelPedido = new System.Windows.Forms.GroupBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblUrgente = new System.Windows.Forms.Label();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.gbDatosDelPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(30, 265);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(122, 30);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            // 
            // btnConfirmarPedido
            // 
            this.btnConfirmarPedido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnConfirmarPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarPedido.Location = new System.Drawing.Point(158, 265);
            this.btnConfirmarPedido.Name = "btnConfirmarPedido";
            this.btnConfirmarPedido.Size = new System.Drawing.Size(137, 30);
            this.btnConfirmarPedido.TabIndex = 1;
            this.btnConfirmarPedido.Text = "Confirmar pedido";
            this.btnConfirmarPedido.UseVisualStyleBackColor = false;
            // 
            // gbDatosDelPedido
            // 
            this.gbDatosDelPedido.Controls.Add(this.lblCotizacion);
            this.gbDatosDelPedido.Controls.Add(this.lblUrgente);
            this.gbDatosDelPedido.Controls.Add(this.lblDestino);
            this.gbDatosDelPedido.Controls.Add(this.lblOrigen);
            this.gbDatosDelPedido.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbDatosDelPedido.ForeColor = System.Drawing.Color.Purple;
            this.gbDatosDelPedido.Location = new System.Drawing.Point(30, 21);
            this.gbDatosDelPedido.Name = "gbDatosDelPedido";
            this.gbDatosDelPedido.Size = new System.Drawing.Size(265, 229);
            this.gbDatosDelPedido.TabIndex = 3;
            this.gbDatosDelPedido.TabStop = false;
            this.gbDatosDelPedido.Text = "Datos del pedido";
            this.gbDatosDelPedido.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrigen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrigen.Location = new System.Drawing.Point(22, 39);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(61, 21);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            this.lblOrigen.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDestino.Location = new System.Drawing.Point(22, 91);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(66, 21);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";
            // 
            // lblUrgente
            // 
            this.lblUrgente.AutoSize = true;
            this.lblUrgente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUrgente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUrgente.Location = new System.Drawing.Point(22, 137);
            this.lblUrgente.Name = "lblUrgente";
            this.lblUrgente.Size = new System.Drawing.Size(69, 21);
            this.lblUrgente.TabIndex = 2;
            this.lblUrgente.Text = "Urgente:";
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCotizacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCotizacion.Location = new System.Drawing.Point(22, 186);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(85, 21);
            this.lblCotizacion.TabIndex = 3;
            this.lblCotizacion.Text = "Cotización:";
            // 
            // ConfirmacionDelServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 309);
            this.Controls.Add(this.gbDatosDelPedido);
            this.Controls.Add(this.btnConfirmarPedido);
            this.Controls.Add(this.btnAtras);
            this.Name = "ConfirmacionDelServicio";
            this.Text = "ConfirmacionDelServicio";
            this.Load += new System.EventHandler(this.ConfirmacionDelServicio_Load);
            this.gbDatosDelPedido.ResumeLayout(false);
            this.gbDatosDelPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAtras;
        private Button btnConfirmarPedido;
        private GroupBox gbDatosDelPedido;
        private Label lblOrigen;
        private Label lblCotizacion;
        private Label lblUrgente;
        private Label lblDestino;
    }
}