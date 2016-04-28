using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace PolymorphismProgram
    {  
            public abstract class Vehicle
            {
                public virtual int Wheels()
                {
                    return 0;
                }
            }
            public class Bicycle : Vehicle
            {
                public override int Wheels()
                {
                    return 2;
                }
            }
            public class Car : Vehicle
            {
                public override int Wheels()
                {
                    return 4;
                }
            }
            public class Truck : Vehicle
            {
                public new int Wheels()
                {
                    return 18;
                }
            }
            class Program
            {
                static void Main(string[] args)
                {
                    List<Vehicle> vehicles = new List<Vehicle>();
                    vehicles.Add(new Bicycle());
                    vehicles.Add(new Car());
                    vehicles.Add(new Truck());
                    foreach (Vehicle v in vehicles)
                    {
                        Console.WriteLine("A {0} has {1} wheels.", v.GetType().Name, v.Wheels());
                    }

                Truck truck1 = new Truck();
                Console.WriteLine("A {0} has {1} wheels.", truck1.GetType().Name, truck1.Wheels());

                Console.ReadLine();
                }     
            }
        }
    