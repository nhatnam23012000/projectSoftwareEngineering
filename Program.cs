using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFCS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AccountDatabase accountDatabase = new AccountDatabase();
            StallDatabase stallDatabase = new StallDatabase();
            OrderDatabase orderDatabase = new OrderDatabase();
            ReportDatabase reportDatabase = new ReportDatabase();
            string[] line_1 = System.IO.File.ReadAllLines("Accountdatabase.txt");
            foreach (string line in line_1)
            {
                int count = 0;
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == ' ') count++;
                }
                if (count == 3) //Staff
                {
                    Account account = new StaffAccount();
                    String temp = "";
                    int d = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == ' ')
                        {
                            if (d == 0) account.setName(temp);
                            else if (d == 1) account.setPassword(temp);
                            else if (d == 2)
                            {
                                Authorization authorization = Authorization.COOK;
                                switch (temp)
                                {
                                    case "MANAGER":
                                        authorization = Authorization.MANAGER;
                                        break;
                                    case "COOK":
                                        authorization = Authorization.COOK;
                                        break;
                                    case "ITSTAFF":
                                        authorization = Authorization.ITSTAFF;
                                        break;
                                    case "STALLOWNER":
                                        authorization = Authorization.STALLOWNER;
                                        break;
                                    case "CUSTOMER":
                                        authorization = Authorization.CUSTOMER;
                                        break;
                                    case "MASTERITSTAFF":
                                        authorization = Authorization.MASTERITSTAFF;
                                        break;
                                }
                                account.setAuthorization(authorization);
                            }
                            d++;
                            temp = "";
                        }
                        else
                        {
                            temp += line[i];
                        }
                    }
                    accountDatabase.addStaffAccount(account.getName(), account.getPassword(), account.getAuthorization(), (int)Double.Parse(temp));
                }
                else
                {
                    Account account = new CustomerAccount();
                    String temp = "";
                    int d = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == ' ')
                        {
                            if (d == 0) account.setName(temp);
                            else account.setPassword(temp);
                            d++;
                            temp = "";
                        }
                        else
                        {
                            temp += line[i];
                        }
                    }
                    accountDatabase.addCustomerAccount(account.getName(), account.getPassword());
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(accountDatabase));
            String[] lines = new String[accountDatabase.getCount()];
            for (int i = 0; i < lines.Length; i++)
            {
                //CustomerAccount customerAccount = null;
                Account otherAccount = accountDatabase.getAccount(i);
                if (otherAccount.GetType() == typeof(CustomerAccount))
                {
                    CustomerAccount account = (CustomerAccount)otherAccount;
                    lines[i] = account.getName() + " " + account.getPassword() + " CUSTOMER";
                }
                else
                {
                    StaffAccount account = (StaffAccount)accountDatabase.getAccount(i);
                    String authorization = "";
                    switch (accountDatabase.getAccount(i).getAuthorization())
                    {
                        case Authorization.MANAGER:
                            authorization = "MANAGER";
                            break;
                        case Authorization.COOK:
                            authorization = "COOK";
                            break;
                        case Authorization.ITSTAFF:
                            authorization = "ITSTAFF";
                            break;
                        case Authorization.STALLOWNER:
                            authorization = "STALLOWNER";
                            break;
                        case Authorization.MASTERITSTAFF:
                            authorization = "MASTERITSTAFF";
                            break;
                    }
                    lines[i] = account.getName() + " " + account.getPassword() + " " + authorization + " " + account.getID();
                }
            }
            System.IO.File.WriteAllLines("Accountdatabase.txt", lines);
        }
    }
}
