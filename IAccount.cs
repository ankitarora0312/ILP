using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IAccount
    {
        int AccId { get; set; }
        string Acc_type { get; set; }
        int Dep_amt { get; set; }
        DateTime Acc_start_date { get; set; }
        int CustId { get; set; }
        string Acc_status { get; set; }
        void gen_Id1();
    }
}
