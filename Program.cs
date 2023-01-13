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
            GroceryMart groceryMart = new GroceryMart();
            groceryMart.Add(new MeatProd("beef", 2, 5));
            groceryMart.Add(new MeatProd("chicken", 4, 6));
            groceryMart.Add(new BeverageProd("coffee", 1, 4));
            groceryMart.Display();
        }
    }
}
