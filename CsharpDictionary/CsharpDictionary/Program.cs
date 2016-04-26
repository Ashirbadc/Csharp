using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

                ////declare the collection of coding languages
                Dictionary<string, string> codingLanguages = new Dictionary<string, string>();
                string answer;

                //declaring the key & value
                codingLanguages.Add("Python", "Back end programming language is a open source programming language");
                codingLanguages.Add("C#", "Back end programing language for better programming experience");
                codingLanguages.Add("Javascript", "Popular Frontend programming language");

                Console.WriteLine("coding language dictionary: \r\n type K to search,\r\n type D for the description,\r\n type C to count the list,\r\n type X to exit");

                //get userinput
                char response = Convert.ToChar(Console.ReadLine().ToUpper());

                    do
                    {
                        switch (response)
                        {
                            case 'K':
                                //input to search for the type of language
                                Console.WriteLine("type of language if you would like to search for");
                                answer = Console.ReadLine();

                                if (codingLanguages.ContainsKey(answer))
                                {
                                    Console.WriteLine(answer + " is on the dictionary");
                                }
                                else
                                {
                                    Console.WriteLine(answer + " is not in the dictionary");

                                }
                                break;

                            case 'D':
                                //input for description
                                Console.WriteLine("type for the description");
                                answer = Console.ReadLine();

                                if (codingLanguages.ContainsValue(answer))
                                {
                                    Console.WriteLine(answer + " is in the dictionary");

                                }
                                else
                                {
                                    Console.WriteLine(answer + " is not in the dictionary");

                                }
                                break;

                            case 'C':
                                //get total number of items in the dictionary
                                int totalitems = codingLanguages.Count();
                                Console.WriteLine("there are " + totalitems + " items in the dictionary");
                                break;

                            default:
                                break;
                        }
                        // get userinput to test while loop
                        Console.WriteLine("Please make another selection: ");
                        response = Convert.ToChar(Console.ReadLine().ToUpper());

                 }
                    while (response != 'X');
                    
                    }//end of dictionary program

            }//end of program
        }//end of namespace
