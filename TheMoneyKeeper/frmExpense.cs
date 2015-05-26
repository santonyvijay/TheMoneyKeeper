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
    public partial class frmExpense : Form
    {
        private ExpenseLINQDataContext dbExpenseContext = new ExpenseLINQDataContext();
        private int _UID;
        public frmExpense()
        {
            InitializeComponent();
        }

        public frmExpense(int UID)
        {
            InitializeComponent();
            _UID = UID;
        }

        private void frmExpense_Load(object sender, EventArgs e)
        {
            UserGlobal userG = new UserGlobal();
            decimal g =  userG.GetUserLimitAmount(_UID);
            txtAllocateLimite.Text = g.ToString();
            checkBalance();

        }

        private void btnExpenseSave_Click(object sender, EventArgs e)
        {
            if (Validation() == true)
            {
                ExpenseDetail expense = new ExpenseDetail();
                expense.UserID = _UID;
                expense.Amount = Convert.ToDecimal(txtAmountofExpese.Text);
                expense.DOE = Convert.ToDateTime(dtpDateofExpense.Text);
                expense.Catagory = cmbCatagory.SelectedItem.ToString();
                dbExpenseContext.ExpenseDetails.InsertOnSubmit(expense);
                dbExpenseContext.SubmitChanges();
                MessageBox.Show("Your Expense Data Saved Sucessfully");
                checkBalance();
                CleanText();
                
            }
        }

        private bool Validation()
        {
            lblValidation.Text = "";
            decimal aExp = Convert.ToDecimal(txtAmountofExpese.Text);
            decimal aBls = Convert.ToDecimal(txtBalance.Text);

            if (aExp == 0)
                lblValidation.Text = "Please Enter the Amount of Expense";

            if (Convert.ToDecimal(txtAllocateLimite.Text) <= (aBls +aExp))
            {
                lblValidation.Text = "Your amount is exceed";
                lblValidation.Text = exceedMsg();
                txtBalance.BackColor = Color.Red;
                return false;
            }
            if (Convert.ToDecimal(txtAllocateLimite.Text) <= Convert.ToDecimal(txtAmountofExpese.Text))
            {
                txtBalance.BackColor = Color.Red;
                lblValidation.Text = exceedMsg();
            }
            if (cmbCatagory.SelectedItem == null)
                lblValidation.Text = "Please Select Catagory";
    
            if(lblValidation.Text != "")
                return false;

            return true;
        }

        private String exceedMsg()
        {
            DialogResult dialogResult = MessageBox.Show("You have No Balance.Do you want to proceed?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                return "";
            }
            else if (dialogResult == DialogResult.No)
            {
                lblValidation.Text = "You have no balance";
            }
            return "You have no balance";
        }

        private void CleanText()
        {
            txtAmountofExpese.Text = "0";
            txtNote.Text = "";
        }

        private void checkBalance()
        {
            DateTime dt = Convert.ToDateTime(dtpDateofExpense.Text); 
            var sumBal = from t in dbExpenseContext.ExpenseDetails
                         where t.UserID == _UID &&
                         (t.DOE >= new DateTime(dt.Year, dt.Month, 1) && t.DOE <= Convert.ToDateTime(dtpDateofExpense.Text))
                         group t by t.UserID into sa
                         select new { totalAmount = sa.Sum(a=>a.Amount)};
            foreach (var sa in sumBal)
            {
                txtBalance.Text = sa.totalAmount.ToString();
                
            }
            decimal BA = Convert.ToDecimal(txtAllocateLimite.Text) - Convert.ToDecimal(txtBalance.Text);
            txtBA.Text = Convert.ToString(BA);
        }

        private void dtpDateofExpense_Leave(object sender, EventArgs e)
        {
            checkBalance();
        }
        
    }
}
