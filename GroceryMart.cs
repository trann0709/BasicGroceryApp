using System;
using System.Collections.Generic;

namespace BasicGroceryApp
{
    class GroceryMart
    {
        // Fields
        private Dictionary<string, HashSet<string>> _allItems;

        // Properties
        public Dictionary<string, HashSet<string>> AllItems
        {
            get
            {
                return _allItems;
            }
        }

        // Constructors 
        public GroceryMart()
        {
            this._allItems = new Dictionary<string, HashSet<string>>();
        }

        public void Add(Product prod)
        {
            if (!this._allItems.ContainsKey(prod.Category))
            {
                this._allItems[prod.Category] = new HashSet<string>();
            }
            this._allItems[prod.Category].Add(prod.Name);
        }

        public void Display()
        {
            foreach (var item in this._allItems)
            {
                Console.Write(item.Key + ": ");
                foreach (var p in item.Value)
                {
                    Console.Write(p + ", ");
                }
                Console.WriteLine();
            }

        }

    }
}