using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2_v2
{
    class CustomerCatalog
    {
        #region Lists

        public static List<Customer> CustomerList = new List<Customer>();

        #endregion 

        public static void PrintCustomerCatalogOptions()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("PizzaStore ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("MenuApp");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(MenuCatalog.FormatUserMenu(), "1.", "Add new customer to the customer catalog");
            Console.WriteLine(MenuCatalog.FormatUserMenu(), "2.", "Delete customer");
            Console.WriteLine(MenuCatalog.FormatUserMenu(), "3.", "Update customer (to be implemented)");
            Console.WriteLine(MenuCatalog.FormatUserMenu(), "4.", "Search customer");
            Console.WriteLine(MenuCatalog.FormatUserMenu(), "5.", "Display customer catalog list");
            Console.WriteLine(MenuCatalog.FormatUserMenu(), "6.", "Return to Pizza Menu");
            Console.WriteLine();
            Console.WriteLine("Please type the menu section no. you wish to access, and click 'enter'");

            int userInput;
            while (true)
            {
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                    if (userInput > 6 || userInput <= 0)
                    {
                        Console.WriteLine("Please select an option between 1 and 6");
                    }
                    else
                        break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please insert only numbers");
                }
            }

            if (userInput == 1)
            {
                Console.Clear();
                CreateCustomer();
            }
            else if (userInput == 2)
            {
                Console.Clear();
                RemoveCustomer();
            }
            else if (userInput == 3)
            {
                Console.Clear();
                PrintCustomerCatalogOptions();
            }
            else if (userInput == 4)
            {
                Console.Clear();
                SearchCustomer();
            }
            else if (userInput == 5)
            {
                Console.Clear();
                PrintCustomerCatalog();
            }
            else if (userInput == 6)
            {
                Console.Clear();
                MenuCatalog.PrintUserMenuAdmin();
            }
        }

        public static void CreateCustomer() // Fix at 2 objekter med samme Id ikke kan ske
        {
            string firstName;
            string surName;
            string email;
            string phoneNumber;
            string city;
            string postalCode;
            string streetName;
            string houseNumber;
            string userInput;

            Console.WriteLine("You are now creating a new customer");
            Console.WriteLine("The new customer will automatically be added to the customer catalog list with a unique ID");
            Console.WriteLine();
            Console.WriteLine("Customer first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Customer surname:");
            surName = Console.ReadLine();
            Console.WriteLine("Customer email:");
            email = Console.ReadLine();
            Console.WriteLine("Customer phone number:");
            phoneNumber = Console.ReadLine();
            Console.WriteLine("Customer city of residence:");
            city = Console.ReadLine();
            Console.WriteLine("Customer city of residence postal code:");
            postalCode = Console.ReadLine();
            Console.WriteLine("Customer street name of residence:");
            streetName = Console.ReadLine();
            Console.WriteLine("Customer house number of residence");
            houseNumber = Console.ReadLine();
            Customer c = new Customer(firstName, surName, email, phoneNumber, city, postalCode, streetName, houseNumber);
            Console.Clear();
            Console.WriteLine("Customer was sucesfully added to the customer catalog!");
            Console.WriteLine("Customer Info:");
            Console.WriteLine();
            Console.WriteLine(c);
            Console.WriteLine();
            CreateCustomerReturnMessage();
            


        }

        public static void CreateCustomerReturnMessage()
        {
            string userInput = "0";
            Console.WriteLine("Type 'y' to see the updated customer catalog");
            Console.WriteLine("Type 'n' to return the User Menu");
            Console.WriteLine("Type 'o' to add another customer to the catalog");
            userInput = Console.ReadLine();
            if (userInput == "y")
            {
                Console.Clear();
                PrintCustomerCatalog();
            }
            else if (userInput == "n")
            {
                Console.Clear();
                PrintCustomerCatalogOptions();
            }
            else if (userInput == "o")
            {
                Console.Clear();
                CreateCustomer();
            }
        }

        public static void RemoveCustomer()
        {
            Console.WriteLine();
            Console.WriteLine("Which customer (ID) do you wish to remove from the customer catalog?");
            int o = 1;
            foreach (Customer i in CustomerList)
            {
                Console.WriteLine($"{o}. {i.FullName}");
                o++;
            }

            while (true)
            {
                try
                {
                    int userInput;
                    userInput = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (userInput == CustomerList.Count + 1)
                    {
                        Console.Clear();
                        PrintCustomerCatalogOptions();
                    }
                    Console.Clear();
                    Console.WriteLine($"{CustomerList[userInput]}");

                    Console.WriteLine("This customer has been removed from the customer catalog");
                    CustomerList.RemoveAt(userInput);
                    Console.WriteLine();
                    break;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number you typed does not exist on the menu. Please try a new number");
                    RemoveCustomer();

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please only insert numbers");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Type 'y' to see the updated customer catalog");
            Console.WriteLine("Type 'n' to return the the user menu");
            Console.WriteLine("Type 'o' to remove another customer");
            string userInput2;
            userInput2 = Console.ReadLine();
            if (userInput2 == "y")
            {
                Console.Clear();
                PrintCustomerCatalog();
            }
            else if (userInput2 == "n")
            {
                Console.Clear();
                PrintCustomerCatalogOptions();
            }
            else if (userInput2 == "o")
            {
                Console.Clear();
                RemoveCustomer();
            }


        }

        public static void SearchCustomerReturnToMenu()
        {
            while (true)
            {
                Console.WriteLine("Type 'y' to return to the User Menu");
                Console.WriteLine("Type 'o' to search for a new customer");

                string userInput2;
                userInput2 = Console.ReadLine();

                if (userInput2 == "y")
                {
                    Console.Clear();
                    PrintCustomerCatalogOptions();
                }
                else if (userInput2 == "o")
                {
                    Console.Clear();
                    SearchCustomer();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You typed something that leads you nowhere. Check your options, and try again!");
                    Console.WriteLine();
                }

            }
        }

        public static void SearchCustomer()
        {
            string userInputString = "0";
            int userInputInt;           
           
            Console.WriteLine("Type 'y' to search for a customer by customer ID");
            Console.WriteLine("Type 'n' to search for a customer by full name");
            userInputString = Console.ReadLine();
            #region If search by number
            if (userInputString == "y")
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Search for customer by customer ID:");
                    try
                    {
                        userInputInt = Convert.ToInt32(Console.ReadLine());
                       
                        foreach (Customer i in CustomerList)
                        {
                            if (i.CustomerId == userInputInt)
                            {
                                Console.Clear();
                                Console.WriteLine($"Your search returned this information about customer ID number {i.CustomerId}:");
                                Console.WriteLine();
                                Console.WriteLine(i);
                                Console.WriteLine();
                                Console.WriteLine();
                                SearchCustomerReturnToMenu();
                            }                               
                            

                            else if (userInputInt > CustomerList.Count - 1)
                            {
                                Console.Clear();                                
                                Console.WriteLine("The ID you searched for is not in the customer catalog");
                            }
                        }

                    }
                    catch (System.FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Please only insert numbers!");
                    }
                }
            }
            #endregion

            #region If search by Full Name

            else if (userInputString == "n")
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Search for customer by full name:");
                    try
                    {
                        userInputString = Console.ReadLine();
                        
                        foreach (Customer i in CustomerList)
                        {
                            if (i.FullName == userInputString)
                            {
                                Console.Clear();
                                Console.WriteLine($"Your search returned this information about {i.FullName}:");
                                Console.WriteLine();
                                Console.WriteLine(i);
                                Console.WriteLine();
                                Console.WriteLine();
                                SearchCustomerReturnToMenu();                                
                            }

                        }
                        Console.Clear();
                        Console.WriteLine($"Your search came back empty. Try check your spelling and try again");                        
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Please insert something");
                    }
                }
            }

            #endregion
        }

        public static void PrintCustomerCatalog()
        {
            foreach (Customer i in CustomerList)
            {
                Console.WriteLine(i);
                Console.WriteLine();
            }
            Console.WriteLine("Press anything to return to the customer catalog menu");
            Console.ReadKey();
            Console.Clear();
            PrintCustomerCatalogOptions();
        }



    }
}