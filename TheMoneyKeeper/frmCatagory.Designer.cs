namespace TheMoneyKeeper
{
    partial class frmCatagory
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
            this.txtCatagory = new System.Windows.Forms.TextBox();
            this.lblcatagory = new System.Windows.Forms.Label();
            this.btnExpenseSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCatagory
            // 
            this.txtCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatagory.Location = new System.Drawing.Point(173, 14);
            this.txtCatagory.Name = "txtCatagory";
            this.txtCatagory.Size = new System.Drawing.Size(200, 22);
            this.txtCatagory.TabIndex = 3;
            // 
            // lblcatagory
            // 
            this.lblcatagory.AutoSize = true;
            this.lblcatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcatagory.Location = new System.Drawing.Point(21, 14);
            this.lblcatagory.Name = "lblcatagory";
            this.lblcatagory.Size = new System.Drawing.Size(63, 16);
            this.lblcatagory.TabIndex = 2;
            this.lblcatagory.Text = "Catagory";
            // 
            // btnExpenseSave
            // 
            this.btnExpenseSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseSave.Location = new System.Drawing.Point(129, 53);
            this.btnExpenseSave.Name = "btnExpenseSave";
            this.btnExpenseSave.Size = new System.Drawing.Size(75, 23);
            this.btnExpenseSave.TabIndex = 11;
            this.btnExpenseSave.Text = "Save";
            this.btnExpenseSave.UseVisualStyleBackColor = true;
            this.btnExpenseSave.Click += new System.EventHandler(this.btnExpenseSave_Click);
            // 
            // frmCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 262);
            this.Controls.Add(this.btnExpenseSave);
            this.Controls.Add(this.txtCatagory);
            this.Controls.Add(this.lblcatagory);
            this.Name = "frmCatagory";
            this.Text = "frmCatagory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCatagory;
        private System.Windows.Forms.Label lblcatagory;
        private System.Windows.Forms.Button btnExpenseSave;
    }
}