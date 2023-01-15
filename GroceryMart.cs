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
        private Dictionary<Product, int> _cart;
        private int _totalAmount;


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
            this._cart = new Dictionary<Product, int>();
            this._totalAmount = 0;
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
                        ProductSelection();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("----------Cart----------\n");
                        if (_cart.Count == 0)
                        {
                            _screenDisplay.DisplayMessage("\nCart is Empty.\n");
                        }
                        else
                        {
                            ShowCart();
                        }
                        Console.WriteLine("\n------------------------");
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        if (_cart.Count == 0)
                        {
                            _screenDisplay.DisplayMessage("Thank You for Using Grocery Mart. See You Next Time!\n");
                            return;
                        }
                        else
                        {
                            _screenDisplay.DisplayMessage("There're Items in The Cart. Would you like to check out instead?");
                            _screenDisplay.DisplayMessage("\nPlease Enter 1 for Yes: ");
                            int resp = _input.GetInput();
                            if (resp != 1)
                            {
                                Console.Clear();
                                _screenDisplay.DisplayMessage("Thank You for Using Grocery Mart. See You Next Time!\n");
                                return;
                            }
                        }
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

        private void ShowCart()
        {
            foreach (KeyValuePair<Product, int> kvp in _cart)
            {
                kvp.Key.DisplayMessage(kvp.Key, kvp.Value);
                _totalAmount += kvp.Value * kvp.Key.Price;
            }
            Console.WriteLine($"\nTOTAL: ${_totalAmount}");
        }

        private void ProductSelection()
        {
            while (true)
            {
                _screenDisplay.DisplayMessage("\nPlease Select an Item Using Product Number: ");
                int prodNumber = _input.GetInput();
                int row = prodNumber / 10 - 1;
                int col = prodNumber % 10 - 1;
                if (row >= 0 && row <= Enum.GetNames(typeof(CategoryItem)).Length && col >= 0 && col < 3)
                {
                    if (AddToCart(row, col))
                    {
                        break;
                    }
                }
                else
                {
                    _screenDisplay.DisplayMessage("\nPlease Enter a Valid Product Number.");
                }
            }
        }

        private bool AddToCart(int row, int col)
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
                        Console.Clear();
                        _screenDisplay.DisplayMessage($"\nYou've added {selectedQuantity} {unit}{s} of {selectedItem.Name} to the cart.");
                        if (!_cart.ContainsKey(selectedItem))
                        {
                            _cart[selectedItem] = selectedQuantity;
                        }
                        else
                        {
                            _cart[selectedItem] += selectedQuantity;
                        }

                        UpdateQuantity(row, col, selectedQuantity);
                        return true;
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
            return false;
        }

    }
}