using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class CheckedEx2
    {
        static void Main(string[] args)
        {
            checked
            {
                int i = int.MaxValue;
                Console.WriteLine(i + 2);
                Console.Read();
            }
        }
    }
}
