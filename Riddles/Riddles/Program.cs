using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riddles
{
    class Program
    {
        static void Main(string[] args)
        {
            //first riddle
            Console.WriteLine("Can you solve this riddle?");               
            Console.WriteLine("What tastes better than it smells?");
            String response = (Console.ReadLine()).ToLower();

            // executing a while loop
            while ((response != "a tongue") && (response != "i give up"))
                {

                    Console.WriteLine("Try again or say 'I give up'");
                    response = Console.ReadLine();
                }

            // if and else statement
            if (response == "a tongue")
            {
                Console.WriteLine("Your are absolutely right!!");
            }
            else
            {
                Console.WriteLine("The answer is a tongue!");
            }
             

            //second riddle
            //executing the do while loop
            do
            {
                Console.WriteLine("What two things you can never eat for breakfast?");
                response = Console.ReadLine().ToLower();
            }
            while ((response != "lunch and dinner") && (response != "i give up"));


            if (response == "lunch and dinner")
            {
                Console.WriteLine("you're absolutely right!!");
            }
            else
            {
                Console.WriteLine("the answer is lunch and dinner!");

            }




                }//end main
            }//end program class


        }   //end namespace
        


