using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You can vote!! Hurray");
            }else
            {
                Console.WriteLine("You are still a child, go home and be a child");
            }
             
         
        }
    }
}
