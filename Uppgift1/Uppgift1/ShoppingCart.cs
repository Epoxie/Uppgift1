using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class ShoppingCart : ItemStorage<Item>
    {
        public double money { get; set; }

        public ShoppingCart()
        {
            money = 100.00;
        }
    }
}
