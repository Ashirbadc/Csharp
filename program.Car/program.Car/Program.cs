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
        private static int numberOfCars;

        
        public void AddCar(string model, string make, int price)
        {
            //object created
            this.model = model;
            this.make = make;
            this.price = price;
            this.sold = false;
            Car.numberOfCars++;

        }
        
        //record of sales
        public void SoldCar(bool isSold, int price)
        {           
            this.price = price;
            this.sold = isSold;
            //adjust the number of cars
            Car.numberOfCars--;
        }

        //list all the cars
        public static void DisplayAllCars(List<Car> allCars)
        {
            int totalValueSold = 0;
            int totalValueInStock = 0;

            foreach (Car item in allCars)
            {
                Console.WriteLine("the details of this car is: ");
                Console.WriteLine("Make and Model: {0} {1}, price: £{2:N0}.", item.model, item.make, item.price);

                if (item.sold)
                {
                    Console.WriteLine("This car has been sold.");
                    totalValueSold += item.price;
                }
                else
                {
                    Console.WriteLine("This car is unsold.");
                    totalValueInStock += item.price;

                }
                
            }
            Console.WriteLine("The total value of cars sold is: £{0:N0}", totalValueSold);
            Console.WriteLine("The total value of cars still in stock is: £{0:N0}", totalValueInStock);
            
        }//end display cars
    }//end car class


        class Program
        {
            public static void Main(string[] args)
            {
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

                Car.DisplayAllCars(carslist);

            Console.ReadLine();

        }//end main
        }//end program class
}//end namespace
