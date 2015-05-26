namespace TheMoneyKeeper
{
    partial class MDIExpense
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.expenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsPerMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsPerCatagoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.catagoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLoginUserName = new System.Windows.Forms.Label();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expenseToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // expenseToolStripMenuItem
            // 
            this.expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            this.expenseToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.expenseToolStripMenuItem.Text = "Expense";
            this.expenseToolStripMenuItem.Click += new System.EventHandler(this.expenseToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.catagoryToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsPerMonthToolStripMenuItem,
            this.reportsPerCatagoryToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // reportsPerMonthToolStripMenuItem
            // 
            this.reportsPerMonthToolStripMenuItem.Name = "reportsPerMonthToolStripMenuItem";
            this.reportsPerMonthToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.reportsPerMonthToolStripMenuItem.Text = "Reports Per Month";
            this.reportsPerMonthToolStripMenuItem.Click += new System.EventHandler(this.reportsPerMonthToolStripMenuItem_Click);
            // 
            // reportsPerCatagoryToolStripMenuItem
            // 
            this.reportsPerCatagoryToolStripMenuItem.Name = "reportsPerCatagoryToolStripMenuItem";
            this.reportsPerCatagoryToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.reportsPerCatagoryToolStripMenuItem.Text = "Reports Per Catagory";
            this.reportsPerCatagoryToolStripMenuItem.Click += new System.EventHandler(this.reportsPerCatagoryToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAccountToolStripMenuItem1,
            this.catagoryToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.SettingsToolStripMenuItem.Text = "Settings";
            // 
            // userAccountToolStripMenuItem1
            // 
            this.userAccountToolStripMenuItem1.Name = "userAccountToolStripMenuItem1";
            this.userAccountToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.userAccountToolStripMenuItem1.Text = "UserAccount";
            this.userAccountToolStripMenuItem1.Click += new System.EventHandler(this.userAccountToolStripMenuItem1_Click);
            // 
            // catagoryToolStripMenuItem
            // 
            this.catagoryToolStripMenuItem.Name = "catagoryToolStripMenuItem";
            this.catagoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.catagoryToolStripMenuItem.Text = "Catagory";
            this.catagoryToolStripMenuItem.Click += new System.EventHandler(this.catagoryToolStripMenuItem_Click);
            // 
            // lblLoginUserName
            // 
            this.lblLoginUserName.AutoSize = true;
            this.lblLoginUserName.Location = new System.Drawing.Point(435, 5);
            this.lblLoginUserName.Name = "lblLoginUserName";
            this.lblLoginUserName.Size = new System.Drawing.Size(0, 13);
            this.lblLoginUserName.TabIndex = 2;
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // MDIExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 403);
            this.Controls.Add(this.lblLoginUserName);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Money Keeper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIExpense_FormClosed);
            this.Load += new System.EventHandler(this.MDIExpense_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem expenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsPerMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsPerCatagoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.Label lblLoginUserName;
        private System.Windows.Forms.ToolStripMenuItem userAccountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem catagoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
    }
}