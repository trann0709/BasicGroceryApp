using System;

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
    }
}