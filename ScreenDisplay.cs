using System;
using System.Collections.Generic;

namespace BasicGroceryApp
{
    class ScreenDisplay
    {
        public ScreenDisplay()
        {

        }

        public void WelcomeMessage()
        {
            Console.WriteLine(@"
.-----------------------------------------.
|    _____                                |
|  /  ,___)  /\/\   __ _ ____ _____       |
| |  |  ___ /    \ / _` | |)_) | |        |
| |  |__| |/ /\/\ | (_| | |\ \ | |   _    |
|  \______|\/    \/\__,_|_| \_\|_|  (_)   |  
|                                         |                                   
'-----------------------------------------'");
        }


        public void MenuSelection()
        {
            Console.Write(@"
.-----.----------------------------.
|Press|       Action               |
|-----|----------------------------|
|  1  |    Browse Availability     |
|  2  |    View Cart               |
|  3  |    Make A Payment          |
|  4  |    Quit                    |
'-----'----------------------------'"
);
        }


        public void MenuSelection(Product[][] items)
        {
            Console.WriteLine("|{4}\t\t|{0} |{1}\t|{2}\t\t|{3}\t\t|", "Product Number", "Quantity", "Name", "Price", "Type");
            Console.WriteLine("---------------------------------------------------------------------------------");
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items[i].Length; j++)
                {
                    if (items[i][j] != null)
                    {
                        string unit = items[i][j].Category == "beverages" ? "pack" : "pound";
                        string s = items[i][j].Quantity > 1 ? "s" : "";

                        Console.WriteLine("|{5}   \t|{0}{1} \t\t|{2} {6}{7} \t|{3}   \t|${4}/{6}\t|", i + 1, j + 1, items[i][j].Quantity, items[i][j].Name, items[i][j].Price, items[i][j].Category, unit, s);
                    }
                }
            }
        }


        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }



    }
}
