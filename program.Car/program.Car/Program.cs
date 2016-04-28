using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Car
{
    class Car
    {

        //blueprint fot the car class        
        public string model;
        public string make;
        public int price;
        public Boolean sold;
        public static int numberOfCars;
        public static int totalValueSold = 0;
        public static int totalValueInStock = 0;

        public void AddCar(string model, string make, int price)
        {
            //object created
            this.model = model;
            this.make = make;
            this.price = price;
            this.sold = false;
            Car.numberOfCars++;
            Car.totalValueInStock += price;
        }

        public void ListCar()
        {
            //display details for an individual car
            Console.WriteLine("The details of this car are: ");
            Console.Write("Make and model: {0} {1}, price: £{2:N0}.", make, model, price);  //:N0 formats the number
            if (sold)
            {
                Console.WriteLine("This car has been sold.");
            }
            else
            {
                Console.WriteLine("This car has not yet been sold.");
            }
            Console.WriteLine();
        }

        //record the sale of a car
        public void Sold(bool isSold, int price)
        {
            this.sold = isSold;
            this.price = price;
            //adjust the number of cars

            if(isSold)
            {
                Car.totalValueSold += price;
                Car.totalValueInStock -= price;
                Car.numberOfCars--;
            }
            else
            {
                Car.totalValueSold -= price;
                Car.totalValueInStock += price;
                Car.numberOfCars++;
            }
           
        }
        

        //list all the cars
        public static void DisplayAllCars(List<Car> allCars)
        {
            

            foreach (Car item in allCars)
            {
                Console.WriteLine("the details of this car is: ");
                Console.WriteLine("Make and Model: {0} {1}, price: £{2:N0}.", item.model, item.make, item.price);

                if (item.sold)
                {
                    Console.WriteLine("This car has been sold.");
                    
                }
                else
                {
                    Console.WriteLine("This car is unsold.");
                    

                }
                
            }
            Console.WriteLine("The total value of cars sold is: £{0:N0}", totalValueSold);
            Console.WriteLine("The total value of cars still in stock is: £{0:N0}", totalValueInStock);
            Console.WriteLine();

        }//end display cars
    }//end car class


        class Program
        {
            public static void Main(string[] args)
            {

            Car.numberOfCars = 0;
            // Declaring the objects
            List<Car> carslist = new List<Car>();


                Car myCar1 = new Car();
                myCar1.AddCar("Rolls Royce", "Phantom", 250000);
                carslist.Add(myCar1);

                Car myCar2 = new Car();
                myCar2.AddCar("Ferrari", "Spider", 200000);
                carslist.Add(myCar2);

                Car myCar3 = new Car();
                myCar3.AddCar("Mustang", "Shelby", 100000);
                carslist.Add(myCar3);

            
            //display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine();
            Car.DisplayAllCars(carslist);

            //record the sale of a car
            myCar2.Sold(true, 200000);
            //display cars data
            Car.DisplayAllCars(carslist);
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.ReadLine();
            
        }//end main
        }//end program class
}//end namespace
