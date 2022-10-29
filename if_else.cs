using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int theAge;

            Console.Write("Enter your age : ");
            theAge = Convert.ToInt32(Console.ReadLine());

            if (theAge <= 13)
            {
                Console.WriteLine("You are still young");
            }
            else if (theAge <= 20)
            {
                Console.Write("You are teenager");
            }
            else if (theAge <= 30) 
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("Wewe ni mzee");
            }
        }
    }
}
