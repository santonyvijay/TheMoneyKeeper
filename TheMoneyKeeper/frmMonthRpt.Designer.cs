namespace TheMoneyKeeper
{
    partial class frmMonthRpt
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
            this.dtpDateofExpense = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtRpt = new System.Windows.Forms.TextBox();
            this.btnShowCatRpt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDateofExpense
            // 
            this.dtpDateofExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateofExpense.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateofExpense.Location = new System.Drawing.Point(128, 13);
            this.dtpDateofExpense.Name = "dtpDateofExpense";
            this.dtpDateofExpense.Size = new System.Drawing.Size(93, 22);
            this.dtpDateofExpense.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(14, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(109, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date Of Expense";
            // 
            // txtRpt
            // 
            this.txtRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRpt.Location = new System.Drawing.Point(12, 41);
            this.txtRpt.Multiline = true;
            this.txtRpt.Name = "txtRpt";
            this.txtRpt.Size = new System.Drawing.Size(353, 196);
            this.txtRpt.TabIndex = 11;
            // 
            // btnShowCatRpt
            // 
            this.btnShowCatRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCatRpt.Location = new System.Drawing.Point(246, 12);
            this.btnShowCatRpt.Name = "btnShowCatRpt";
            this.btnShowCatRpt.Size = new System.Drawing.Size(75, 23);
            this.btnShowCatRpt.TabIndex = 12;
            this.btnShowCatRpt.Text = "Show";
            this.btnShowCatRpt.UseVisualStyleBackColor = true;
            this.btnShowCatRpt.Click += new System.EventHandler(this.btnShowCatRpt_Click);
            // 
            // frmMonthRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 329);
            this.Controls.Add(this.btnShowCatRpt);
            this.Controls.Add(this.txtRpt);
            this.Controls.Add(this.dtpDateofExpense);
            this.Controls.Add(this.lblDate);
            this.Name = "frmMonthRpt";
            this.Text = "Report Per Month";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateofExpense;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtRpt;
        private System.Windows.Forms.Button btnShowCatRpt;

    }
}