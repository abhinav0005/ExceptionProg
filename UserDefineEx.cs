using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class invalidAgeException : Exception
    {
        public invalidAgeException(string msg)
           // : base(msg)
        {
            Console.WriteLine(msg);
        }
    }
    public class UserDefineEx 
    { 
        public static void validate(int age)
        {
            if (age < 18)
            {
                throw new invalidAgeException("Age must be greater than 18");
            }
               
        }
        static void Main(string[] args)
        {
            try
            {
                validate(15);
            }
            catch(invalidAgeException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Next user...");
            Console.Read();
        }
    }
}
