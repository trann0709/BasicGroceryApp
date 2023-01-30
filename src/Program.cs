using System;
namespace BasicGroceryApp
{

    enum CategoryItem
    {
        meat, vegetables, beverages
    }

    class Program
    {
        static void Main(string[] args)
        {
            int count = Enum.GetNames(typeof(CategoryItem)).Length;
            Product[][] allProducts = new Product[count][];
            for (int i = 0; i < count; i++)
            {
                allProducts[i] = new Product[3];
            }

            allProducts[0][0] = new MeatProd("Beef", 4, 5);
            allProducts[0][1] = new MeatProd("Chicken", 3, 2);
            allProducts[0][2] = new MeatProd("Pork", 0, 3);

            allProducts[1][0] = new BeverageProd("Sprite", 10, 5);
            allProducts[1][1] = new BeverageProd("Fanta", 1, 5);

            allProducts[2][0] = new VeggieProd("Carrot", 5, 2);
            allProducts[2][1] = new VeggieProd("Potato", 0, 2);
            allProducts[2][2] = new VeggieProd("Lettuce", 2, 4);



            GroceryMart groceryMart = new GroceryMart(allProducts);
            groceryMart.TurnOn();
        }
    }
}
