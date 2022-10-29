using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            //10)	Write a program that accepts the age of a person, if the person is 18 and above, it should print You can vote. otherwise it should print You are too young to vote.

            int age;

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18) {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("You are too young to vote");
            }
        }
    }
}
