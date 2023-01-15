using System;

namespace BasicGroceryApp
{

    class VeggieProd : Product
    {
        public VeggieProd(string name, int quantity, int price)
            : base(name, quantity, price, CategoryItem.vegetables)
        {

        }

        public override void DisplayMessage(Product prod, int count)
        {
            string s = count > 1 ? "s" : "";
            Console.WriteLine($"{count} pound{s} of {prod.Name}");
        }
    }
}