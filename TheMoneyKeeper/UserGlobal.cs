using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoneyKeeper
{
    class UserGlobal
    {
        private ExpenseLINQDataContext dbExpenseContext = new ExpenseLINQDataContext();

        public int _UID;
        public string _Name;
        public double _Limite;
        
        public UserGlobal()
        {

        }

        public UserGlobal(int uid, string name, double limite)
        {
            UID = uid;
            Name = name;
            Limite = limite;
        }

        public int UID
        {
            get { return _UID; }
            set { _UID = value; }
        }

        public string Name
        {
            get { return _Name;}
            set { _Name = value; }
        }

        public double Limite
        {
            get { return _Limite;}
            set { _Limite = value; }
        }

        public object GetUserData(int UID)
        {
            User getUserData = (from userData in dbExpenseContext.Users
                                where userData.UserId == UID
                                select userData).First();

            return getUserData;
        }

        public decimal GetUserLimitAmount(int UID)
        {
            User getUserData = (from userData in dbExpenseContext.Users
                                where userData.UserId == UID
                                select userData).First();

            return Convert.ToDecimal(getUserData.Limit);
        }


    }
}
