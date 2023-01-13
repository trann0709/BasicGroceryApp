using System;

namespace BasicGroceryApp
{

    enum CategoryItem
    {
        meat, vegetables, fruits, beverages, snacks, diary
    }

    class Program
    {
        static void Main(string[] args)
        {
            MeatProd beef = new MeatProd("beef", 2, 5);
        }
    }
}
