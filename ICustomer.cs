using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface ICustomer
    {
        int CustId { get; set; }
        string Name { get; set; }
        DateTime Dob { get; set; }
        string Gender { get; set; }
        string City { get; set; }
        long Mob { get; set; }
        void gen_Id();
    }
}
