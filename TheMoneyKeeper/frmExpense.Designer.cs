namespace TheMoneyKeeper
{
    partial class frmExpense
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
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDateofExpense = new System.Windows.Forms.DateTimePicker();
            this.lblAOE = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.txtAmountofExpese = new System.Windows.Forms.TextBox();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnExpenseSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAllocateLimite = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblbalance = new System.Windows.Forms.Label();
            this.lblValidation = new System.Windows.Forms.Label();
            this.txtBA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(25, 65);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(109, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date Of Expense";
            // 
            // dtpDateofExpense
            // 
            this.dtpDateofExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateofExpense.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateofExpense.Location = new System.Drawing.Point(177, 63);
            this.dtpDateofExpense.Name = "dtpDateofExpense";
            this.dtpDateofExpense.Size = new System.Drawing.Size(93, 22);
            this.dtpDateofExpense.TabIndex = 3;
            this.dtpDateofExpense.Leave += new System.EventHandler(this.dtpDateofExpense_Leave);
            // 
            // lblAOE
            // 
            this.lblAOE.AutoSize = true;
            this.lblAOE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAOE.Location = new System.Drawing.Point(25, 107);
            this.lblAOE.Name = "lblAOE";
            this.lblAOE.Size = new System.Drawing.Size(144, 16);
            this.lblAOE.TabIndex = 4;
            this.lblAOE.Text = "Amount of the Expense";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.Location = new System.Drawing.Point(25, 149);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(63, 16);
            this.lblCatagory.TabIndex = 5;
            this.lblCatagory.Text = "Catagory";
            // 
            // txtAmountofExpese
            // 
            this.txtAmountofExpese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountofExpese.Location = new System.Drawing.Point(177, 103);
            this.txtAmountofExpese.Name = "txtAmountofExpese";
            this.txtAmountofExpese.Size = new System.Drawing.Size(93, 22);
            this.txtAmountofExpese.TabIndex = 6;
            this.txtAmountofExpese.Text = "0";
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
            this.cmbCatagory.Location = new System.Drawing.Point(177, 143);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(200, 24);
            this.cmbCatagory.TabIndex = 7;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(25, 191);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(37, 16);
            this.lblNote.TabIndex = 8;
            this.lblNote.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(177, 185);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(200, 84);
            this.txtNote.TabIndex = 9;
            // 
            // btnExpenseSave
            // 
            this.btnExpenseSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseSave.Location = new System.Drawing.Point(177, 288);
            this.btnExpenseSave.Name = "btnExpenseSave";
            this.btnExpenseSave.Size = new System.Drawing.Size(75, 23);
            this.btnExpenseSave.TabIndex = 10;
            this.btnExpenseSave.Text = "Save";
            this.btnExpenseSave.UseVisualStyleBackColor = true;
            this.btnExpenseSave.Click += new System.EventHandler(this.btnExpenseSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Your Allocated Limit is : ";
            // 
            // txtAllocateLimite
            // 
            this.txtAllocateLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllocateLimite.Location = new System.Drawing.Point(177, 19);
            this.txtAllocateLimite.Name = "txtAllocateLimite";
            this.txtAllocateLimite.ReadOnly = true;
            this.txtAllocateLimite.Size = new System.Drawing.Size(93, 22);
            this.txtAllocateLimite.TabIndex = 12;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(396, 18);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(93, 22);
            this.txtBalance.TabIndex = 14;
            this.txtBalance.Text = "0";
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalance.Location = new System.Drawing.Point(286, 20);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(105, 16);
            this.lblbalance.TabIndex = 13;
            this.lblbalance.Text = "Total Expenses:";
            // 
            // lblValidation
            // 
            this.lblValidation.AutoSize = true;
            this.lblValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblValidation.Location = new System.Drawing.Point(299, 103);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(0, 16);
            this.lblValidation.TabIndex = 15;
            // 
            // txtBA
            // 
            this.txtBA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBA.Location = new System.Drawing.Point(397, 42);
            this.txtBA.Name = "txtBA";
            this.txtBA.ReadOnly = true;
            this.txtBA.Size = new System.Drawing.Size(93, 22);
            this.txtBA.TabIndex = 17;
            this.txtBA.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Balance Amount:";
            // 
            // frmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 335);
            this.Controls.Add(this.txtBA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValidation);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblbalance);
            this.Controls.Add(this.txtAllocateLimite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExpenseSave);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.cmbCatagory);
            this.Controls.Add(this.txtAmountofExpese);
            this.Controls.Add(this.lblCatagory);
            this.Controls.Add(this.lblAOE);
            this.Controls.Add(this.dtpDateofExpense);
            this.Controls.Add(this.lblDate);
            this.Name = "frmExpense";
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.frmExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDateofExpense;
        private System.Windows.Forms.Label lblAOE;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.TextBox txtAmountofExpese;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnExpenseSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAllocateLimite;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.TextBox txtBA;
        private System.Windows.Forms.Label label2;
    }
}