using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
    public class UI
    {

        GarageHandler g = new GarageHandler();

        public void MainMenu()
        {
            bool keepRunning = true;

            while (keepRunning)
            {

                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. List all parked vehicles"

                    + "\n2. List all vehicle types currently parked in the garage "
                    + "\n3. Park Vehicles"
                    + "\n4. Unpark Vehicles "
                    + "\n5. Set Size"
                    + "\n6. Find vehicles by color"
                    + "\n7.  Create a new Garage"
                    + "\n0. Exit the application");

                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        g.ListParkedVehicles();


                        break;
                    case '2':

                        g.ListParkedVehiclesType();
                        break;
                    case '3':
                        Vehicle vehicle = new Vehicle();
                        Console.WriteLine("Choose The Type");
                        string type = Console.ReadLine();
                        if (type == "1")
                        {

                            Console.WriteLine("Enter the registration number");
                            string reg = Console.ReadLine();
                            Console.WriteLine("Enter gear lever");
                            string gearLever = Console.ReadLine();
                            Console.WriteLine("Is It Automatic Y/N");
                            string isAutomatic = Console.ReadLine();
                            Console.WriteLine("Enter the color");
                            string color = Console.ReadLine();

                            Console.WriteLine("Enter Number Of Seats");
                            string numberOfSeats = Console.ReadLine();
                            Console.WriteLine("Enter the Type Of Fuel");
                            string typeOfFuel = Console.ReadLine();
                            vehicle = new Car(reg, Int32.Parse(gearLever), isAutomatic, color, Int32.Parse(numberOfSeats), typeOfFuel);

                        }
                        else if (type == "2")
                        {
                            Console.WriteLine("Enter the registration number");
                            string reg = Console.ReadLine();
                            Console.WriteLine("Enter gear lever");
                            string gearLever = Console.ReadLine();
                            Console.WriteLine("Is It Automatic Y/N");
                            string isAutomatic = Console.ReadLine();
                            Console.WriteLine("Enter the color");
                            string color = Console.ReadLine();

                            Console.WriteLine("Enter Bus Length");
                            double busLength = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter number of wheels");
                            int numberOfWheels = Int32.Parse(Console.ReadLine());
                            vehicle = new Bus(reg, Int32.Parse(gearLever), isAutomatic, color, busLength, numberOfWheels);


                        }
                        else if (type == "3")
                        {
                            Console.WriteLine("Enter the registration number");
                            string reg = Console.ReadLine();
                            Console.WriteLine("Enter gear lever");
                            string gearLever = Console.ReadLine();
                            Console.WriteLine("Is It Automatic Y/N");
                            string isAutomatic = Console.ReadLine();
                            Console.WriteLine("Enter the color");
                            string color = Console.ReadLine();

                            Console.WriteLine("Enter number of wheels");
                            int numberOfWheels = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the type of motorcycle");
                            string typeOfMotorcycle = Console.ReadLine();

                            vehicle = new Motorcycle(reg, Int32.Parse(gearLever), isAutomatic, color, numberOfWheels, typeOfMotorcycle);



                        }
                        g.ParkVehicle(vehicle);

                        break;
                    case '4':
                        Console.WriteLine("Enter the registration number");
                        string regNumber = Console.ReadLine();

                         g.UnParkVehicle(regNumber);

                        break;
                    case '5':

                        Console.WriteLine("Enter the new maximum size");
                        int newMaximumSize = Int32.Parse(Console.ReadLine());
                        g.SetSize(newMaximumSize);
                        break;
                    case '6':
                        Console.WriteLine("Enter color");
                        string s = Console.ReadLine();
                        g.FindVehicles(s);

                        break;
                    case '7':

                        Console.WriteLine("Enter the size");
                        int newSize = Int32.Parse(Console.ReadLine());
                        g.CreateGarage(newSize);
                        break;

                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some invalid input (0, 1, 2, 3, 4, 5, 6, 7)");
                        break;
                }
            }

        }


            
    }
}
