using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
     public class Car : Vehicle
    {
        public Car(string regNumber, int gearLever, string isAutomatic, string color, int numberofseats, string fueltype) : base(regNumber, gearLever, isAutomatic, color)
        {
            NumberOfSeats = numberofseats;
            FuelType = fueltype;
        }
        public int NumberOfSeats { get; set; }
        public string FuelType { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"NumberOfSeats : { NumberOfSeats} ,FuelType : { FuelType}");
        }
    }
}
