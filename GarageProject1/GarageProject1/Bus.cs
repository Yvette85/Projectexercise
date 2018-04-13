using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
    public class Bus : Vehicle
    {
        public double BusLength { get; set; }
        public int NumberOfWheels { get; set; }

        public Bus(string regNumber, int gearLever, string isAutomatic, string color, double buslength , int numberofwheels) : base(regNumber, gearLever, isAutomatic, color)
        {
            BusLength = buslength;
            NumberOfWheels = numberofwheels;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine( $" BusLength :{BusLength} , NumberOfWheels : { NumberOfWheels}");
        }
    }
}
