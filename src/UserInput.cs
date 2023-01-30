using System;

namespace BasicGroceryApp
{
    class UserInput
    {
        public UserInput()
        {

        }

        public int GetInput()
        {
            string input = Console.ReadLine();
            try
            {
                int value = Int32.Parse(input);
                if (value > 0) return value;
                else return -1;
            }
            catch (FormatException)
            {
                return -1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
        }
    }
}