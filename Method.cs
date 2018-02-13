using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Method:IMethod
    {
        List<IAccount> lia = new List<IAccount>();
        List<ICustomer> lic = new List<ICustomer>();


        public int AddCustomer(ICustomer cus)
        {
            lic.Add(cus);
            return cus.CustId;
        }
       public int AddAccount(IAccount acc)
        {
            lia.Add(acc);
            return acc.AccId;
        }
        public List<IAccount> ViewByAccountType(string acctype)
        {
            foreach(IAccount acc in lia)
            {
                if (acc.Acc_type == acctype)
                {
                    
                    break;

                }
            }
            return lia;
        }
        public List<IAccount> ViewAccount()
        {
            return lia;
        }
        public void Deposit_Amount(int custId,int accId,string acc_type,int dep_amt)
        {
            foreach(IAccount acc in lia)
            {
                if(acc.CustId==custId&& acc.AccId==accId&&acc.Acc_type==acc_type)
                {
                    acc.Dep_amt += dep_amt;
                
                    Console.WriteLine("The latest balance is " + acc.Dep_amt);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter proper details");
                    break;
                }
            }
        }
        public void Deactivate_Account(int custId, int accId, string acc_type)
        {
            foreach (IAccount acc in lia)
            {
                if (acc.CustId == custId && acc.AccId == accId && acc.Acc_type == acc_type)
                {
                    acc.Dep_amt = 0;
                    acc.Acc_status = "Inactive";
                    lia.Remove(acc);
                    Console.WriteLine("The account is deactivated");
                    break;
                }
                else
                {
                    Console.WriteLine("Plese enter proper details");
                    break;
                }

            }

        }
    }
}
