using Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Account
    {
        private DemoDbContext db = null;

        public Account()
        {
            db = new DemoDbContext();
        }

        public bool Login(string userName, string passWord)
        {
            var res = db.user.Count(x => x.userName == userName && x.passWord == passWord);
            if(res>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
