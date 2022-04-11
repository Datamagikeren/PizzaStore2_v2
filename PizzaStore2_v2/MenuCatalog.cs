using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2_v2
{
    class MenuCatalog
    {
       
        #region Lists

        public static List<Pizza> pizzaList = new List<Pizza>();
        public static List<Drinks> drinksList = new List<Drinks>();
        public static List<Topping> toppingList = new List<Topping>();

        #endregion

        #region Methods

        public static void PrintLogo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("PizzaStore ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("MenuApp");
            Console.ResetColor();
        }

        public static void Start() // Opretter alle start objekter og smider dem i lister
        {
            #region Topping Objekter
            Topping t1 = new Topping();
            t1.ItemId = 1; t1.Name = "Cheese"; t1.Price = 5;
            Topping t2 = new Topping();
            t2.ItemId = 2; t2.Name = "Tomato Sauce"; t2.Price = 5;
            Topping t3 = new Topping();
            t3.ItemId = 3; t3.Name = "Ham"; t3.Price = 5;
            Topping t4 = new Topping();
            t4.ItemId = 4; t4.Name = "Mushroom"; t3.Price = 5;
            Topping t5 = new Topping();
            t5.ItemId = 5; t5.Name = "Pineapple"; t5.Price = 5;
            Topping t6 = new Topping();
            t6.ItemId = 6; t6.Name = "Mixed Salad"; t6.Price = 7;
            Topping t7 = new Topping();
            t7.ItemId = 7; t7.Name = "Kebab"; t7.Price = 10;
            Topping t8 = new Topping();
            t8.ItemId = 8; t8.Name = "Dressing"; t8.Price = 5;
            Topping t9 = new Topping();
            t9.ItemId = 9; t9.Name = "Chicken"; t9.Price = 10;

            MenuCatalog.toppingList.AddRange(new List<Topping>() { t1, t2, t3, t4, t5, t6, t7, t8, t9 }); // Tilføjer alle toppings til en topping liste i MenuCatalog

            #endregion

            #region Pizza Objekter

            Pizza p1 = new Pizza();
            p1.ItemId = 1; p1.Name = "Mushroom"; p1.Price = 69;
            p1.ToppingList.AddRange(new List<Topping>() { t1, t2, t4 }); // Tilføjer toppings til pizza

            Pizza p2 = new Pizza();
            p2.ItemId = 2; p2.Name = "Ham"; p2.Price = 55;
            p2.ToppingList.AddRange(new List<Topping>() { t1, t2, t3 });

            Pizza p3 = new Pizza();
            p3.ItemId = 3; p3.Name = "Hawaii"; p3.Price = 59;
            p3.ToppingList.AddRange(new List<Topping>() { t1, t2, t3, t5 });

            Pizza p4 = new Pizza();
            p4.ItemId = 4; p4.Name = "Salatpizza m. Kebab"; p4.Price = 79;
            p4.ToppingList.AddRange(new List<Topping>() { t1, t6, t7, t8 });

            Pizza p5 = new Pizza();
            p5.ItemId = 5; p5.Name = "Salatpizza m. Kylling"; p5.Price = 69;
            p5.ToppingList.AddRange(new List<Topping>() { t1, t6, t7, t9 });

            Pizza p6 = new Pizza();
            p6.ItemId = 6; p6.Name = "Vegetar"; p6.Price = 49;
            p6.ToppingList.Add(t6);

            MenuCatalog.pizzaList.AddRange(new List<Pizza>() { p1, p2, p3, p4, p5, p6 }); // Tilføjer pizzaer til en pizza liste i MenuCatalog



            #endregion

            #region Drinks Objekter

            Drinks d1 = new Drinks();
            d1.ItemId = 51; d1.Name = "Coca Cola"; d1.Price = 29;
            Drinks d2 = new Drinks();
            d2.ItemId = 52; d2.Name = "Fanta"; d2.Price = 29;
            Drinks d3 = new Drinks();
            d3.ItemId = 53; d3.Name = "Faxe Kondi"; d3.Price = 25;
            Drinks d4 = new Drinks();
            d4.ItemId = 54; d4.Name = "Pepsi Max"; d4.Price = 25;
            Drinks d5 = new Drinks();
            d5.ItemId = 55; d5.Name = "Mælk"; d5.Price = 15;

            MenuCatalog.drinksList.AddRange(new List<Drinks>() { d1, d2, d3, d4, d5 }); // Tilføjer drinks til en drinks liste i MenuCatalog

            #endregion

            #region Customer Objekter Obs. Tilføjer sig selv til selv til CustomerCatalog liste ved oprettelse

            Customer c1 = new Customer("Benjamin", "Carlsen", "benjimail@email.com", "53443426", "Roskilde", "4040", "Bendixvej", "24");
            Customer c2 = new Customer("Anne-Lise", "Pedersen", "sødkat@kattemail.com", "43344556", "Taastrup", "2630", "Vindingevej", "36");
            Customer c3 = new Customer("Bent", "Bentsen", "hamlover@gmail.com", "46754243", "Hedehusene", "2640", "Storekøbsvej", "100");

            //CustomerCatalog.CustomerList.AddRange(new List<Customer>() { c1, c2, c3 }); // Tilføjer customers til en customer liste i CustomerCatalog


            #endregion

            #region Order objekter // OBS. Skal indeholde én customer i constructoren

            Order o1 = new Order(c1);
            o1.PizzaOrderList.AddRange(new List<Pizza>() { p1 });
            o1.DrinksOrderList.AddRange(new List<Drinks>() { d1, d2 });

            Order o2 = new Order(c2);
            o2.PizzaOrderList.AddRange(new List<Pizza>() { p1, p2, p6 });
            o2.DrinksOrderList.AddRange(new List<Drinks>() { d5, d5 });

            Order o3 = new Order(c3);
            o3.PizzaOrderList.AddRange(new List<Pizza>() { p1, p5, p2 });
            o3.DrinksOrderList.AddRange(new List<Drinks>() { d5, d5 });

            #endregion
            


        }

        public static string FormatUserMenu() //Metode til at formatere User Menu string
        {
            return "{0,-4} {1,0}";
        }

        public static void ReturnToMenuMessage()
        {
            Console.WriteLine($"Type '{pizzaList.Count + 1}' to return to User Menu");
        }

        public static void SortMenuByPrice()
        {
            pizzaList.Sort(delegate (Pizza x, Pizza y)
            {
                return x.Price.CompareTo(y.Price);
            });
        }

        public static void SortMenuById()
        {
            pizzaList.Sort(delegate (Pizza x, Pizza y)
            {
                return x.ItemId.CompareTo(y.ItemId);
            });
        }

        public static void SortMenuByName()
        {
            pizzaList.Sort(delegate (Pizza x, Pizza y)
            {
                return x.Name.CompareTo(y.Name);
            });
        }

        public static void SearchPizzaReturnToMenu()
        {
            while (true)
            {
                Console.WriteLine("Type 'y' to return to the User Menu");
                Console.WriteLine("Type 'o' to search for a new pizza");

                string userInput2;
                userInput2 = Console.ReadLine();

                if (userInput2 == "y")
                {
                    Console.Clear();
                    PrintUserMenuAdmin();
                }
                else if (userInput2 == "o")
                {
                    Console.Clear();
                    SearchPizza();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You typed something that leads you nowhere. Check your options, and try again!");
                    Console.WriteLine();
                }

            }
        }

        public static void SearchPizza()
        {
            string userInputString;
            int userInputInt;
            ReturnToMenuMessage();
            Console.WriteLine();
            Console.WriteLine("Type 'y' to search for pizza by number");
            Console.WriteLine("Type 'n' to search for pizza by name");
            userInputString = Console.ReadLine();
            if (userInputString == GoBackButtonString)
            {
                Console.Clear();
                PrintUserMenuAdmin();
            }
            #region If search by number
            else if (userInputString == "y")
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Search for pizza by number:");
                    try
                    {
                        userInputInt = Convert.ToInt32(Console.ReadLine());
                        if (userInputInt == GoBackButtonInt)
                        {
                            Console.Clear();
                            PrintUserMenuAdmin();
                        }
                        foreach (Pizza i in pizzaList)
                        {
                            if (i.ItemId == userInputInt)
                            {
                                Console.Clear();
                                Console.WriteLine($"Your search returned this information about pizza number {i.ItemId}:");
                                Console.WriteLine();
                                Console.WriteLine($"{i.Name} has ID. no {i.ItemId} and costs {i.Price}");
                                Console.Write("Contains pizzatoppings: ");
                                foreach (Topping o in i.ToppingList)
                                {
                                    Console.Write($"{o.Name}, ");
                                }
                                Console.WriteLine();
                                Console.WriteLine();
                                SearchPizzaReturnToMenu();
                            }

                            else if (userInputInt > pizzaList.Count - 1)
                            {
                                Console.Clear();
                                Console.WriteLine($"Type '{GoBackButtonString}' to return to User Menu");
                                Console.WriteLine("The number you searched for is not on the menu");
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

            #region If search by name

            else if (userInputString == "n")
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Search for pizza by name:");
                    try
                    {
                        userInputString = Console.ReadLine();
                        if (userInputString == $"{GoBackButtonString}")
                        {
                            Console.Clear();
                            PrintUserMenuAdmin();
                        }
                        foreach (Pizza i in pizzaList)
                        {
                            if (i.Name == userInputString)
                            {
                                Console.Clear();
                                Console.WriteLine($"Your search returned this information about pizza '{i.Name}':");
                                Console.WriteLine();
                                Console.WriteLine($"{i.Name} has ID. no {i.ItemId} and costs {i.Price}");
                                Console.Write("Contains pizzatoppings: ");
                                foreach (Topping o in i.ToppingList)
                                {
                                    Console.Write($"{o.Name}, ");
                                }
                                Console.WriteLine();
                                SearchPizzaReturnToMenu();
                            }

                        }
                        Console.Clear();
                        Console.WriteLine($"Your search came back empty. Try check your spelling, or type {GoBackButtonString} to return to the User Menu");
                        Console.WriteLine("Note: Every pizza starts with a capital letter");
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Please insert something");
                    }
                }
            }
            #endregion
            Console.Clear();
            Console.WriteLine("Please choose one of the following options");
            SearchPizza();
        }

        public static void PrintMenuAdmin() //fix forkert input
        {
            while (true)
            {
                string userInputString;
                Console.WriteLine("BigMamaPizzaria's Menu Catalog");
                foreach (Pizza i in pizzaList)
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.Write("{0,-3}{1,-35}", $"{i.ItemId}.", $"{i.Name}");
                    Console.WriteLine("{0,6}", $"{i.Price},-");
                    Console.Write("{0,2}", "");
                    foreach (Topping o in i.ToppingList)
                    {
                        Console.Write($"- {o} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Type 'y' change the order of the menu");
                Console.WriteLine("Type 'o' to return to the User Menu");

                userInputString = Console.ReadLine();
                if (userInputString == "y")
                {
                    Console.WriteLine("Type '1' to sort the menu by number ID (starting from '1')");
                    Console.WriteLine("Type '2' to sort the menu by name (from A - Z)");
                    Console.WriteLine("Type '3' to sort the menu by price (starting from lowest price)");
                    userInputString = Console.ReadLine();
                    if (userInputString == "1")
                    {
                        SortMenuById();
                        Console.Clear();
                        PrintMenuAdmin();
                    }
                    else if (userInputString == "2")
                    {
                        SortMenuByName();
                        Console.Clear();
                        PrintMenuAdmin();
                    }
                    else if (userInputString == "3")
                    {
                        SortMenuByPrice();
                        Console.Clear();
                        PrintMenuAdmin();
                    }

                }
                else if (userInputString == "o")
                {
                    Console.Clear();
                    PrintUserMenuAdmin();
                }
                Console.Clear();
                Console.WriteLine("Please enter something");
            }
        }

        public static void RemovePizza()
        {
            ReturnToMenuMessage();
            Console.WriteLine();
            Console.WriteLine("Which pizza no. do you wish to remove from the menu?");
            int o = 1;
            foreach (Pizza i in pizzaList)
            {
                Console.WriteLine($"{o}. {i.Name}");
                o++;
            }

            while (true)
            {
                try
                {
                    int userInput;
                    userInput = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (userInput == pizzaList.Count + 1)
                    {
                        Console.Clear();
                        PrintUserMenuAdmin();
                    }
                    Console.Clear();
                    Console.WriteLine($"{pizzaList[userInput]} was successfully removed from the menu!");
                    pizzaList.RemoveAt(userInput);
                    Console.WriteLine();
                    break;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number you typed does not exist on the menu. Please try a new number");
                    RemovePizza();

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please only insert numbers");
                }

            }
            while (true)
            {
                Console.WriteLine("Type 'y' to see the updated menu");
                Console.WriteLine("Type 'n' to return to the User Menu");
                Console.WriteLine("Type 'o' to delete another pizza from the menu");

                string userInput2;
                userInput2 = Console.ReadLine();

                if (userInput2 == "y")
                {
                    Console.Clear();
                    PrintMenuAdmin();
                }
                else if (userInput2 == "n")
                {
                    Console.Clear();
                    PrintUserMenuAdmin();
                }
                else if (userInput2 == "o")
                {
                    Console.Clear();
                    RemovePizza();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You typed something that leads you nowhere. Check your options, and try again!");
                    Console.WriteLine();
                }
            }


        }

        public static void PrintToppingMenu()
        {
            foreach (Topping i in toppingList)
            {
                Console.WriteLine($"{i.ItemId}. {i.Name}");
            }
        }

        public static void CreatePizza() // Fix total reset ved forkert indtastning (evt. lav metode og smid i catch?)
                                         // Navn må ikke være tomt.
        {                                   

            string pizzaName;
            int pizzaPrice;
            int ItemId;
            int userInput;
            string userInputString;
            while (true)
            {
                try
                {
                    Console.WriteLine($"Your pizza will be added to the menu as number {pizzaList.Count + 1}");
                    Console.WriteLine();
                    ItemId = pizzaList.Count + 1;
                    Console.WriteLine();
                    Console.WriteLine("What would you like to name the pizza?");
                    Console.WriteLine();
                    pizzaName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine($"What would you like to set price of {pizzaName}?");
                    Console.WriteLine();
                    pizzaPrice = Convert.ToInt32(Console.ReadLine());

                    Pizza p = new Pizza();
                    p.Price = pizzaPrice;
                    p.Name = pizzaName;
                    p.ItemId = ItemId;
                    

                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"What topping would you like to add to {pizzaName}?");
                        Console.WriteLine("List of toppings:");
                        Console.WriteLine();
                        PrintToppingMenu();
                        userInput = Convert.ToInt32(Console.ReadLine());
                        p.ToppingList.Add(toppingList[userInput - 1]);
                        Console.Clear();
                        Console.WriteLine($"{toppingList[userInput - 1]} was successfully added to your pizza!");
                        Console.WriteLine($"This is how your pizza is currently setup: ");
                        Console.WriteLine();

                        Console.Write($"Number: {p.ItemId}\nName: {p.Name}\nPrice: {p.Price}\nTopping: ");
                        foreach (Topping i in p.ToppingList)
                        {
                            Console.Write($"{i}, ");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("To add more topping, type 'y'");
                        Console.WriteLine("To finish the pizza, type 'n'");
                        userInputString = Console.ReadLine();
                        Console.Clear();
                        if (userInputString == "n")
                            break;
                    }

                    pizzaList.Add(p);
                    Console.Clear();
                    Console.WriteLine($"Your new pizza: '{p.Name}' was successfully created. It's listed as ID no. '{p.ItemId}', and the price is set to '{p.Price}'");
                    Console.WriteLine();
                    SortMenuById();
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("You have to enter a number");

                }
                catch (System.ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number you entered is not on the list of options. Try again!");
                }

            }
            while (true)
            {
                Console.WriteLine("Type 'y' to see the updated menu");
                Console.WriteLine("Type 'n' to return to the User Menu");
                Console.WriteLine("Type 'o' to add another pizza to the menu");

                string userInput2;
                userInput2 = Console.ReadLine();

                if (userInput2 == "y")
                {
                    Console.Clear();
                    PrintMenuAdmin();
                }
                else if (userInput2 == "n")
                {
                    Console.Clear();
                    PrintUserMenuAdmin();
                }
                else if (userInput2 == "o")
                {
                    Console.Clear();
                    CreatePizza();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You typed something that leads you nowhere. Check your options, and try again!");
                    Console.WriteLine();
                }
            }




        }

        public static void UpdatePizza() // Opdater til individuel ændring
        {
            ReturnToMenuMessage();
            Console.WriteLine();
            Console.WriteLine("Which pizza do you wish to update?");
            Console.WriteLine();
            int o = 1;
            foreach (Pizza i in pizzaList)
            {
                Console.WriteLine($"{o}. {i.Name}");
                o++;
            }
            while (true)
            {
                try
                {

                    int userInput;
                    userInput = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (userInput == pizzaList.Count)
                    {
                        Console.Clear();
                        PrintUserMenuAdmin();
                    }
                    Console.Clear();
                    Console.WriteLine($"You are now updating the pizza: {pizzaList[userInput]}");
                    Console.WriteLine();
                    Console.WriteLine($"What do you wish for the new name to be?");
                    pizzaList[userInput].Name = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine($"What do you wish for the new updated price to be? Its previous price was {pizzaList[userInput].Price}");
                    pizzaList[userInput].Price = Convert.ToInt32(Console.ReadLine()); ;
                    Console.WriteLine();
                    Console.WriteLine($"What do you wish for the new updated number on menu to be? It was previously listed as number {pizzaList[userInput].ItemId}");
                    pizzaList[userInput].ItemId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Update complete: The new name of the pizza is now '{pizzaList[userInput].Name}'. It's now listed as no. {pizzaList[userInput].ItemId}, and the price is set to {pizzaList[userInput].Price}");
                    break;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number you typed does not exist on the menu. Please try a new number");
                    UpdatePizza();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please only insert numbers");
                }
            }
            while (true)
            {
                Console.WriteLine("Type 'y' to see the updated menu");
                Console.WriteLine("Type 'n' to return to the User Menu");
                Console.WriteLine("Type 'o' to update another pizza to the menu");

                string userInput2;
                userInput2 = Console.ReadLine();

                if (userInput2 == "y")
                {
                    Console.Clear();
                    PrintMenuAdmin();
                }
                else if (userInput2 == "n")
                {
                    Console.Clear();
                    PrintUserMenuAdmin();
                }
                else if (userInput2 == "o")
                {
                    Console.Clear();
                    CreatePizza();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You typed something that leads you nowhere. Check your options, and try again!");
                    Console.WriteLine();
                }
            }
        }

        public static void PrintUserMenuAdmin()
        {
            PrintLogo();
            Console.WriteLine();
            Console.WriteLine(FormatUserMenu(), "1.", "Add new pizza to the menu");
            Console.WriteLine(FormatUserMenu(), "2.", "Delete pizza");
            Console.WriteLine(FormatUserMenu(), "3.", "Update pizza");
            Console.WriteLine(FormatUserMenu(), "4.", "Search pizza");
            Console.WriteLine(FormatUserMenu(), "5.", "Display pizza menu");
            Console.WriteLine(FormatUserMenu(), "6.", "Display orders");
            Console.WriteLine(FormatUserMenu(), "7.", "Display Customer Catalog");
            Console.WriteLine(FormatUserMenu(), "8.", "Return to login screen");
            Console.WriteLine();
            Console.WriteLine("Please type the menu section no. you wish to access, and click 'enter'");

            int userInput;
            while (true)
            {
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                    if (userInput > 8 || userInput < 0)
                    {
                        Console.WriteLine("Please select an option between 1 and 8");
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
                    CreatePizza();
            }
            else if (userInput == 2)
            {
                Console.Clear();
                RemovePizza();
            }
            else if (userInput == 3)
            {
                Console.Clear();
                UpdatePizza();
            }
            else if (userInput == 4)
            {
                Console.Clear();
                SearchPizza();
            }
            else if (userInput == 5)
                {
                    Console.Clear();
                    PrintMenuAdmin();
                }
            else if (userInput == 6)
            {
                Console.Clear();
                Order.PrintOrderList();
                
            }
            else if (userInput == 7)
            {
                Console.Clear();
                CustomerCatalog.PrintCustomerCatalogOptions();
            }
            else if (userInput == 8)
            {
                Console.Clear();
                LoginScreen();
            }
        }

        public static void PrintUserMenu()
        {
            PrintLogo();
            Console.WriteLine("Welcome to BigMamaPizzaria! We hope you enjoy your stay!");
            Console.WriteLine();
            Console.WriteLine("Type '1' to see the menu");
            Console.WriteLine("Type '2' to create account and order pizza/drinks");
            Console.WriteLine("Type '3' to return to login screen");
            string userInput = "0";
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.Clear();
                PrintMenu();
            }
            else if (userInput == "2")
            {
                Console.Clear();
                OrderPizza();
            }
            else if (userInput == "3")
            {
                Console.Clear();
                LoginScreen();
            }
        }

        public static void PrintMenu()
        {
            PrintLogo();
            while (true)
            {
                
                Console.WriteLine("BigMamaPizzaria's Menu Catalog");
                foreach (Pizza i in pizzaList)
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.Write("{0,-3}{1,-35}", $"{i.ItemId}.", $"{i.Name}");
                    Console.WriteLine("{0,6}", $"{i.Price},-");
                    Console.Write("{0,2}", "");
                    foreach (Topping o in i.ToppingList)
                    {
                        Console.Write($"- {o} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("--------------------------------------------");
                break;
            }
            Console.WriteLine();
            Console.WriteLine("Click anywhere to return to user menu");
            Console.ReadKey();
            Console.Clear();
            PrintUserMenu();
        }

        public static void LoginScreen()
        {
            PrintLogo();
            Console.WriteLine();
            Console.WriteLine("Welcome to BigMamaPizzaria!");
            Console.WriteLine("You now have the following login options:");
            Console.WriteLine();
            Console.WriteLine("Type '1' to login as admin");
            Console.WriteLine("Type '2' to login as customer");
            string userInput = "0";
            
            while (true)
            {
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Console.Clear();
                    PrintUserMenuAdmin();
                    break;                    
                }
                else if (userInput == "2")
                {
                    Console.Clear();
                    PrintUserMenu();
                    break;                    
                }
                Console.WriteLine("Please click either 1 or 2");
                
            }
        }

        public static void OrderPizza()
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

            Console.WriteLine("Creating account");
            Console.WriteLine();
            Console.WriteLine("First name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Surname:");
            surName = Console.ReadLine();
            Console.WriteLine("Email:");
            email = Console.ReadLine();
            Console.WriteLine("Phonenumber:");
            phoneNumber = Console.ReadLine();
            Console.WriteLine("City:");
            city = Console.ReadLine();
            Console.WriteLine("Postal code:");
            postalCode = Console.ReadLine();
            Console.WriteLine("Street name:");
            streetName = Console.ReadLine();
            Console.WriteLine("House number:");
            houseNumber = Console.ReadLine();
            Customer c = new Customer(firstName, surName, email, phoneNumber, city, postalCode, streetName, houseNumber);
            Console.Clear();
            Console.WriteLine($"Success! {firstName}, your account has been created, you can now order from the menu");
            Console.WriteLine("Press 'enter' to see the menu to continue your order");
            Console.ReadKey();
            PrintLogo();
            while (true)
            {

                Console.WriteLine("BigMamaPizzaria's Menu Catalog");
                foreach (Pizza i in pizzaList)
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.Write("{0,-3}{1,-35}", $"{i.ItemId}.", $"{i.Name}");
                    Console.WriteLine("{0,6}", $"{i.Price},-");
                    Console.Write("{0,2}", "");
                    foreach (Topping g in i.ToppingList)
                    {
                        Console.Write($"- {g} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("--------------------------------------------");
                break;
            }
            Order o = new Order(c);
            
            while (true)
            {
                int userInput2 = 0;
                string userInput3 = "0";
                Console.WriteLine("Please enter the number of the pizza you wish to order");
                userInput2 = Convert.ToInt32(Console.ReadLine()) - 1;
                o.PizzaOrderList.Add(pizzaList[userInput2]);
                Console.WriteLine($"{pizzaList[userInput2]} was added to your order");
                Console.WriteLine("Press 'y' to add another pizza to your order");
                Console.WriteLine("Press 'n' to continue to drinks menu");
                userInput3 = Console.ReadLine();
                if (userInput3 == "n")
                {
                    Console.Clear();
                    break;
                }
            }
            Console.WriteLine("You successfully added pizzas to your order. Your current order is:");
            foreach (Pizza i in o.PizzaOrderList)
            {
                Console.Write($"{i.Name} ");
                Console.WriteLine($"{i.Price}kr");
            }
            Console.WriteLine();            
            Console.WriteLine();
            foreach (Drinks h in drinksList)
            {
                Console.Write($"{h.ItemId-50}. ");
                Console.Write($"{h.Name} ");
                Console.WriteLine($"{h.Price}kr");
            }
            Console.WriteLine();
            while (true)
            {
                int userInput2 = 0;
                string userInput3 = "0";
                Console.WriteLine("Please enter the number of the drink you wish to order");
                userInput2 = Convert.ToInt32(Console.ReadLine()) - 1;
                o.DrinksOrderList.Add(drinksList[userInput2]);
                Console.WriteLine($"{drinksList[userInput2]} was added to your order");
                Console.WriteLine("Press 'y' to add another drink to your order");
                Console.WriteLine("Press 'n' to continue to drinks menu");
                userInput3 = Console.ReadLine();
                if (userInput3 == "n")
                {
                    Console.Clear();
                    break;
                }
            }
            Console.WriteLine("You successfully added pizzas and drinks to your order. Your current order is:");
            Console.WriteLine();
            foreach (Pizza i in o.PizzaOrderList)
            {
                Console.Write($"{i.Name} ");
                Console.WriteLine($"{i.Price}kr");
            }
            Console.WriteLine();
            foreach (Drinks i in o.DrinksOrderList)
            {
                Console.Write($"{i.Name} ");
                Console.WriteLine($"{i.Price}kr");
            }
            Console.WriteLine("You order is completed and is sent to BigMamaPizzaria");
            Console.WriteLine("Press 'enter to return to user menu");
            Console.ReadKey();
            PrintUserMenu();

        } // Fix string input ved valg af pizza (fører til customer search??)


        #endregion

        #region Properties

        public static string GoBackButtonString
        {
            get { return $"{pizzaList.Count + 1}"; }
        }
        public static int GoBackButtonInt
        {
            get { return pizzaList.Count + 1; }
        }

        #endregion
    }


}

