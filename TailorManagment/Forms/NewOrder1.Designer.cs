namespace TailorManagment.Forms
{
    partial class NewOrder1
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
            this.txtcategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtorderdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtcustomerid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdeliverydate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtfullpayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtadvancepayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpendingpayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtcategory
            // 
            this.txtcategory.BackColor = System.Drawing.Color.Transparent;
            this.txtcategory.BorderRadius = 10;
            this.txtcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.txtcategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtcategory.ItemHeight = 30;
            this.txtcategory.Items.AddRange(new object[] {
            "Pant Coat",
            "Coat",
            "Pant",
            "Shalwar Kameez",
            "Waistcoat",
            "kurta",
            "pajama"});
            this.txtcategory.Location = new System.Drawing.Point(532, 152);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(508, 36);
            this.txtcategory.StartIndex = 0;
            this.txtcategory.TabIndex = 27;
            // 
            // txtorderdate
            // 
            this.txtorderdate.BackColor = System.Drawing.Color.Transparent;
            this.txtorderdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.txtorderdate.BorderRadius = 10;
            this.txtorderdate.Checked = true;
            this.txtorderdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtorderdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtorderdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtorderdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtorderdate.Location = new System.Drawing.Point(532, 215);
            this.txtorderdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtorderdate.MinDate = new System.DateTime(2024, 1, 14, 11, 28, 27, 0);
            this.txtorderdate.Name = "txtorderdate";
            this.txtorderdate.Size = new System.Drawing.Size(508, 36);
            this.txtorderdate.TabIndex = 28;
            this.txtorderdate.Value = new System.DateTime(2024, 1, 14, 11, 28, 27, 0);
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.BackColor = System.Drawing.Color.Transparent;
            this.txtcustomerid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(104)))), ((int)(((byte)(144)))));
            this.txtcustomerid.BorderRadius = 10;
            this.txtcustomerid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcustomerid.DefaultText = "";
            this.txtcustomerid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcustomerid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcustomerid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcustomerid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcustomerid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.txtcustomerid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcustomerid.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcustomerid.Location = new System.Drawing.Point(532, 92);
            this.txtcustomerid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.PasswordChar = '\0';
            this.txtcustomerid.PlaceholderText = "";
            this.txtcustomerid.SelectedText = "";
            this.txtcustomerid.Size = new System.Drawing.Size(508, 36);
            this.txtcustomerid.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.label8.Location = new System.Drawing.Point(220, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 45);
            this.label8.TabIndex = 93;
            this.label8.Text = "Customer ID";
            // 
            // txtdeliverydate
            // 
            this.txtdeliverydate.BackColor = System.Drawing.Color.Transparent;
            this.txtdeliverydate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.txtdeliverydate.BorderRadius = 10;
            this.txtdeliverydate.Checked = true;
            this.txtdeliverydate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtdeliverydate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdeliverydate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdeliverydate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdeliverydate.Location = new System.Drawing.Point(532, 268);
            this.txtdeliverydate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdeliverydate.MinDate = new System.DateTime(2024, 1, 14, 11, 28, 27, 0);
            this.txtdeliverydate.Name = "txtdeliverydate";
            this.txtdeliverydate.Size = new System.Drawing.Size(508, 36);
            this.txtdeliverydate.TabIndex = 28;
            this.txtdeliverydate.Value = new System.DateTime(2024, 1, 14, 11, 28, 27, 0);
            // 
            // txtfullpayment
            // 
            this.txtfullpayment.BackColor = System.Drawing.Color.Transparent;
            this.txtfullpayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(104)))), ((int)(((byte)(144)))));
            this.txtfullpayment.BorderRadius = 10;
            this.txtfullpayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfullpayment.DefaultText = "";
            this.txtfullpayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfullpayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfullpayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfullpayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfullpayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.txtfullpayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfullpayment.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfullpayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfullpayment.Location = new System.Drawing.Point(532, 330);
            this.txtfullpayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfullpayment.Name = "txtfullpayment";
            this.txtfullpayment.PasswordChar = '\0';
            this.txtfullpayment.PlaceholderText = "";
            this.txtfullpayment.SelectedText = "";
            this.txtfullpayment.Size = new System.Drawing.Size(508, 36);
            this.txtfullpayment.TabIndex = 91;
            this.txtfullpayment.TextChanged += new System.EventHandler(this.txtfullpayment_TextChanged);
            // 
            // txtadvancepayment
            // 
            this.txtadvancepayment.BackColor = System.Drawing.Color.Transparent;
            this.txtadvancepayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(104)))), ((int)(((byte)(144)))));
            this.txtadvancepayment.BorderRadius = 10;
            this.txtadvancepayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtadvancepayment.DefaultText = "";
            this.txtadvancepayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtadvancepayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtadvancepayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadvancepayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadvancepayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.txtadvancepayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadvancepayment.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadvancepayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadvancepayment.Location = new System.Drawing.Point(532, 388);
            this.txtadvancepayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtadvancepayment.Name = "txtadvancepayment";
            this.txtadvancepayment.PasswordChar = '\0';
            this.txtadvancepayment.PlaceholderText = "";
            this.txtadvancepayment.SelectedText = "";
            this.txtadvancepayment.Size = new System.Drawing.Size(508, 36);
            this.txtadvancepayment.TabIndex = 91;
            this.txtadvancepayment.TextChanged += new System.EventHandler(this.txtadvancepayment_TextChanged);
            // 
            // txtpendingpayment
            // 
            this.txtpendingpayment.BackColor = System.Drawing.Color.Transparent;
            this.txtpendingpayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(104)))), ((int)(((byte)(144)))));
            this.txtpendingpayment.BorderRadius = 10;
            this.txtpendingpayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpendingpayment.DefaultText = "";
            this.txtpendingpayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpendingpayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpendingpayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpendingpayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpendingpayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.txtpendingpayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpendingpayment.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpendingpayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpendingpayment.Location = new System.Drawing.Point(532, 446);
            this.txtpendingpayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpendingpayment.Name = "txtpendingpayment";
            this.txtpendingpayment.PasswordChar = '\0';
            this.txtpendingpayment.PlaceholderText = "";
            this.txtpendingpayment.SelectedText = "";
            this.txtpendingpayment.Size = new System.Drawing.Size(508, 36);
            this.txtpendingpayment.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.label9.Location = new System.Drawing.Point(220, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 45);
            this.label9.TabIndex = 93;
            this.label9.Text = "Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.label10.Location = new System.Drawing.Point(220, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 45);
            this.label10.TabIndex = 93;
            this.label10.Text = "Delivery Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.label11.Location = new System.Drawing.Point(220, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 45);
            this.label11.TabIndex = 93;
            this.label11.Text = "Order Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.label12.Location = new System.Drawing.Point(220, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(220, 45);
            this.label12.TabIndex = 93;
            this.label12.Text = "Full payment";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.label13.Location = new System.Drawing.Point(211, 388);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(296, 45);
            this.label13.TabIndex = 93;
            this.label13.Text = "Advance payment";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.label14.Location = new System.Drawing.Point(211, 446);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(290, 45);
            this.label14.TabIndex = 93;
            this.label14.Text = "Pending payment";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 15;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.guna2Button3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(73)))), ((int)(((byte)(98)))));
            this.guna2Button3.Location = new System.Drawing.Point(603, 536);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(118, 35);
            this.guna2Button3.TabIndex = 92;
            this.guna2Button3.Text = "ADD";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // NewOrder1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.txtpendingpayment);
            this.Controls.Add(this.txtadvancepayment);
            this.Controls.Add(this.txtfullpayment);
            this.Controls.Add(this.txtcustomerid);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdeliverydate);
            this.Controls.Add(this.txtorderdate);
            this.Controls.Add(this.txtcategory);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "NewOrder1";
            this.Size = new System.Drawing.Size(1366, 668);
            this.Load += new System.EventHandler(this.NewOrder1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox txtcategory;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtorderdate;
        private Guna.UI2.WinForms.Guna2TextBox txtcustomerid;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdeliverydate;
        private Guna.UI2.WinForms.Guna2TextBox txtfullpayment;
        private Guna.UI2.WinForms.Guna2TextBox txtadvancepayment;
        private Guna.UI2.WinForms.Guna2TextBox txtpendingpayment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}
