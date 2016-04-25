using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerForDwarfs
{
    class Program
    {
        static void Main(string[] args)
   
        {
            string[] arrays = new string[7];// declaring array
            // storing values in array elements
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            
            //retreiving value using for loop
            for(int i = 0; i < sevenDwarves.Length; i++)
                {
                Console.WriteLine("Here is your dinner " + sevenDwarves[i] + ".");
                }

            //retreiving value using foreach loop
            foreach (string name in sevenDwarves)
            {
                Console.WriteLine("Here is a drink for you " + name + ".");
            }

            Console.ReadLine();

        }//END OF MAIN

    }//END OF CLASS PROGRAM
}//END OF NAMESPACE
