using System;
using System.Collections.Generic;

namespace BasicGroceryApp
{
    abstract class Product
    {
        // Fields
        private string _name;
        private int _quantity;
        private int _price;
        private readonly CategoryItem _category;

        // Properties 
        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Price
        {
            get
            {
                return _price;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }

        public string Category
        {
            get
            {
                return _category.ToString();
            }
        }

        // Constructor
        public Product(string name, int quantity, int price, CategoryItem category)
        {
            this._name = name;
            this._category = category;

            if (quantity >= 0)
            {
                this._quantity = quantity;
            }
            else
            {
                Console.WriteLine($"Invalid quantity for {name}");
            }

            if (price > 0)
            {
                this._price = price;
            }
            else
            {
                Console.WriteLine($"Invalid price tag for {name}");
            }
        }

        public abstract void DisplayMessage(Product prod, int count);
    }

}
