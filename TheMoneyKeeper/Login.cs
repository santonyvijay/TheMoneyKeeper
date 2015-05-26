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
    public partial class Login : Form
    {
        private ExpenseLINQDataContext dbExpenseContext = new ExpenseLINQDataContext();
        frmUserAccount userAccount = new frmUserAccount();
        
        public int _UID;
        public double  _Limite;

        public Login()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            userAccount.Show();
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Validation()==true)
            {
                UserGlobal userG = new UserGlobal(_UID, txtUserName.Text, _Limite);
                MDIExpense mdiExpense = new MDIExpense(_UID,txtUserName.Text);
                mdiExpense.Show();
                this.Hide();
            }
        }
        private bool Validation()
        {
            lblValidation.Text = "";
            if (txtUserName.Text == "")
                lblValidation.Text += "Login Name: Please Enter User LoginName\n";
            if (txtPwd.Text == "")
                lblValidation.Text += "Password: Please Enter User Password\n";
            if (lblValidation.Text != "")
                return false;

            User chkLoginPwd = (from tbluser in dbExpenseContext.Users where tbluser.LoginName == txtUserName.Text
                               select tbluser).FirstOrDefault();
            if (chkLoginPwd == null)
            {
                lblValidation.Text += "Please Enter Correct LoginName and Password\n";
                return false;
            }
            else if (chkLoginPwd.LoginName != txtUserName.Text)
            {
                lblValidation.Text += "Please Enter Correct LoginName\n";
                return false;
            }
            else if (chkLoginPwd.Password != txtPwd.Text)
            {
                lblValidation.Text += "Please Enter Correct Password\n";
                return false;
            }

            _UID = chkLoginPwd.UserId;
            _Limite = Convert.ToDouble(chkLoginPwd.Limit);
            return true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
