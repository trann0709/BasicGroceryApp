using System;
using System.Collections.Generic;

namespace BasicGroceryApp
{
    class GroceryMart
    {
        // Fields
        private Product[][] _allProducts;
        private ScreenDisplay _screenDisplay;


        // Constructors 
        public GroceryMart(Product[][] allProducts)
        {
            this._screenDisplay = new ScreenDisplay();
            this._allProducts = allProducts;
        }

        public void Display()
        {
            // this._screenDisplay.WelcomeMessage();
            this._screenDisplay.MenuSelection(this._allProducts);
        }

    }
}