namespace SourvenirAppMathiasMelo
{
    partial class Baja
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblIDBaja = new System.Windows.Forms.Label();
            this.txtIDBaja = new System.Windows.Forms.TextBox();
            this.btnAltaBaja = new System.Windows.Forms.Button();
            this.btnMoficacionBaja = new System.Windows.Forms.Button();
            this.btnListadoBaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(347, 56);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblIDBaja
            // 
            this.lblIDBaja.AutoSize = true;
            this.lblIDBaja.Location = new System.Drawing.Point(168, 61);
            this.lblIDBaja.Name = "lblIDBaja";
            this.lblIDBaja.Size = new System.Drawing.Size(56, 13);
            this.lblIDBaja.TabIndex = 2;
            this.lblIDBaja.Text = "Ingresa ID";
            // 
            // txtIDBaja
            // 
            this.txtIDBaja.Location = new System.Drawing.Point(241, 56);
            this.txtIDBaja.Name = "txtIDBaja";
            this.txtIDBaja.Size = new System.Drawing.Size(100, 20);
            this.txtIDBaja.TabIndex = 3;
            // 
            // btnAltaBaja
            // 
            this.btnAltaBaja.Location = new System.Drawing.Point(29, 22);
            this.btnAltaBaja.Name = "btnAltaBaja";
            this.btnAltaBaja.Size = new System.Drawing.Size(75, 23);
            this.btnAltaBaja.TabIndex = 4;
            this.btnAltaBaja.Text = "Alta";
            this.btnAltaBaja.UseVisualStyleBackColor = true;
            this.btnAltaBaja.Click += new System.EventHandler(this.btnAltaBaja_Click);
            // 
            // btnMoficacionBaja
            // 
            this.btnMoficacionBaja.Location = new System.Drawing.Point(29, 51);
            this.btnMoficacionBaja.Name = "btnMoficacionBaja";
            this.btnMoficacionBaja.Size = new System.Drawing.Size(75, 23);
            this.btnMoficacionBaja.TabIndex = 5;
            this.btnMoficacionBaja.Text = "Moficación";
            this.btnMoficacionBaja.UseVisualStyleBackColor = true;
            this.btnMoficacionBaja.Click += new System.EventHandler(this.btnMoficacionBaja_Click);
            // 
            // btnListadoBaja
            // 
            this.btnListadoBaja.Location = new System.Drawing.Point(29, 89);
            this.btnListadoBaja.Name = "btnListadoBaja";
            this.btnListadoBaja.Size = new System.Drawing.Size(75, 23);
            this.btnListadoBaja.TabIndex = 8;
            this.btnListadoBaja.Text = "Listado";
            this.btnListadoBaja.UseVisualStyleBackColor = true;
            this.btnListadoBaja.Click += new System.EventHandler(this.btnListadoBaja_Click);
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 130);
            this.Controls.Add(this.btnListadoBaja);
            this.Controls.Add(this.btnMoficacionBaja);
            this.Controls.Add(this.btnAltaBaja);
            this.Controls.Add(this.txtIDBaja);
            this.Controls.Add(this.lblIDBaja);
            this.Controls.Add(this.btnEliminar);
            this.Name = "Baja";
            this.Text = "Baja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblIDBaja;
        private System.Windows.Forms.TextBox txtIDBaja;
        private System.Windows.Forms.Button btnAltaBaja;
        private System.Windows.Forms.Button btnMoficacionBaja;
        private System.Windows.Forms.Button btnListadoBaja;
    }
}