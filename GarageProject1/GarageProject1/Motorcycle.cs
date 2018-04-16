using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
    public class Motorcycle : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public  string MotorcycleType { get; set; }

        public Motorcycle(string regNumber, int gearLever, string isAutomatic, string color, int numberofwheels, string motorcycletype) : base(regNumber, gearLever, isAutomatic, color)
        {
            NumberOfWheels = numberofwheels;
            MotorcycleType = motorcycletype;
        }

        public override void Print() // we use the override method because , we need to use the proprties of the parent in the childrens
        {
            base.Print();
            Console.WriteLine($" Numberofwheels :{ NumberOfWheels} , MotorcycleType :{ MotorcycleType}");
        }
    }
}
