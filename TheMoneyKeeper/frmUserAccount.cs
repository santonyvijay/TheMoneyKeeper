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
    public partial class frmUserAccount : Form
    {
        private ExpenseLINQDataContext dbExpenseContext = new ExpenseLINQDataContext();
        private int _UID;

        public frmUserAccount()
        {
            InitializeComponent();
        }

        public frmUserAccount(int UID)
        {
            InitializeComponent();
            _UID = UID;

            var user = (from usd in dbExpenseContext.Users
                            where usd.UserId == _UID
                            select usd).FirstOrDefault();
            txtFName.Text = user.Name;
            txtLoginUserName.Text = user.LoginName;
            txtPwd.Text = user.Password;
            txtEmail.Text = user.Email;
            txtIncomePerMonth.Text = Convert.ToString(user.IncomePerMonth);
            txtLimit.Text = Convert.ToString(user.Limit);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation()==true)
            {
                User users = new User();

                if (_UID == 0)
                {
                    dbExpenseContext.Users.InsertOnSubmit(users);
                }
                else
                {
                    users = (from u in dbExpenseContext.Users
                                where u.UserId == _UID
                                select u).FirstOrDefault();
                }

                users.LoginName = txtLoginUserName.Text;
                users.Name = txtFName.Text;
                users.Password = txtPwd.Text;
                users.DOB = Convert.ToDateTime(dtpDOB.Text);
                users.Email = txtEmail.Text;
                users.IncomePerMonth = Convert.ToDouble(txtIncomePerMonth.Text);
                users.Limit = Convert.ToDouble(txtLimit.Text);

                
                dbExpenseContext.SubmitChanges();

                MessageBox.Show("Your LoginName is " + txtLoginUserName.Text + ".\n Password is "+ txtPwd.Text+".");
                CleanText();
                this.Close();
            }
            
        }

        private bool Validation()
        {
            lblValidation.Text = "";
            if (txtLoginUserName.Text == "")
                lblValidation.Text = "Login Name: Please Enter User LoginName\n";
            if (txtFName.Text == "")
                lblValidation.Text += "Name: Please Enter User Name\n";
            if (txtPwd.Text == "")
                lblValidation.Text += "Password: Please Enter Password\n";
            if (txtLimit.Text == "0")
                lblValidation.Text += "Limit: Please Enter The Limite\n";

            if (lblValidation.Text !="")
                return false;
            
            return true;
        }

        private void CleanText()
        {
            txtLoginUserName.Text = "";
            txtFName.Text = "";
            txtEmail.Text = "";
            txtLimit.Text = "0";
            txtIncomePerMonth.Text = "0";
            txtPwd.Text = "";
        }

       
    }
}
