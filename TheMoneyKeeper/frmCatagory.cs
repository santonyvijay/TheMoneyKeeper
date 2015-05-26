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
    public partial class frmCatagory : Form
    {
        private ExpenseLINQDataContext dbExpenseContext = new ExpenseLINQDataContext();
        public frmCatagory()
        {
            InitializeComponent();
        }

        private bool ValidateCatagory()
        {
            //Catagory cat = (from tblcatagory in dbExpenseContext.Catagories 
                           // select tblcatagory).FirstOrDefault();

            if (txtCatagory.Text == "")
                return false;

            return true;
        }

        private void btnExpenseSave_Click(object sender, EventArgs e)
        {
            if (ValidateCatagory())
            {
                Catagory cat = new Catagory();
                cat.Name = txtCatagory.Text;
                dbExpenseContext.Catagories.InsertOnSubmit(cat);
                dbExpenseContext.SubmitChanges();
                
                txtCatagory.Text = "";
            }
            
        }


    }
}
