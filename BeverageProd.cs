using System;

namespace BasicGroceryApp
{
    class BeverageProd : Product
    {
        public BeverageProd(string name, int quantity, int price)
            : base(name, quantity, price, CategoryItem.beverages)
        {

        }
    }
}