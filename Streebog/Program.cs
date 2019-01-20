using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streebog
{
    class Program
    {
        static void Main(string[] args)
        {
            string hash = Streebog.GetHashCode("210987654321098765432109876543210987654321098765432109876543210", 256);
            Console.WriteLine(hash);
        }
    }
}
