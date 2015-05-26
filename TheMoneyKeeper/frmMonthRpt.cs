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
    public partial class frmMonthRpt : Form
    {
        private ExpenseLINQDataContext dbExpenseContext = new ExpenseLINQDataContext();
        private int _UID;
        private decimal Amt;
        private string monthString;
        UserGlobal userG = new UserGlobal();

        public frmMonthRpt()
        {
            InitializeComponent();
        }
        public frmMonthRpt(int UID)
        {
            InitializeComponent();
            _UID = UID;
        }

        private void btnShowCatRpt_Click(object sender, EventArgs e)
        {
            GetCatData();
        }


        private void GetCatData()
        {
            Amt = 0;
            DateTime dt = Convert.ToDateTime(dtpDateofExpense.Text); 
                var catRpt = from t in dbExpenseContext.ExpenseDetails
                             where t.UserID == _UID &&
                             (t.DOE >= new DateTime(dt.Year, dt.Month, 1) && t.DOE <= Convert.ToDateTime(dtpDateofExpense.Text))
                             group t by new { t.UserID } into sa
                             select new { totalAmount = sa.Sum(a => a.Amount) };
                monthString = "Monthly Expence Report";
                monthString += "\r\n-----------------------";
                decimal g = userG.GetUserLimitAmount(_UID);
                monthString += "\r\n Allocated Amount for this month: " + g.ToString();
                foreach (var sa in catRpt)
                {
                    Amt += Convert.ToDecimal(sa.totalAmount);
                }
                monthString += "\r\nTotal Amount you spent: " + Amt;
                monthString += "\r\nBalance : " + (g - Amt);

                txtRpt.Text = monthString;
            
        }

    }
}
