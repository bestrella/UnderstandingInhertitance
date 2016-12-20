using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.color = "black";
            

            printCarDetails(myCar);

            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "32004";
            myTruck.color = "white";
            myTruck.TowingCapacity = "12000";

            printCarDetails(myTruck);

            Console.ReadLine();
        }

        private static void printCarDetails(Car car)
        {
            Console.WriteLine("Here are  the car's details: {0}", car.FormatME());
        }

        class Car
        {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string color { get; set; }


            public string FormatME()
            {
                return String.Format("{0} - {1} - {2} - {3}", this.Make, 
                    this.Model, 
                    this.Year,
                    this.color);
                
            }
        }

        class Truck : Car
        {
            public string  TowingCapacity { get; set; }
        }

    }
}
