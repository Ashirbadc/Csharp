using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)

        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 100);
            int UserGuess = 0;
            UserGuess = Convert.ToInt32(Console.Read());
            // tell the user about the program
            Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is?");
            Console.ReadLine();

            if (UserGuess < numberToGuess)
            {
                Console.WriteLine("No, the number I am thinking of is higher than " + UserGuess + " .  Can you guess what it is?");
            }

            else if (UserGuess == numberToGuess)
            {
                Console.WriteLine("Well done you've guessed it right " + UserGuess);
            }

            else {
                Console.WriteLine("No, the number I am thinking of is lower than " + UserGuess + " .  Can you guess what it is?");
                Console.ReadLine();
            }



        }



    }
   
       
          
           }

   

