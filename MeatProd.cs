using System;

namespace BasicGroceryApp
{

    class MeatProd : Product
    {
        public MeatProd(string name, int quantity, int price)
            : base(name, quantity, price, CategoryItem.meat)
        {

        }
    }
}