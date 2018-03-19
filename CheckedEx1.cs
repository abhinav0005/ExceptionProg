using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class CheckedEx1
    {
        static void Main(string[] args)
        {
            int i = int.MinValue;
            int j = i + 1;
            Console.WriteLine(j);
            Console.Read();
        }
    }
}
