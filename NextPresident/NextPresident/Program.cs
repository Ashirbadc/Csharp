using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextPresident
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hillary, Donald, Ted and Ben are running for the Presidency fo the US. ");
            Console.WriteLine("Who do you think will win the next Election?");
            String input = (Console.ReadLine()).ToLower();

            switch (input)
            {
                case "hillary":
                Console.WriteLine("I'm sure, she will make up a great president!!");
                break;

                case "donald":
                Console.WriteLine("It will have a terrible consequences!!");
                break;

                case "ted":
                    Console.WriteLine("I think he can do with it");
                break;

                case "ben":
                    Console.WriteLine("Sorry I don't have a clue");
                break;

                default:
                   Console.WriteLine ("Sorry I don't undestand");
                break;

             

                
            }

            Console.ReadLine();
        }



    }

            


    
}
