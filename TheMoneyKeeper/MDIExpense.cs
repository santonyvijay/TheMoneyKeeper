using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMoneyKeeper
{
    public partial class MDIExpense : Form
    {
        public int _UID;
        public MDIExpense()
        {
            InitializeComponent();
        }
        public MDIExpense(int UserID, string Name)
        {
            InitializeComponent();
            _UID = UserID;
            lblLoginUserName.Text = Name;
        }

        private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpense expense = new frmExpense(_UID);
            expense.MdiParent = this;
            expense.Show();
        }

        private void MDIExpense_Load(object sender, EventArgs e)
        {

        }

        private void catagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatagory cat = new frmCatagory();
            cat.MdiParent = this;
            cat.Show();
        }

        private void MDIExpense_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainLogin.Close();
        }

        private void reportsPerMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonthRpt MonthRpt = new frmMonthRpt(_UID);
            MonthRpt.MdiParent = this;
            MonthRpt.Show();
        }

        private void reportsPerCatagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatagoryRpt catRpt = new frmCatagoryRpt(_UID);
            catRpt.MdiParent = this;
            catRpt.Show();
        }

        private void userAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUserAccount catRpt = new frmUserAccount(_UID);
            catRpt.MdiParent = this;
            catRpt.Show();    
        }
    }
}
