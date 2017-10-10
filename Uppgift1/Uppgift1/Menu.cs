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

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Choose what to do by typing a number:");
                input = Console.ReadLine();
                Console.Clear();
                if (CheckInput(input))
                {
                    switch (input[0])
                    {
                        case '1':
                            Console.WriteLine("Case 1");
                            break;
                        case '2':
                            Console.WriteLine("Case 2");
                            break;
                        case '0':
                            Environment.Exit(0);
                            break;
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
    }
}
