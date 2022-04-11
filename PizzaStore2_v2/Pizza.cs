using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2_v2
{
    class Pizza : Item
    {

        #region Instance fields

        #endregion

        #region Lists

        public List<Topping> ToppingList = new List<Topping>();

        #endregion

        #region Constructor
        public Pizza()
        {
           ToppingList = new List<Topping> ();
            
        }
        #endregion

        #region Methods



        #endregion

    }
}
