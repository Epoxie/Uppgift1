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
        ShoppingCart shoppingCart = new ShoppingCart();

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
                                   "3. Go to cart\n" +
                                   "0. Exit program");
                input = Console.ReadLine(); // reads the whole line
                if (input == "")
                    input = "k";
                Console.Clear(); // this is the end of the page currently
                if (input[0] == '0')
                    Environment.Exit(0); // exit the application
                else
                {
                    switch (input[0])
                    {
                        case '1':
                            Search();
                            break;
                        case '2':
                            ShowStock();
                            break;
                        case '3':
                            Cart();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void Search()
        {
            while (true)
            {
                Console.WriteLine("Choose Search Filter/function:\n" +
                                   "1. Search Items by name\n" +
                                   "2. Search Items cheaper than input\n" +
                                   "3. Search Items more expensive than input\n" +
                                   "4. Search Items by price and by name\n" +
                                   "5. Search Items by name and category\n" +
                                   "6. Search Items cheaper than input and by category\n" +
                                   "7. Search Items more expensive than input and by category\n" +
                                   "0. Back");
                input = Console.ReadLine(); // reads the whole line
                if (input == "")
                    input = "k";
                Console.Clear(); // this is the end of the page currently
                Console.WriteLine("Search:");
                if (input[0] == '0')
                    return;
                else
                {
                    double tempDouble;
                    String tempString;
                    String tempString2;
                    bool tempBool = false;
                    switch (input[0])
                    {
                        case '1':
                            PrintList(shopStorage.SearchByName(Console.ReadLine()));
                            break;
                        case '2':
                            try
                            {
                                tempDouble = Convert.ToDouble(Console.ReadLine());
                            }
                            catch { break; }
                            PrintList(shopStorage.SearchCheaperItems(tempDouble));
                            break;
                        case '3':
                            try
                            {
                                tempDouble = Convert.ToDouble(Console.ReadLine());
                            }
                            catch { break; }
                            PrintList(shopStorage.SearchExpensiveItems(tempDouble));
                            break;
                        case '4':
                            Console.WriteLine("Name:");
                            tempString = Console.ReadLine();
                            Console.WriteLine("Price:");
                            try
                            {
                                tempDouble = Convert.ToDouble(Console.ReadLine());
                            }
                            catch { break; }
                            Console.WriteLine("Wanna see options cheaper than " + tempDouble + "? (y/n)");
                            try
                            {
                                if (Console.ReadLine()[0] == 'y')
                                    tempBool = true;
                            }
                            catch { }
                            PrintList(shopStorage.SearchWithOptions(tempString, tempDouble, tempBool));
                            break;
                        case '5':
                            Console.WriteLine("Name:");
                            tempString = Console.ReadLine();
                            Console.WriteLine("Category:");
                            tempString2 = Console.ReadLine();
                            PrintList(shopStorage.SearchNameWithinCategory(tempString, tempString2));
                            break;
                        case '6':
                            Console.WriteLine("Price:");
                            try
                            {
                                tempDouble = Convert.ToDouble(Console.ReadLine());
                            }
                            catch { break; }
                            Console.WriteLine("Category:");
                            tempString = Console.ReadLine();
                            PrintList(shopStorage.SearchCheaperWithinCategory(tempDouble, tempString));
                            break;
                        case '7':
                            Console.WriteLine("Price:");
                            try
                            {
                                tempDouble = Convert.ToDouble(Console.ReadLine());
                            }
                            catch { break; }
                            Console.WriteLine("Category:");
                            tempString = Console.ReadLine();
                            PrintList(shopStorage.SearchExpensiveWithinCategory(tempDouble, tempString));
                            break;
                        default:
                            break;
                    }
                }
                Console.ReadKey();
                Console.Clear();
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
                                  "0. Back");
                input = Console.ReadLine(); // reads the whole line
                if (input == "")
                    input = "k";
                Console.Clear(); // this is the end of the page currently  // repeat for every menu, yay ugly code
                if (input[0] == '0')
                    return;
                else
                {
                    switch (input[0])
                    {
                        case '1':
                            PrintList(shopStorage.SortByPrice());
                            break;
                        case '2':
                            PrintList(shopStorage.SortByName());
                            break;
                        case '3':
                            PrintList(shopStorage.SortByPriceAndName());
                            break;
                        case '4':
                            Console.WriteLine("Lol, not implemented yet."); // <------ IMPLEMENT
                            break;
                        default:
                            break;
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void Cart()
        {
            while (true)
            {
                Console.WriteLine("Choose what to do by typing a number:\n" +
                                   "1. View money on card\n" +
                                   "2. View Items in cart\n" +
                                   "3. Add Item to cart by article number\n" +
                                   "4. Checkout\n" +
                                   "0. Back");
                input = Console.ReadLine(); // reads the whole line
                if (input == "")
                    input = "k";
                Console.Clear(); // this is the end of the page currently
                if (input[0] == '0')
                    break;
                else
                {
                    switch (input[0])
                    {
                        case '1':
                            Console.WriteLine("You have " + shoppingCart.money + " dollares on your card");
                            break;
                        case '2':
                            PrintList(shoppingCart.GetAllItems());
                            break;
                        case '3':
                            Console.WriteLine("Article Number:");
                            String tempString = Console.ReadLine();
                            if (shopStorage.Find(tempString))
                            {
                                Item tempItem = shopStorage.Remove(tempString);
                                shoppingCart.Add(tempItem);
                                Console.WriteLine("Success!");
                            }
                            else
                                Console.WriteLine("Fail :(");
                            break;
                        case '4':
                            Checkout();
                            break;
                        default:
                            break;
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void PrintList(List<Item> printList)
        {
            Console.WriteLine("Name\tPrice\tCatgry\tArticle Number");
            foreach (Item item in printList)
            {
                Console.WriteLine(item.name + "\t" + item.price + "\t" + item.category + "\t" + item.articleNumber);
            }
        }

        private void Checkout()
        {
            double cost = 0.0;
            foreach (Item item in shoppingCart)
                cost += item.price;
            if (cost < shoppingCart.money)
            {
                Console.WriteLine("You bought some items!");
                PrintList(shoppingCart.GetAllItems());
                shoppingCart.money -= cost;
                shoppingCart.Clear();
            }
            else
                Console.WriteLine("You can't afford that!");
        }
    }
}
