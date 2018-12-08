using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW2
{
    class Program
    {
        static void Main(string[] args)
        {
            IpSearcher ip = new IpSearcher();
            Console.WriteLine( ip.SearchIp("asdasdasd asdasdasdasdsd 192.123.223.312 aasdasdasd asd"));
            Console.ReadKey();
        }
    }
}
