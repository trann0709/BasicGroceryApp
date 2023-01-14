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
        // private int _totalAmount;
        // private Product _item;

        private Dictionary<string, int> _cart;
        // private int _row;
        // private int _col;

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
            this._cart = new Dictionary<string, int>();

            // this._totalAmount = 0;
            // this._numItemInCart = 0;
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
                        Console.Clear();
                        _screenDisplay.MenuSelection(AllProducts);
                        _screenDisplay.DisplayMessage("\nPlease Select an Item Using Product Number: ");
                        int prodNumber = _input.GetInput();
                        AddToCart(prodNumber);
                        break;
                    case 2:
                        // _screenDisplay.DisplayMessage($"\nThe total is: ${_totalAmount}.");
                        break;
                    default:
                        Console.Clear();
                        _screenDisplay.DisplayMessage("Please Enter a Valid Selection.");
                        break;

                }
            }
        }

        private void UpdateQuantity(int r, int c, int value)
        {
            AllProducts[r][c].Quantity -= value;
        }

        private void AddToCart(int prodNumber)
        {
            int row = prodNumber / 10 - 1;
            int col = prodNumber % 10 - 1;
            if (row >= 0 && row <= Enum.GetNames(typeof(CategoryItem)).Length && col >= 0 && col < 3)
            {
                Product selectedItem = AllProducts[row][col];
                if (selectedItem != null && selectedItem.Quantity >= 1)
                {
                    while (true)
                    {
                        _screenDisplay.DisplayMessage("\nPlease enter the quantity: ");
                        int selectedQuantity = _input.GetInput();
                        if (selectedQuantity > 0 && selectedQuantity <= selectedItem.Quantity)
                        {
                            string unit = selectedItem.Category == "beverages" ? "pack" : "pound";
                            string s = selectedQuantity > 1 ? "s" : "";
                            _screenDisplay.DisplayMessage($"\nYou've added {selectedQuantity} {unit}{s} of {selectedItem.Name} to the cart.");
                            if (!_cart.ContainsKey(selectedItem.Name))
                            {
                                _cart[selectedItem.Name] = selectedQuantity;
                            }
                            else
                            {
                                _cart[selectedItem.Name] += selectedQuantity;
                            }

                            UpdateQuantity(row, col, selectedQuantity);
                            break;
                        }
                        else
                        {
                            _screenDisplay.DisplayMessage("\nPlease Enter a Valid Number.");
                        }
                    }

                }
                else
                {
                    if (selectedItem == null)
                    {
                        _screenDisplay.DisplayMessage("\nThere's No Product Associated With The Entered Number.");
                    }
                    else _screenDisplay.DisplayMessage($"\nThe Selected Product {selectedItem.Name} is Out of Stock.");
                }
            }
            else
            {
                _screenDisplay.DisplayMessage("\nPlease Enter a Valid Product Number");
            }
        }

    }
}