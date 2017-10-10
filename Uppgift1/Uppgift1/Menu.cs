using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class Menu
    {
        String input = "";
        Page CurrentPage;

        public Menu()
        {
            CurrentPage = new Page("1. Search for items\n" +
                                   "2. View the stock\n" +
                                   "3. View the cart\n" +
                                   "4. Checkout");
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Choose what to do by typing a number:"); // writes out the first line
                CurrentPage.WritePage(); // writes out the meat in the menu
                Console.WriteLine("0. Exit program"); // writes the ending line
                input = Console.ReadLine();
                Console.Clear();
                if (CheckInput(input))
                {
                    if (input[0] == '0')
                        Environment.Exit(0);
                    else
                        CurrentPage.Action(input[0]);
                }
                else
                    Console.WriteLine("Wrong input, please type one of the numbers in the list.");
            }
        }

        private bool CheckInput(String input)
        {
            if (input == "")
                return false;
            if (input[0] == '0' || input[0] == '1' || input[0] == '2' || input[0] == '3' || input[0] == '4' || input[0] == '5' || input[0] == '6' || input[0] == '7' || input[0] == '8' || input[0] == '9')
                return true;
            else
                return false;
        }
    }
}
