using System;

namespace BasicGroceryApp
{

    class VeggieProd : Product
    {
        public VeggieProd(string name, int quantity, int price)
            : base(name, quantity, price, CategoryItem.vegetables)
        {

        }
    }
}