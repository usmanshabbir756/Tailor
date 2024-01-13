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
            this.button1 = new System.Windows.Forms.Button();
            this.txtcategory = new System.Windows.Forms.ComboBox();
            this.txtdeliverydate = new System.Windows.Forms.DateTimePicker();
            this.txtorderdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfullpayment = new System.Windows.Forms.TextBox();
            this.txtadvancepayment = new System.Windows.Forms.TextBox();
            this.txtpendingpayment = new System.Windows.Forms.TextBox();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcategory
            // 
            this.txtcategory.FormattingEnabled = true;
            this.txtcategory.Items.AddRange(new object[] {
            "Pant Coat",
            "Coat",
            "Pant",
            "Shalwar Kameez",
            "Waistcoat",
            "kurta",
            "pajama"});
            this.txtcategory.Location = new System.Drawing.Point(261, 68);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(200, 21);
            this.txtcategory.TabIndex = 25;
            this.txtcategory.Text = "Category";
            // 
            // txtdeliverydate
            // 
            this.txtdeliverydate.Location = new System.Drawing.Point(261, 156);
            this.txtdeliverydate.Name = "txtdeliverydate";
            this.txtdeliverydate.Size = new System.Drawing.Size(200, 20);
            this.txtdeliverydate.TabIndex = 23;
            // 
            // txtorderdate
            // 
            this.txtorderdate.Location = new System.Drawing.Point(261, 116);
            this.txtorderdate.Name = "txtorderdate";
            this.txtorderdate.Size = new System.Drawing.Size(200, 20);
            this.txtorderdate.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Delivery Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Order Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Full payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Advance payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Pending payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Customer ID";
            // 
            // txtfullpayment
            // 
            this.txtfullpayment.Location = new System.Drawing.Point(261, 199);
            this.txtfullpayment.Name = "txtfullpayment";
            this.txtfullpayment.Size = new System.Drawing.Size(200, 20);
            this.txtfullpayment.TabIndex = 12;
            this.txtfullpayment.TextChanged += new System.EventHandler(this.txtfullpayment_TextChanged);
            // 
            // txtadvancepayment
            // 
            this.txtadvancepayment.Location = new System.Drawing.Point(261, 246);
            this.txtadvancepayment.Name = "txtadvancepayment";
            this.txtadvancepayment.Size = new System.Drawing.Size(200, 20);
            this.txtadvancepayment.TabIndex = 13;
            this.txtadvancepayment.TextChanged += new System.EventHandler(this.txtadvancepayment_TextChanged);
            // 
            // txtpendingpayment
            // 
            this.txtpendingpayment.Location = new System.Drawing.Point(261, 285);
            this.txtpendingpayment.Name = "txtpendingpayment";
            this.txtpendingpayment.Size = new System.Drawing.Size(200, 20);
            this.txtpendingpayment.TabIndex = 14;
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Location = new System.Drawing.Point(261, 28);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(100, 20);
            this.txtcustomerid.TabIndex = 15;
            // 
            // NewOrder1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.txtdeliverydate);
            this.Controls.Add(this.txtorderdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfullpayment);
            this.Controls.Add(this.txtadvancepayment);
            this.Controls.Add(this.txtpendingpayment);
            this.Controls.Add(this.txtcustomerid);
            this.Name = "NewOrder1";
            this.Size = new System.Drawing.Size(612, 351);
            this.Load += new System.EventHandler(this.NewOrder1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtcategory;
        private System.Windows.Forms.DateTimePicker txtdeliverydate;
        private System.Windows.Forms.DateTimePicker txtorderdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfullpayment;
        private System.Windows.Forms.TextBox txtadvancepayment;
        private System.Windows.Forms.TextBox txtpendingpayment;
        private System.Windows.Forms.TextBox txtcustomerid;
    }
}
