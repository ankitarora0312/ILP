using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int choice;
                IMethod met = new Method();
                do
                {
                    Console.WriteLine("Bank Details");
                    Console.WriteLine("1.Add new Customer");
                    Console.WriteLine("2.Add new Account");
                    Console.WriteLine("3.View all customer's account by account_type");
                    Console.WriteLine("4.Deposit Amount");
                    Console.WriteLine("5.Deactivate Account");
                    Console.WriteLine("Enter your choice");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter the date of birth");
                            DateTime dob = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Enter the gender");
                            string gen = Console.ReadLine();
                            Console.WriteLine("Enter the city");
                            string city = Console.ReadLine();
                            Console.WriteLine("Enter the mobile number");
                            long mob = Convert.ToInt64(Console.ReadLine());
                            ICustomer cus = new Customer(name, dob, gen, city, mob);
                            int cusId=met.AddCustomer(cus);
                            Console.WriteLine(cusId);
                            break;
                        case 2:
                            Console.WriteLine("Enter the Customer Id");
                            int custId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Account Type as Savings or Current");
                            string acc_type = Console.ReadLine();
                            Console.WriteLine("Enter the deposit amount with a minimum of 500");
                            int dep_amt = Convert.ToInt32(Console.ReadLine());
                            if((acc_type=="Savings"|acc_type=="Current")&&dep_amt>=500)
                            {
                                IAccount acc = new Account(acc_type, dep_amt, custId);
                                int accId1 = met.AddAccount(acc);
                                Console.WriteLine("Account Id is "+accId1);
                            }
                            else
                            {
                                Console.WriteLine("Enter proper details");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter the account type");
                            acc_type = Console.ReadLine();
                            List<IAccount> acc1 = met.ViewAccount();
                            
                                foreach (IAccount ac1 in acc1)
                                {
                                    if (ac1.Acc_type == acc_type)
                                    {
                                        Console.WriteLine("Account Id is " + ac1.AccId);
                                        Console.WriteLine("Deposit Amount is " + ac1.Dep_amt);
                                        Console.WriteLine("Account start date is " + ac1.Acc_start_date);
                                        Console.WriteLine("Account status is Active");
                                        break;
                                    }
                                else
                                {
                                    Console.WriteLine("Enter the proper details");
                                    break;
                                }
                            }
                            
                      
                            break;
                        case 4:
                            Console.WriteLine("Enter the customer Id");
                            int cuId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the account Id");
                            int accId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the account type");
                            string acc_type1 = Console.ReadLine();
                            Console.WriteLine("Enter the amount to be deposited");
                            int dep_am = Convert.ToInt32(Console.ReadLine());
                            met.Deposit_Amount(cuId,accId,acc_type1,dep_am);
                            List<IAccount> acc2 = met.ViewAccount();

                            foreach (IAccount acc in acc2)
                            {
                                if (acc.CustId == cuId && acc.AccId == accId && acc.Acc_type == acc_type1)
                                {
                                    acc.Dep_amt += dep_am;

                                    Console.WriteLine("The latest balance is " + acc.Dep_amt);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter proper details");
                                    break;
                                }
                            }
                                    break;
                        case 5:
                            Console.WriteLine("Enter the customer Id");
                            int cId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the account Id");
                            int acc_Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the account type");
                            string ac_type = Console.ReadLine();
                            met.Deactivate_Account(cId, acc_Id, ac_type);
                            List<IAccount> acc3 = met.ViewAccount();
                            foreach (IAccount acc in acc3)
                            {
                                if (acc.CustId == cId && acc.AccId == acc_Id && acc.Acc_type == ac_type)
                                {
                                    acc.Dep_amt = 0;
                                    acc.Acc_status = "Inactive";
                                    acc3.Remove(acc);
                                    Console.WriteLine("The account is deactivated");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Plese enter proper details");
                                    break;
                                }
                            }
                                break;
                        default:
                            break;



                    }
                } while (choice <= 5);
                Console.ReadLine();
                

            }catch(Exception ex)
            {
                Console.WriteLine("The error is " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
