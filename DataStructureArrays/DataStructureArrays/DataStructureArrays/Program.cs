using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureArrays
{
    class Program
    {
        static void Main(string[] args)
        {   
            //prompt the user
            Console.WriteLine("Please enter 5 numbers to be averaged, pressing return after each:");
            int[] numbers = new int[5];
            //loop to get all the numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter another number:");
            }
            Console.WriteLine("thank you for entering 5 numbers");
            double total = 0D;
            //sum of numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];

            }
            //calculate the average
            double average = total / (numbers.Length);
            //give the user total
            Console.WriteLine("the average of your 5 numbers is: {0}", average);
            Console.ReadKey();

        }
    }
}
