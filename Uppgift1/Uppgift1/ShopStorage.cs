using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class ShopStorage : ItemStorage<Item>
    {
        public List<Item> SortByPrice()
        {
            var returnList =
                from t in InternalStorage
                orderby t.price ascending
                select t;
            return returnList.ToList();
        }

        public List<Item> SortByName()
        {
            var returnList =
                from t in InternalStorage
                orderby t.name ascending
                select t;
            return returnList.ToList();
        }

        public List<Item> SortByPriceAndName()
        {
            var returnList =
                from t in InternalStorage
                orderby t.price, t.name ascending
                select t;
            return returnList.ToList();
        }

        /*
        public List<Item> SortByPriceGroupedByCategory()
        {
            List<Item> temp = SortByPrice();
            var returnList =
                from t in temp
                group t by t.category into tgroup
                select tgroup;
            return returnList;
        }
        */

        public List<Item> SearchByName(String name)
        {
            var returnList =
                from t in InternalStorage
                where t.name.Contains(name)
                select t;
            return returnList.ToList();
        }

        public List<Item> SearchCheaperItems(double price)
        {
            var returnList =
                from t in InternalStorage
                where t.price <= price
                select t;
            return returnList.ToList();
        }

        public List<Item> SearchExpensiveItems(double price)
        {
            var returnList =
                from t in InternalStorage
                where t.price >= price
                select t;
            return returnList.ToList();
        }

        public List<Item> SearchWithOptions(String name, double price, bool cheaper)
        {
            List<Item> tempList = SearchByName(name);
            if (cheaper)
            {
                var tempList2 =
                    from t in tempList
                    where t.price <= price
                    select t;
                return tempList2.ToList();
            }
            else
            {
                var tempList2 =
                    from t in tempList
                    where t.price >= price
                    select t;
                return tempList2.ToList();
            }
        }

        public List<Item> SearchNameWithinCategory(String name, String category)
        {
            var returnList =
                from t in InternalStorage
                where t.category == category
                where t.name.Contains(name)
                select t;
            return returnList.ToList();
        }

        public List<Item> SearchCheaperWithinCategory(double price, String category)
        {
            var returnList =
                from t in InternalStorage
                where t.category == category
                where t.price <= price
                select t;
            return returnList.ToList();
        }

        public List<Item> SearchExpensiveWithinCategory(double price, String category)
        {
            var returnList =
                from t in InternalStorage
                where t.category == category
                where t.price >= price
                select t;
            return returnList.ToList();
        }
    }
}
