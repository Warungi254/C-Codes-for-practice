using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a gading system for three units and grade your average   

            double unitOne, unitTwo, unitThree, avg;

            Console.Write("Enter your marks for unit One : ");
            unitOne = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your mark for unit Two : ");
            unitTwo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your mark for unit Three : ");
            unitThree = Convert.ToDouble(Console.ReadLine());
            
            avg = (unitOne + unitTwo + unitThree) / 3;
            Console.WriteLine("Your average mark is {0}",avg);

            if (avg <= 40 && avg < 50)
            {
                Console.WriteLine("Wewe ni dwanzi");
            }
            else if(avg >= 50 && avg <=60 )
            {
                Console.WriteLine("You are doing great keep it up");
            }
            else if(avg >=60 && avg <= 70)
            {
                Console.WriteLine("smart asss");
            }
            else if(avg >= 70 && avg <=80)
            {
                Console.WriteLine("The sky is the limit baby");
            }
            else if(avg >= 80 && avg <= 90)
            {
                Console.WriteLine("Good job");
            }
            else
            {
                Console.WriteLine("Do something with your life");
            }
        }
    }
}
