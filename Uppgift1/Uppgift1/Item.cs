using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class Item : IEquatable<Item>, IComparable<Item>
    {
        String articleNumber;
        String name;
        String category;
        double price;

        public Item(String articleNumber, String name, String category, double price)
        {
            this.articleNumber = articleNumber;
            this.name = name;
            this.category = category;
            this.price = price;
        }

        public int CompareTo(Item other)
        {
            if (other == null) return 1;

            if (this.price > other.price)
                return -1;
            if (this.price == other.price)
                return 0;
            else // this will be true (this.price < other.price)
                return 1;
        }

        public bool Equals(Item other)
        {
            return (this.articleNumber == other.articleNumber);
        }
    }
}
