namespace TailorManagment.Forms
{
    partial class logo
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
            this.mainlogo = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainlogo
            // 
            this.mainlogo.BackColor = System.Drawing.Color.Transparent;
            this.mainlogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainlogo.ImageRotate = 0F;
            this.mainlogo.Location = new System.Drawing.Point(0, 0);
            this.mainlogo.Name = "mainlogo";
            this.mainlogo.Size = new System.Drawing.Size(800, 450);
            this.mainlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainlogo.TabIndex = 0;
            this.mainlogo.TabStop = false;
            this.mainlogo.UseTransparentBackground = true;
            // 
            // logo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainlogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "logo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logo";
            this.Load += new System.EventHandler(this.logo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox mainlogo;
    }
}