using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
    public class GarageHandler // we create the GarageHandler 
    {
        //Garage<Vehicle> vehicles;
        Garage<Vehicle> newvehicles;

        public GarageHandler()
        {

            newvehicles = new Garage<Vehicle>(20);
          // newvehicles = new Garage<Vehicle>(40);
            //newvehicles.Park(new Car("eefgg", 4, "yes", "red", 4, "d"));
           // newvehicles.Park(new Car("dadadd", 5, "yes", "red", 4, "d"));
            //newvehicles.Park(new Bus("egeg", 6, "yes", "green", 12, 8));
            //newvehicles.Park(new Motorcycle("MAd", 3, "no", "black", 3, "Honda"));
        }


        public void ListParkedVehicles()
        {
            foreach (Vehicle v in newvehicles)
            {
                if (v != null)
                    v.Print();
            }
        }

        public void ListParkedVehiclesType()
        {
            foreach (Vehicle v in newvehicles)
            {

                Console.WriteLine(v.GetType().Name);
            }
        }

        public void ParkVehicle(Vehicle vehicle)
        {
            newvehicles.Park(vehicle);
        }

        public void UnParkVehicle(string regNumber)
        {
            newvehicles.UnPark(regNumber);
        }

        public void SetSize(int newMaxCapacity)
        {
            newvehicles.MaxCapacity = newMaxCapacity;
        }

        public void FindVehicles(string color)
        {
            foreach (Vehicle v in newvehicles.Where(x => x.Color == color))
            {
                v.Print();
            }
        }

        public void CreateGarage(int size)
        {

            Garage<Vehicle> newGarag = new Garage<Vehicle>(size);

            newvehicles = newGarag;
            Console.WriteLine("Done");
        }

    }
}
