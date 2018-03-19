using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class DivideByZeroEx
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 10;
                int y = 0;
                int z = x / y;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("continue.....");
            Console.Read();
            
        }
    }
}
