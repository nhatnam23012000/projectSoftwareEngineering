using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS
{
    public class ITStaff : User
    {
        public ITStaff(Account account) : base(account) { }
        public void createStaffAccount(String name, String pass, Authorization authorization, int id, AccountDatabase database)
        {
            database.addStaffAccount(name, pass, authorization, id);
        }
        public StallDatabase editStallDatabase(StallDatabase database)
        {
            return database;
        }
    }
}
