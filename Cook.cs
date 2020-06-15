using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS
{
    public class Cook : User
    {
        public Cook(Account account) : base(account) { }
        public Order viewOrder(int id, OrderDatabase database)
        {
            return database.getOrder(id);
        }
        public void setOrderState(int id, State state, OrderDatabase database)
        {
            database.getOrder(id).setState(state);
        }
        public String notification(int id, OrderDatabase database)
        {
            if (database.getOrder(id).getState() == State.READY)
            {
               return "Your order is ready!";
            }
            return "Your order is still in process";
        }
    }    
}
