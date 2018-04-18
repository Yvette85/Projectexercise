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
        public int size { get; set; }
        Garage<Vehicle> newvehicles;

        public GarageHandler(int size)
        {

            newvehicles = new Garage<Vehicle>(size);
          // newvehicles = new Garage<Vehicle>(40);
            //newvehicles.Park(new Car("eefgg", 4, "yes", "red", 4, "d"));
           // newvehicles.Park(new Car("dadadd", 5, "yes", "red", 4, "d"));
            //newvehicles.Park(new Bus("egeg", 6, "yes", "green", 12, 8));
            //newvehicles.Park(new Motorcycle("MAd", 3, "no", "black", 3, "Honda"));
        }


        public void ListParkedVehicles()
        {
            bool isEmpty = true; // To check if the garage is empty
            foreach (Vehicle v in newvehicles)
            {
                if (v != null)
                    v.Print();
                isEmpty = false; // The garage is not empty  
            }
            if (isEmpty == true)
            {
                Console.WriteLine("The garage is Empty");
            }
        }

        public void ListParkedVehiclesType()
        {
            bool isEmpty = true; // To check if the garage is empty
            foreach (Vehicle v in newvehicles)
            {

                Console.WriteLine(v.GetType().Name);
                isEmpty = false; // The garage is not empty  
            }
            if (isEmpty == true)
            {
                Console.WriteLine("The garage is Empty");
            }
        }

        public void ParkVehicle(Vehicle v)
        {
            newvehicles.Park(v);
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
            int countofCar = 0;
            int countofBus = 0;
            int countofMotorcycle = 0;
           
                foreach (Vehicle v in newvehicles.Where(x => x.Color == color))
                {
                    if (v.GetType().Name == "Car")

                        countofCar++;
                    else if (v.GetType().Name == "Bus")
                        countofBus++;
                    else if (v.GetType().Name == "Motorcycle")
                        countofMotorcycle++;
                    v.Print();
                }

           
            
            Console.WriteLine("We have " + countofCar + " Cars which are " + color);
            Console.WriteLine("We have " + countofBus + " Bus which are " + color);
            Console.WriteLine("We have " + countofMotorcycle + " Motorcycles which are " + color);
        }

        public void CreateGarage(int size)
        {

            Garage<Vehicle> newGarag = new Garage<Vehicle>(size);

            newvehicles = newGarag;
            Console.WriteLine("Done");
        }

    }
}
