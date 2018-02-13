using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Customer:ICustomer
    {
        int custId;
        static int a=4999;
        string name;
        DateTime dob;
        string gender;
        string city;
        long mob;
        public Customer(string name,DateTime dob,string gender,string city,long mob)
        {
            this.name = name;
            this.dob = dob;
            this.gender = gender;
            this.city = city;
            this.mob = mob;
            gen_Id();
            
        }
        public void gen_Id()
            {
            a++;
            custId = a;

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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public long Mob
        {
            get
            {
                return mob;
            }

            set
            {
                mob = value;
            }
        }
    }
}
