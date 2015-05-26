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
    public partial class frmCatagoryRpt : Form
    {
        private ExpenseLINQDataContext dbExpenseContext = new ExpenseLINQDataContext();
        private int _UID;
        private decimal catAmt;
        private string catString;
        public frmCatagoryRpt()
        {
            InitializeComponent();
        }
        public frmCatagoryRpt(int UID)
        {
            InitializeComponent();
            _UID = UID;
        }


        private void GetCatData()
        {
            catAmt = 0;
            DateTime dt = DateTime.Now;
            if (cmbCatagory.SelectedItem==null)
            {
                var catRpt = from t in dbExpenseContext.ExpenseDetails
                             where t.UserID == _UID &&
                             (t.DOE >= new DateTime(dt.Year, dt.Month, 1) && t.DOE <= DateTime.Now)
                             group t by new { t.UserID, t.Catagory } into sa
                             select new { sa.Key.Catagory, totalAmount = sa.Sum(a => a.Amount) };
                catString = "Category        Amount";
                catString += "\r\n---------------------------";
                foreach (var sa in catRpt)
                {
                    catString += "\r\n"+sa.Catagory + "             ";
                    catString += Convert.ToString(sa.totalAmount);
                    catAmt += Convert.ToDecimal(sa.totalAmount);
                }
                catString += "\r\n---------------------------";
                catString += "\r\nTotal         "+catAmt;
                txtRpt.Text = catString;
                
            }
            else
            {
                var catRpt = from t in dbExpenseContext.ExpenseDetails
                             where t.UserID == _UID && t.Catagory == cmbCatagory.SelectedItem
                             && (t.DOE >= new DateTime(dt.Year, dt.Month, 1) && t.DOE <= DateTime.Now)
                             group t by new { t.UserID, t.Catagory } into sa
                             select new { sa.Key.Catagory, totalAmount = sa.Sum(a => a.Amount) };
                catString = "Category        Amount";
                catString += "\r\n---------------------------";
                foreach (var sa in catRpt)
                {
                    catString += "\r\n" + sa.Catagory + "             ";
                    catString += Convert.ToString(sa.totalAmount);
                    catAmt += Convert.ToDecimal(sa.totalAmount);
                }
                catString += "\r\n---------------------------";
                catString += "\r\nTotal         " + catAmt;
                txtRpt.Text = catString;
            }
                        
        }

        private void frmCatagoryRpt_Load(object sender, EventArgs e)
        {
            GetCatData();
        }

        private void btnShowCatRpt_Click(object sender, EventArgs e)
        {
            GetCatData();
        }

    }
}
