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
            codingLanguages.Add("Java", "Back end programming language for advanced programming");
            codingLanguages.Add("C#", "Back end programing language for better programming experience");
            codingLanguages.Add("Javascript", "Popular Frontend programming language");

            Console.WriteLine("coding language dictionary: \r\n type K to search,\r\n type D for the description,\r\n type C to count the list,\r\n type X to exit");

            //get userinput
            char response = Convert.ToChar(Console.ReadLine().ToUpper());

            do

            {
              switch(response)
                {
                    case "K":
                        Console.WriteLine("type the name if you would like to search for");
                        answer = Console.ReadLine();
                        break;


                        
                        
                        break;



                }




            }
        }
    }
}
