namespace Sistema_UNICAH
{
    partial class frmDiagrama
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ltbclases = new System.Windows.Forms.ListBox();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(58, 74);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(568, 429);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // ltbclases
            // 
            this.ltbclases.FormattingEnabled = true;
            this.ltbclases.Location = new System.Drawing.Point(651, 86);
            this.ltbclases.Name = "ltbclases";
            this.ltbclases.Size = new System.Drawing.Size(179, 199);
            this.ltbclases.TabIndex = 1;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.AllowDrop = true;
            this.btnconfirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnconfirmar.BackColor = System.Drawing.Color.White;
            this.btnconfirmar.BackgroundImage = global::Sistema_UNICAH.Properties.Resources.icono;
            this.btnconfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnconfirmar.FlatAppearance.BorderSize = 0;
            this.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnconfirmar.Image = global::Sistema_UNICAH.Properties.Resources.icono;
            this.btnconfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconfirmar.Location = new System.Drawing.Point(666, 309);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(139, 48);
            this.btnconfirmar.TabIndex = 2;
            this.btnconfirmar.Text = "    Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // frmDiagrama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(856, 504);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.ltbclases);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmDiagrama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDiagrama";
            this.Load += new System.EventHandler(this.frmDiagrama_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox ltbclases;
        private System.Windows.Forms.Button btnconfirmar;
    }
}