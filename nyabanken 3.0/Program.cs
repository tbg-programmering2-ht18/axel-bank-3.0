using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyabanken_3._0
{
    class Program
    {
        public static List<Customer> customerlist = new List<Customer>();


        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 7)
            {
                Console.WriteLine("Welcome to AXEL'S  Big Bank!");

                Console.WriteLine("");
                Console.WriteLine("Pick your choises!");
                Console.WriteLine("");
                Console.WriteLine("1 : Add new customer");
                Console.WriteLine("2 : Show all customer");
                Console.WriteLine("3 : Remove a user from bank");
                Console.WriteLine("4 : Check balance");
                Console.WriteLine("5 : Make a deposit");
                Console.WriteLine("6 : Make a withdrawal");
                Console.WriteLine("7 : Shutdown");
                Console.WriteLine("");
                Console.Write("What would you like to do? ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("whopsssssss.....");
                    Console.ReadLine();
                }

                switch (choice)
                {
                    
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Add customer");
                        addCustomer();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        foreach (var Customer in customerlist)
                        {
                            Console.WriteLine("User: {0}", Customer.name);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        foreach (Customer info in customerlist)
                        {
                            Console.WriteLine(info.customerInfo());
                        }
                        removeCustomer();
                        break;

                    case 5:
                        // this code is not 100% done but work kinda.
                     Console.Clear();
                     Console.WriteLine("");
                     Console.WriteLine("Write the full name of the customer you'd like to make a deposit!");
                      // here you put in money in the bank, but doesnt work right now
                     int customerBalanceAdd = int.Parse(Console.ReadLine());
                     Customer balanceToAdd = customerlist[customerBalanceAdd - 1];
                     Console.WriteLine("How much money does you want put in the bank");

                            customerBalanceAdd = int.Parse(Console.ReadLine());
                        balanceToAdd.balance += customerBalanceAdd;
                            
                        Console.Clear();
                        break;

                    case 4:
               
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("What customer?");
                        int customerwho = int.Parse(Console.ReadLine());
                        Console.WriteLine(customerlist[customerwho -1].balance);
                        Console.ReadLine();

                        Console.Clear();
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Ooops... still under construction");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Thank you for visiting my bank! Please return soon!");
            Console.WriteLine("Click any button to turn off program!");
            Console.ReadKey();
        }

        public static void addCustomer()
        {
            Console.WriteLine("");
            Console.Write("Name of customer: ");
            string name = Console.ReadLine();
            Customer customer = new Customer();
            customer.name = name;
            customerlist.Add(customer);
        }
        public static Customer GetCustomer()
        {
            // function that shows all customer
            Console.WriteLine("");
            Console.WriteLine("Write the full name of the customer: ");
            string customer = Console.ReadLine();
            Customer objectresult = null;
            foreach (Customer info in customerlist)
            {
                if (info.name == customer)
                    objectresult = info;
            }
            return objectresult;
        }
        //a function that deletes customer
        public static void removeCustomer()
        {
            Customer objectToDelete = GetCustomer();
            customerlist.Remove(objectToDelete);
            Console.Clear();
        }


        
    }
}