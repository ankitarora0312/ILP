using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IMethod
    {
        int AddCustomer(ICustomer cus);
        int AddAccount(IAccount acc);
        List<IAccount> ViewByAccountType(string acctype);
        void Deposit_Amount(int custId, int accId, string acc_type, int dep_amt);
        void Deactivate_Account(int custId, int accId, string acc_type);
        List<IAccount> ViewAccount();


    }
}
