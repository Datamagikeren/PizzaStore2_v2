using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2_v2
{
    
    class Order
    {
        #region Instance fields

        Pizza _pizza;
        Drinks _drinks;
        Customer _customer;
        private int _orderNumber;

        #endregion        

        #region Lists

        public  List<Pizza> PizzaOrderList = new List<Pizza>();
        public  List<Drinks> DrinksOrderList = new List<Drinks>();
        public static List<Order> OrderList = new List<Order>();
        #endregion

        #region Constructor

        public Order(Customer customer)
        {

            PizzaOrderList = new List<Pizza>();
            DrinksOrderList = new List<Drinks>();
            _customer = customer;
            OrderList.Add(this);
            _orderNumber = OrderList.Count;
            

        }

        #endregion
        #region Properties   
        
        public int OrderNumber
        {
            get { return _orderNumber; }
        }

        #endregion

        #region Methods                

        public static void PrintOrderList()
        {
            int totalPizzaPrice = 0;
            foreach (Order o in OrderList)
            {
                Console.WriteLine();
                Console.WriteLine($"{o._customer}");                
                foreach (Pizza i in o.PizzaOrderList)
                {

                    Console.Write("{0,-3}{1,-15}", $"{i.ItemId}.", $"{i.Name}");
                    Console.WriteLine("{0,6}", $"{i.Price},-");                    
                    foreach (Topping t in i.ToppingList)
                    {
                        Console.Write("{0,2}", "");
                        Console.Write($"- {t} ");
                        Console.WriteLine();
                    }                    
                    
                    Console.WriteLine();

                }
                
                foreach (Drinks i in o.DrinksOrderList)
                {
                    Console.Write("{0,-3}{1,-15}", $"{i.ItemId}.", $"{i.Name}");
                    Console.WriteLine("{0,6}", $"{i.Price},-");


                }
                
                Console.WriteLine();
                Console.WriteLine($"Total price:");
                Console.WriteLine("----------------------");

            }
            Console.WriteLine();
            Console.WriteLine("Press anywhere to return to the customer catalog menu");
            Console.ReadKey();
            Console.Clear();
            MenuCatalog.PrintUserMenuAdmin();
        }


        

        #endregion
    }
}
