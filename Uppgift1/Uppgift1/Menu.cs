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

        public Menu()
        {
            // default
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Choose what to do by typing a number: " +
                                   "1. Search for items\n" +
                                   "2. View the stock\n" +
                                   "3. View the cart\n" +
                                   "4. Checkout\n" +
                                   "0. Exit program");
                input = Console.ReadLine(); // reads the whole line
                Console.Clear(); // this is the end of the page currently
                if (CheckInput(input)) // checks input so it's all good
                {
                    Console.Clear();
                    if (input[0] == '0')
                        Environment.Exit(0); // exit the application
                    else
                    {
                        switch (input[0])
                        {
                            case '1':
                                ShowStock();
                                break;
                            case '2':
                                Search();
                                break;
                            case '3':
                                Cart();
                                break;
                            case '4':
                                Checkout();
                                break;
                            default:
                                break;
                        }
                    }
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

        private void ShowStock()
        {
            // do the thing
        }

        private void Search()
        {
            // things
        }

        private void Cart()
        {
            // show the cart
        }

        private void Checkout()
        {
            // checkout
        }
    }
}
