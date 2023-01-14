using System;
using System.Collections.Generic;

namespace BasicGroceryApp
{
    class GroceryMart
    {
        // Fields
        private Product[][] _allProducts;
        private ScreenDisplay _screenDisplay;
        private UserInput _input;

        // Properties 
        public Product[][] AllProducts
        {
            get
            {
                return _allProducts;
            }
        }


        // Constructors 
        public GroceryMart(Product[][] allProducts)
        {
            this._screenDisplay = new ScreenDisplay();
            this._allProducts = allProducts;
            this._input = new UserInput();
        }

        public void TurnOn()
        {
            _screenDisplay.WelcomeMessage();
            int userInput = 0;

            while (true)
            {
                _screenDisplay.MenuSelection();
                _screenDisplay.DisplayMessage("Please Enter Your Selection: ");
                userInput = _input.GetInput();
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Option 1");
                        break;
                    case 2:
                        Console.WriteLine("Option 2");
                        break;
                    default:
                        Console.Clear();
                        _screenDisplay.DisplayMessage("Please Enter a Valid Selection.");
                        break;

                }
            }
        }

    }
}