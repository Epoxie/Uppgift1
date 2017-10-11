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
        ShopStorage shopStorage = new ShopStorage();

        public Menu()
        {
            for (int i = 0; i < 3; i++)
            {
                shopStorage.Add(new Item ("123", "Tomato", "Food", 12.55));
            }
            for (int i = 0; i < 2; i++)
            {
                shopStorage.Add(new Item("420", "Hammer", "Tool", 59.99));
            }
            for (int i = 0; i < 5; i++)
            {
                shopStorage.Add(new Item("155", "Banana", "Food", 14.55));
            }
            for (int i = 0; i < 4; i++)
            {
                shopStorage.Add(new Item("333", "Fisk", "Food", 12.55));
            }
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Choose what to do by typing a number:\n" +
                                   "1. Search for items\n" +
                                   "2. View the stock\n" +
                                   "3. View the cart\n" +
                                   "4. Checkout\n" +
                                   "0. Exit program");
                input = Console.ReadLine(); // reads the whole line
                Console.Clear(); // this is the end of the page currently
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
        }

        private void ShowStock()
        {
            while (true)
            {
                Console.WriteLine("Wanna sort in any way?\n" +
                                  "1. See the stock sorted by price\n" +
                                  "2. See the stock sorted by name\n" +
                                  "3. See the stock sorted by price and name\n" +
                                  "4. See the stock sorted by price, grouped by category\n" +
                                  "0. Back\n");
                input = Console.ReadLine(); // reads the whole line
                Console.Clear(); // this is the end of the page currently  // repeat for every menu, yay ugly code
                if (input[0] == '0')
                    return;
                else
                {
                    switch (input[0])
                    {
                        case '1':
                            PrintList(shopStorage.SortByPrice());
                            Console.ReadKey();
                            break;
                        case '2':
                            PrintList(shopStorage.SortByName());
                            Console.ReadKey();
                            break;
                        case '3':
                            PrintList(shopStorage.SortByPriceAndName());
                            Console.ReadKey();
                            break;
                        case '4':
                            Console.WriteLine("Lol, not implemented yet."); // <------ IMPLEMENT
                            Console.ReadKey();
                            break;
                        default:
                            break;
                    }
                }
                Console.Clear();
            }
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

        private void PrintList(List<Item> printList)
        {
            Console.WriteLine("Name\tPrice\tCatgry\tArticle Number");
            foreach (Item item in printList)
            {
                Console.WriteLine(item.name + "\t" + item.price + "\t" + item.category + "\t" + item.articleNumber);
            }
        }

        /*
        private bool CheckInput(String input)
        {
            if (input == "")
                return false;
            if (input[0] == '0' || input[0] == '1' || input[0] == '2' || input[0] == '3' || input[0] == '4' || input[0] == '5' || input[0] == '6' || input[0] == '7' || input[0] == '8' || input[0] == '9')
                return true;
            else
                return false;
        }
        */
    }
}
