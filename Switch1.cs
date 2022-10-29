using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch1
{
    class Program
    {
        static void Main(string[] args)
        {
            int points;

            Console.Write("Enter the point you got : ");
            points = Convert.ToInt32(Console.ReadLine());

            switch (points)
            {
                case 4:Console.WriteLine("You got a Distinction");
                    break;
                case 3:Console.WriteLine("You got a Pass");
                    break;
                case 2:Console.WriteLine("You got a Fail");
                    break;
                case 1:Console.WriteLine("You failed kabisa");
                    break;
                default:Console.WriteLine("Do something with your Life");
                    break;
            }
       
        }
    }
}
