//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http.Headers;
//using System.Runtime.InteropServices;
//using System.Security.Principal;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace Assignment7
//{
//    internal class Bank
//    {
//        //2 class account and transaction
//        //      Create a simple banking system that allows account creation and basic
//        //      transactions.Each account has an account number, account holder name, and balance. Implement
//        //      deposit and withdrawal methods.Use getters and setters to manage access to the balance,
//        //ensuring it cannot be set to a negative value.


//        public class Account
//        {
//            public int Accnum { get; set; }
//            public string Accname { get; set; }

//            private int balance;
//            public int Balance
//            {
//                get { return balance; }
//                set
//                {
//                    if (value < 100)
//                    {
//                        throw new ArgumentException("*******No minimum Balance********");
//                    }
//                    balance = value;

//                }
//            }
//            //for deposit
//            public int deposit(int depo)
//            {
//                Balance = Balance + depo;
//                return Balance;
//            }
//            //for withdraw
//            public int withdraw(int money)
//            {
//                Balance = Balance - money;
//                return Balance;
//            }
//            //to enter values
//            public Account(int accnum, string accname, int balance)
//            {
//                this.Accnum = accnum;
//                this.Balance = balance;
//                this.Accname = accname;
//            }
//            public void viewdetails()
//            {
//                Console.WriteLine("*****************************************");
//                Console.WriteLine($"Name: {Accname} \n Account: {Accnum}\n Balance: {Balance} ");
//            }

//        }

//        //main program
//        static void Main(string[] args)
//        {
//            try
//            {
//                Account acc1 = new Account(01, "Norah", 120000);
//                acc1.viewdetails();
//                acc1.withdraw(5000);
//                acc1.viewdetails();

//                Account acc2 = new Account(02, "Martin", 0);
//                acc2.viewdetails();
//                //acc2.deposit(200000);
//                //acc2.viewdetails();
//            }
//            catch (ArgumentException ex)
//            {
//                Console.WriteLine(ex.Message);

//            }


//            Console.ReadLine();
//        }
//    }
//}
