namespace TailorManagment.Forms
{
    partial class Record1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Record = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Record)).BeginInit();
            this.SuspendLayout();
            // 
            // Record
            // 
            this.Record.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.Record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Record.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(104)))), ((int)(((byte)(144)))));
            this.Record.Location = new System.Drawing.Point(37, 13);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(1300, 640);
            this.Record.TabIndex = 1;
            // 
            // Record1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Record);
            this.Name = "Record1";
            this.Size = new System.Drawing.Size(1366, 668);
            this.Load += new System.EventHandler(this.Record1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Record)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Record;
    }
}
