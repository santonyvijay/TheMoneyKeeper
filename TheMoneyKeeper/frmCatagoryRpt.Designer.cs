namespace TheMoneyKeeper
{
    partial class frmCatagoryRpt
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
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.txtRpt = new System.Windows.Forms.TextBox();
            this.btnShowCatRpt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.Items.AddRange(new object[] {
            "Utility",
            "Rent",
            "Car",
            "Gas",
            "Internet",
            "Mobile",
            "Insurance",
            "Other Expense"});
            this.cmbCatagory.Location = new System.Drawing.Point(91, 9);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(200, 24);
            this.cmbCatagory.TabIndex = 8;
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.Location = new System.Drawing.Point(12, 12);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(63, 16);
            this.lblCatagory.TabIndex = 9;
            this.lblCatagory.Text = "Category";
            // 
            // txtRpt
            // 
            this.txtRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRpt.Location = new System.Drawing.Point(24, 38);
            this.txtRpt.Multiline = true;
            this.txtRpt.Name = "txtRpt";
            this.txtRpt.Size = new System.Drawing.Size(348, 185);
            this.txtRpt.TabIndex = 10;
            // 
            // btnShowCatRpt
            // 
            this.btnShowCatRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCatRpt.Location = new System.Drawing.Point(297, 9);
            this.btnShowCatRpt.Name = "btnShowCatRpt";
            this.btnShowCatRpt.Size = new System.Drawing.Size(75, 23);
            this.btnShowCatRpt.TabIndex = 11;
            this.btnShowCatRpt.Text = "Show";
            this.btnShowCatRpt.UseVisualStyleBackColor = true;
            this.btnShowCatRpt.Click += new System.EventHandler(this.btnShowCatRpt_Click);
            // 
            // frmCatagoryRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 289);
            this.Controls.Add(this.btnShowCatRpt);
            this.Controls.Add(this.txtRpt);
            this.Controls.Add(this.lblCatagory);
            this.Controls.Add(this.cmbCatagory);
            this.Name = "frmCatagoryRpt";
            this.Text = "Report Per Catagory";
            this.Load += new System.EventHandler(this.frmCatagoryRpt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.TextBox txtRpt;
        private System.Windows.Forms.Button btnShowCatRpt;
    }
}