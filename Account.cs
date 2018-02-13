using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Account:IAccount
    {
     
        int accId;
        int custId;
        static int b = 999;
        string acc_type;
        int dep_amt;
        DateTime acc_start_date = DateTime.Now;
        string acc_status = "Active";
        public Account()
        { }
        public Account(string acc_type,int dep_amt,int custId )
        {
         
                    this.custId = custId;
                    this.acc_type = acc_type;
                    this.dep_amt = dep_amt;
                    gen_Id1();
 
        }
        public void gen_Id1()
        {
            b++;
            accId = b;
            
        }

        public int AccId
        {
            get
            {
                return accId;
            }

            set
            {
                accId = value;
            }
        }

        public string Acc_type
        {
            get
            {
                return acc_type;
            }

            set
            {
                acc_type = value;
            }
        }

        public int Dep_amt
        {
            get
            {
                return dep_amt;
            }

            set
            {
                dep_amt = value;
            }
        }

        public DateTime Acc_start_date
        {
            get
            {
                return acc_start_date;
            }

            set
            {
                acc_start_date = value;
            }
        }

        public int CustId
        {
            get
            {
                return custId;
            }

            set
            {
                custId = value;
            }
        }

        public string Acc_status
        {
            get
            {
                return acc_status;
            }

            set
            {
                acc_status = value;
            }
        }
    }
}
