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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDiagrama
            // 
            this.btnDiagrama.BackColor = System.Drawing.Color.White;
            this.btnDiagrama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagrama.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDiagrama.Location = new System.Drawing.Point(511, 194);
            this.btnDiagrama.Name = "btnDiagrama";
            this.btnDiagrama.Size = new System.Drawing.Size(213, 51);
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
            this.btnmatricula.Location = new System.Drawing.Point(730, 194);
            this.btnmatricula.Name = "btnmatricula";
            this.btnmatricula.Size = new System.Drawing.Size(213, 51);
            this.btnmatricula.TabIndex = 1;
            this.btnmatricula.Text = "Matrícula";
            this.btnmatricula.UseVisualStyleBackColor = false;
            this.btnmatricula.Click += new System.EventHandler(this.btnmatricula_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(949, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_UNICAH.Properties.Resources.barraunicah;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1194, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnmatricula);
            this.Controls.Add(this.btnDiagrama);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDiagrama;
        private System.Windows.Forms.Button btnmatricula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

