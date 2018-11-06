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
                Console.WriteLine("Welcome to  Big Bank!");

                Console.WriteLine("");
                Console.WriteLine("Pick your poison!");
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
                    Console.WriteLine("det blev knas");
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

                    case 4:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Ooops... still under construction");
                        /*foreach (Customer info in customerlist)
                        {
                            Console.WriteLine(info.customerInfo());
                        }*/
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Ooops... still under construction");
                        /*foreach (Customer info in customerlist)
                        {
                            Console.WriteLine(info.customerInfo());
                        }
                        addBalance();*/
                        Console.ReadKey();
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

        //Här är funktionen som tar bort en användare
        public static void removeCustomer()
        {
            Console.WriteLine("");
            Console.WriteLine("Write the full name of the customer you'd like to delete!");
            string customerToDelete = Console.ReadLine();
            Customer objectToDelete = null;
            foreach (Customer info in customerlist)
            {
                if (info.name == customerToDelete)
                    objectToDelete = info;
            }
            customerlist.Remove(objectToDelete);
            Console.Clear();
        }

        /*public static void addBalance()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Write the full name of the customer you'd like to make a deposit!");
            int customerBalanceAdd = int.Parse(Console.ReadLine());
            Customer balanceToAdd = null;
            balanceToAdd = int.Parse(   Console.ReadLine());
            foreach (Customer info in customerlist)
            {
                if (info.balance == customerBalanceAdd)
                    balanceToAdd = info;
            }
            customerlist.Add(balanceToAdd);
            Console.Clear();
        }*/
    }
}