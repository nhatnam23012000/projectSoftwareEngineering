using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS
{
    public abstract class User
    {
        protected Account account;
        public User(Account account)
        {
            this.account = account;
        }
        public Account getAccount()
        {
            return account;
        }
    }
}
