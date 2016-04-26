using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //to store the userinput
            string bookToAdd, bookToDelete;

            //collecting the list of books
            List<string> mybook = new List<string>() { "To kill the mocking bird", "C# from scratch", "Javascript from scratch", "Java from scratch" };

            //give user the instructions of choices
            Console.WriteLine("Here is my collection of book. \r\n To add press A, \r\n To delete press D,\r\n To list the book press L, \r\n To sort press S, \r\n To exit press X");
            //get user input
            char response = Convert.ToChar(Console.ReadLine().ToUpper());

            // do while the response not equall to x
            do
            {

                switch (response)
                {
                    case 'A':
                        //prompt user to add book
                        Console.WriteLine("Would you like to add a book?");
                        bookToAdd = Console.ReadLine();
                        //add the book to list in the end
                        mybook.Add(bookToAdd);
                        break;

                    case 'D':
                        //prompt user to delete book
                        Console.WriteLine("Would you will to delete the book");
                        bookToDelete = Console.ReadLine();
                        // remove the book
                        mybook.Remove(bookToDelete);
                        break;

                    case 'L':
                        //Listing all the books
                        for (int i = 0; i < mybook.Count; i++)
                        {
                            Console.WriteLine(mybook[i]);
                        }
                        break;
                    case 'S':
                        //sorting the books
                        mybook.Sort();
                        for (int i = 0; i < mybook.Count; i++)
                        {
                            Console.WriteLine(mybook[i]);
                        }
                     
                        break;

                    default:
                        break;
                }
                //give user the instructions of choices
                Console.WriteLine("What would you like to do next? \r\n To add press A, \r\n To delete press D,\r\n To list the book press L, \r\n To sort press S, \r\n To exit press X");
                // get userinput to test the while loop conditions        
                response = Convert.ToChar(Console.ReadLine().ToUpper());
            }
            //it will stop from running through the loops once user inputs X & exits
            while (response != 'X');

        




        }//END OF COLLECTION
    }//END OF PROGRAM
}//END OF NAMESPACE
