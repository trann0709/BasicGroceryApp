using System;

namespace BasicGroceryApp
{
    class BeverageProd : Product
    {
        public BeverageProd(string name, int quantity, int price)
            : base(name, quantity, price, CategoryItem.beverages)
        {

        }

        public override void DisplayMessage(Product prod, int count)
        {
            string s = count > 1 ? "s" : "";
            Console.WriteLine($"{count} pack{s} of {prod.Name}: ${count * prod.Price}");
        }
    }
}