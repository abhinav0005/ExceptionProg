using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class UncheckedExp
    {
        static void Main(string[] args)
        {
            unchecked
            {
                int i = int.MaxValue;
                Console.WriteLine(i + 11);
            }
            Console.Read();
        }
    }
}
