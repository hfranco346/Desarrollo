namespace Sistema_UNICAH
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDiagrama = new System.Windows.Forms.Button();
            this.btnmatricula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDiagrama
            // 
            this.btnDiagrama.BackColor = System.Drawing.Color.White;
            this.btnDiagrama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagrama.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDiagrama.Location = new System.Drawing.Point(288, 230);
            this.btnDiagrama.Name = "btnDiagrama";
            this.btnDiagrama.Size = new System.Drawing.Size(75, 51);
            this.btnDiagrama.TabIndex = 0;
            this.btnDiagrama.Text = "Diagrama de Clases";
            this.btnDiagrama.UseVisualStyleBackColor = false;
            this.btnDiagrama.Click += new System.EventHandler(this.btnDiagrama_Click);
            // 
            // btnmatricula
            // 
            this.btnmatricula.BackColor = System.Drawing.Color.White;
            this.btnmatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmatricula.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnmatricula.Location = new System.Drawing.Point(288, 161);
            this.btnmatricula.Name = "btnmatricula";
            this.btnmatricula.Size = new System.Drawing.Size(75, 51);
            this.btnmatricula.TabIndex = 1;
            this.btnmatricula.Text = "Matrícula";
            this.btnmatricula.UseVisualStyleBackColor = false;
            this.btnmatricula.Click += new System.EventHandler(this.btnmatricula_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.btnmatricula);
            this.Controls.Add(this.btnDiagrama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDiagrama;
        private System.Windows.Forms.Button btnmatricula;
    }
}

