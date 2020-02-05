namespace Cajero_auto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.txtCantifdad = new System.Windows.Forms.TextBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblcantidad.Location = new System.Drawing.Point(12, 23);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(79, 17);
            this.lblcantidad.TabIndex = 0;
            this.lblcantidad.Text = "Cantidad";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuesta.Location = new System.Drawing.Point(12, 83);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(94, 17);
            this.lblrespuesta.TabIndex = 1;
            this.lblrespuesta.Text = "Respuesta";
            // 
            // txtCantifdad
            // 
            this.txtCantifdad.Location = new System.Drawing.Point(111, 23);
            this.txtCantifdad.Name = "txtCantifdad";
            this.txtCantifdad.Size = new System.Drawing.Size(118, 20);
            this.txtCantifdad.TabIndex = 2;
            // 
            // btnRetirar
            // 
            this.btnRetirar.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(111, 179);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(104, 47);
            this.btnRetirar.TabIndex = 3;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(330, 288);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.txtCantifdad);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblcantidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.TextBox txtCantifdad;
        private System.Windows.Forms.Button btnRetirar;
    }
}

