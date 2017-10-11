using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class ShopStorage : ItemStorage<Item>
    {
        Item removeItem;

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
            try { if (name[0] == '1') { } } catch { return new List<Item>(); }
            var returnList =
                from t in InternalStorage
                where t.name.ToLower().Contains(name.ToLower())
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
            try { if (name[0] == '1') { } } catch { return new List<Item>(); }
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
            try { if (name[0] == '1') { } } catch { return new List<Item>(); }
            try { if (category[0] == '1') { } } catch { return new List<Item>(); }
            var returnList =
                from t in InternalStorage
                where t.category.ToLower() == category.ToLower()
                where t.name.ToLower().Contains(name.ToLower())
                select t;
            return returnList.ToList();
        }

        public List<Item> SearchCheaperWithinCategory(double price, String category)
        {
            try { if (category[0] == '1') { } } catch { return new List<Item>(); }
            var returnList =
                from t in InternalStorage
                where t.category.ToLower() == category.ToLower()
                where t.price <= price
                select t;
            return returnList.ToList();
        }

        public List<Item> SearchExpensiveWithinCategory(double price, String category)
        {
            try { if (category[0] == '1') { } } catch { return new List<Item>(); }
            var returnList =
                from t in InternalStorage
                where t.category.ToLower() == category.ToLower()
                where t.price >= price
                select t;
            return returnList.ToList();
        }

        public bool Find(String articleNumber)
        {
            var list =
                from t in InternalStorage
                where t.articleNumber == articleNumber
                select t;
            try { removeItem = list.ToList()[0]; } catch { return false; }
            return true;
        }

        public Item Remove(String articleNumber)
        {
            InternalStorage.Remove(removeItem);
            return removeItem;
        }
    }
}
