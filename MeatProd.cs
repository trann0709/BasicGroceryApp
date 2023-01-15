using System;

namespace BasicGroceryApp
{

    class MeatProd : Product
    {
        public MeatProd(string name, int quantity, int price)
            : base(name, quantity, price, CategoryItem.meat)
        {

        }

        public override void DisplayMessage(Product prod, int count)
        {
            string s = count > 1 ? "s" : "";
            Console.WriteLine($"{count} pound{s} of {prod.Name}");
        }
    }
}