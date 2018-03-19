using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class ExceptionHandlingEx2
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 10;
                int y = 0;
                int z = x / y;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Exception Handle");
            }
            Console.WriteLine("End....");
            Console.WriteLine("=====================");
            try
            {
                int i = 5;
                int y = 0;
                int z = i / y;
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.Read();
        }
    }
}
