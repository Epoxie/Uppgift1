using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class Page
    {
        String pageInfo;

        public Page(String pageInfo)
        {
            this.pageInfo = pageInfo;
        }

        public void WritePage()
        {
            Console.WriteLine(pageInfo);
        }

        public void Action(char input)
        {
            // do something
        }
    }
}
