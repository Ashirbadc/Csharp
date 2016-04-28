using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProgram
{
    class Vehicle
    {
        //blueprint fot the vehical class
        public string type;        
        public string model;
        public string make;
        public int price;
        public Boolean sold;
        public static int totalValueSold = 0;
        public static int totalValueInStock = 0;                   

        public void AddVehicle(string type, string make, string model, int price)
        {
            this.type = type;
            this.model = model;
            this.make = make;            
            this.price = price;
            this.sold = false;
            totalValueInStock += price;
        }
        public void DisplayOneVehicle()
        {
            //display details for an individual car
            Console.WriteLine("The details of this vehicle is: ");
            Console.Write("Make and model: {0} {1}, price: £{2:N0}.", model, make, price);  //:N0 formats the number
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
        public void soldOneVehicle(bool isSold, int price)
        {
            this.sold = isSold;
            this.price = price;
            //adjust the number of cars
            if (isSold)
            {
                Vehicle.totalValueSold += price;
                Vehicle.totalValueInStock -= price;
            }
            else
            {
                Vehicle.totalValueSold -= price;
                Vehicle.totalValueInStock += price;

            }
                          

    }

    //list all the vehicles
    public static void DisplayAllVehicles(List<Vehicle> allVehicals)
        {
            foreach (Vehicle item in allVehicals)
            {
                Console.WriteLine("The details of this {0} are: ", item.type);
                Console.Write("Make and model: {0} {1}, price: £{2:N0}.", item.make, item.model, item.price);  //:N0 formats the number
                if (item.sold)
                {
                    Console.WriteLine("This {0} has been sold.", item.type);
                }
                else
                {
                    Console.WriteLine("This {0} is unsold.", item.type);

                }
            }         
            Console.WriteLine("The total value of vehicles sold is: £{0:N0}.", totalValueSold);
            Console.WriteLine("The total value of vehicles in stock is: £{0:N0}.", totalValueInStock);
            Console.WriteLine();
        }
    }
  
    class Car : Vehicle
    {
        public static int numberOfCars;
        public void AddCar(string model, string make, int price)
        {
            AddVehicle(type = "car", model, make, price);
            numberOfCars++;
        }
             
        //record the sale of a car
        public void Sold(bool isSold, int price)
        {
            soldOneVehicle(isSold, price);
            //adjust the number of cars
            numberOfCars--;
        }
       
    }

    class Motorcycle : Vehicle
    {
        public static int numberOfBikes;

        public void AddBike(string model, string make, int price)
        {
            AddVehicle(type = "motorbike", model, make, price);            
            numberOfBikes++;
        }
             
        //record the sale of a motorbike
        public void Sold(bool isSold, int price)
        {
            soldOneVehicle(isSold, price);
            //adjust the number of bikes
            numberOfBikes--;
        }
             
    }

class Program
{
    static void Main(string[] args)
    {
        Car.numberOfCars = 0;
        Motorcycle.numberOfBikes = 0;

        // Declaring the objects
        List<Vehicle> allVehicles = new List<Vehicle>();

        //add vehicals
        Car myCar1 = new Car();
        myCar1.AddCar("Rolls Royce", "Phantom", 250000);
        allVehicles.Add(myCar1);

        Car myCar2 = new Car();
        myCar2.AddCar("Ferrari", "Spider", 200000);
        allVehicles.Add(myCar2);

        Car myCar3 = new Car();
        myCar3.AddCar("Mustang", "Shelby", 100000);
        allVehicles.Add(myCar3);

        Motorcycle myBike1 = new Motorcycle();
        myBike1.AddBike("Harley Davidson", "Roadster", 10000);
        allVehicles.Add(myBike1);

        Motorcycle myBike2 = new Motorcycle();
        myBike2.AddBike("Kawasaki", "Ninja", 8000);
        allVehicles.Add(myBike2);

        Motorcycle myBike3 = new Motorcycle();
        myBike3.AddBike("Ducati", "Monster", 15000);
        allVehicles.Add(myBike3);

         //display car data
         Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
        //display motorbikes data
        Console.WriteLine("Total number of bikes in stock is: {0}", Motorcycle.numberOfBikes);
        Console.WriteLine();
        Vehicle.DisplayAllVehicles(allVehicles);

        //record the sale of a car
        myCar2.Sold(true, 200000);
        myBike1.Sold(true, 10000);

        //display vehical data
        Vehicle.DisplayAllVehicles(allVehicles);
        Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
        Console.ReadLine();
    }
}
}
 
  

