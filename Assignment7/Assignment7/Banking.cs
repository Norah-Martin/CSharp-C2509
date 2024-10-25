//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Principal;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;
//using static Assignment7.Banking.Customer;

//namespace Assignment7
//{
//    //    Create a Bank class with :
//    //o A list of Customer objects.
//    //o Methods to add customers and accounts, and to display customer details.
//    public class Banking
//    {
//         List<Customer> CustomerList=new List<Customer>();

//        public void AddCustomers(Customer Cu)
//        {
//            CustomerList.Add(Cu);
           
//        }
        

//        public void Display()
//        {
//            foreach (var ca in CustomerList)
//            {
//                Console.Write($"Customer name: {ca.Name}----- ");
//                ca.DisplayA();
//            }
//        }


//        //Create a nested Customer class with properties for Name and a list of accounts.
//        public class Customer
//        {
//            public string Name { get; set; }
//            List<Account> AccountList=new List<Account>();

//            public void Customername(string name)
//            {
//                Name = name;
//            }
//            public void Addaccount(Account ac)
//            {

//                AccountList.Add(ac);
//            }
//            public void DisplayA()
//            {
//                foreach (var ac in AccountList)
//                {
//                    Console.WriteLine($"Balance: {ac.Balance}---- and Account number:{ac.AccountNum} ");
//                }
//            }


//            //Create a nested Account class with properties for AccountNumber and Balance.
//            public class Account
//            {
//                public int AccountNum { get; set; }
//                public int Balance { get; set; }

//                public void Addacc(int accountnum, int balance)
//                {
//                    AccountNum = accountnum;
//                    Balance = balance;
//                }




//                static void Main(string[] args)
//                {
                    
                    
//                    Banking B = new Banking();
//                    Account A = new Account();
//                    Console.Write("Enter the number of customers: ");
//                    int num = int.Parse(Console.ReadLine());
//                    for (int i = 0; i < num; i++)
//                    {
                       
//                        Customer C = new Customer();
//                        Console.Write("Enter name: ");
//                        string name1 = Console.ReadLine();
//                        C.Customername(name1);
//                        Console.Write("Enter Account number:   ");
//                        int acc1 = int.Parse(Console.ReadLine());
//                        Console.Write("Enter  balance:   ");
//                        int bal1 = int.Parse(Console.ReadLine());
//                        A.Addacc(acc1, bal1);
//                        C.Addaccount(A);
//                        B.AddCustomers(C);
//                        Console.WriteLine("\n");


//                    }
//                    Console.WriteLine("\n");
//                    Console.WriteLine("-----------------------------");
//                    B.Display();
                   
//                    Console.ReadLine();
//                }



//            }
//        }
//    }
//}
