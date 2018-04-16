using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
    public  class Vehicle
    {

        public Vehicle( string regNumber, int gearLever, string isAutomatic, string color)
        {
            RegNumber = regNumber;
            GearLever = gearLever;
            IsAutomatic = isAutomatic;
            Color = color;
          
     
           
        }

        public Vehicle()
        {
           
        }
        public  virtual void Print()
        {
            Console.Write($" {GetType().Name}, RegNumber: {RegNumber}, GearLever: {GearLever}, IsAutomatic:{IsAutomatic}, Color: {Color} ");
        }

        public string RegNumber { get; set; }
        public int GearLever { get; set; }
        public string IsAutomatic { get; set; }
        public string Color { get; set; }




    }
}
