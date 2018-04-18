using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
   public class UI
    {
        public int InputAsInteger()
        {
            string str = Console.ReadLine();
            bool  isInteger = Int32.TryParse(str, out int result);
            if (isInteger)
                return result;
            else
                return -1;
        }
       public void MainMenu()
       {
            Console.WriteLine("Enter the size of the garage");
            int size = InputAsInteger(); //To get an input as a Integer
            while (size == -1)
            {
                Console.WriteLine("Input An Invalid Value");
                size = InputAsInteger();
            }
            GarageHandler g = new GarageHandler(size);

            bool keepRunning = true;
            while (keepRunning)
            {
               
                

                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3, 4, 5, 6, 7, 0) of your choice"
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

                        g.ListParkedVehiclesType();//some thing
                        break;
                    case '3':
                        Vehicle vehicle = new Vehicle();
                        Console.WriteLine("Choose The Type Of The Vehicle: Car --> 1, Bus --> 2, Motortcycle --> 3");
                        string type = Console.ReadLine();
                        if (type == "1")
                        {
                            // Input the registration number as a string
                            Console.WriteLine("Enter the registration number");
                            string reg = Console.ReadLine();


                            Console.WriteLine("Enter gear lever");
                            int gearLever = InputAsInteger(); //To get an input as a Integer
                            while(gearLever == -1)
                            {
                                Console.WriteLine(" You input an invalid Value");
                                gearLever = InputAsInteger();
                            }

                            Console.WriteLine("Is It Automatic Y/N");
                            string isAutomatic = Console.ReadLine();
                            while (isAutomatic !="y" && isAutomatic != "n")
                            {
                                Console.WriteLine(" You input an invalid Value");
                                isAutomatic = Console.ReadLine();
                            }

                            Console.WriteLine("Enter the color");
                            string color = Console.ReadLine();

                            Console.WriteLine("Enter number of seats");
                            int numberOfSeats = InputAsInteger(); //To get an input as a Integer
                            while (numberOfSeats == -1)
                            {
                                Console.WriteLine(" You input an invalid Value");
                                numberOfSeats = InputAsInteger();
                            }



                            Console.WriteLine("Enter the Type Of Fuel d --> Disel, b --> Bensin");
                            string typeOfFuel = Console.ReadLine();
                            while (typeOfFuel != "d" && typeOfFuel != "b")
                            {
                                Console.WriteLine(" You input an invalid Value");
                                typeOfFuel = Console.ReadLine();
                            }

                            vehicle = new Car(reg, gearLever, isAutomatic, color, numberOfSeats, typeOfFuel);
                            g.ParkVehicle(vehicle);  

                        }
                        else if (type == "2")
                        {
                            Console.WriteLine("Enter the registration number");
                            string reg = Console.ReadLine();

                            Console.WriteLine("Enter gear lever");
                            int gearLever = InputAsInteger(); //To get an input as a Integer
                            while (gearLever == -1)
                            {
                                Console.WriteLine(" You input an invalid Value");
                                gearLever = InputAsInteger();
                            }


                            Console.WriteLine("Is It Automatic Y/N");
                            string isAutomatic = Console.ReadLine();
                            while (isAutomatic != "y" && isAutomatic != "n")
                            {
                                Console.WriteLine(" You input an invalid Value");
                                isAutomatic = Console.ReadLine();
                            }

                            Console.WriteLine("Enter the color");
                            string color = Console.ReadLine();

                            Console.WriteLine("Enter bus Length");
                            int busLength = InputAsInteger(); //To get an input as a Integer
                            while (busLength == -1)
                            {
                                Console.WriteLine(" You input an invalid Value");
                                busLength = InputAsInteger();
                            }

                            Console.WriteLine("Enter number Of Wheels");
                            int numberOfWheels = InputAsInteger(); //To get an input as a Integer
                            while (numberOfWheels == -1)
                            {
                                Console.WriteLine(" You input an invalid Value");
                                numberOfWheels = InputAsInteger();
                            }

                            vehicle = new Bus(reg, gearLever, isAutomatic, color, busLength, numberOfWheels);
                            g.ParkVehicle(vehicle);


                        }
                        else if (type == "3")
                        {
                            Console.WriteLine("Enter the registration number");
                            string reg = Console.ReadLine();


                            Console.WriteLine("Enter gear lever");
                            int gearLever = InputAsInteger(); //To get an input as a Integer
                            while (gearLever == -1)
                            {
                                Console.WriteLine(" You input an invalid Value");
                                gearLever = InputAsInteger();
                            }


                            Console.WriteLine("Is It Automatic Y/N");
                            string isAutomatic = Console.ReadLine();
                            while (isAutomatic != "y" && isAutomatic != "n")
                            {
                                Console.WriteLine(" You input an invalid Value");
                                isAutomatic = Console.ReadLine();
                            }



                            Console.WriteLine("Enter the color");
                            string color = Console.ReadLine();

                            Console.WriteLine("Enter number Of Wheels");
                            int numberOfWheels = InputAsInteger(); //To get an input as a Integer
                            while (numberOfWheels == -1)
                            {
                                Console.WriteLine(" You input an invalid Value");
                                numberOfWheels = InputAsInteger();
                            }

                            Console.WriteLine("Enter the type of motorcycle");
                            string typeOfMotorcycle = Console.ReadLine();

                            vehicle = new Motorcycle(reg, gearLever , isAutomatic, color, numberOfWheels, typeOfMotorcycle);
                            g.ParkVehicle(vehicle);



                        }
                        else
                        {
                            Console.WriteLine("Please enter some valid input (1, 2, 3)");
                        }
                      

                        break;
                    case '4':
                        Console.WriteLine("Enter the registration number");
                        string regNumber = Console.ReadLine();

                        g.UnParkVehicle(regNumber);

                        break;
                    case '5':
                        Console.WriteLine("Enter the maximun size");
                        int newMaximumSize = InputAsInteger(); //To get an input as a Integer
                        while (newMaximumSize == -1)
                        {
                            Console.WriteLine(" You input an invalid Value");
                            newMaximumSize = InputAsInteger();
                        };
                        g.SetSize(newMaximumSize);
                        break;
                    case '6':
                        Console.WriteLine("Enter color");
                        string s = Console.ReadLine();
                        g.FindVehicles(s);

                        break;
                    case '7':

                        Console.WriteLine("Enter the size");
                        int newSize = InputAsInteger(); //To get an input as a Integer
                        while (newSize == -1)
                        {
                            Console.WriteLine(" You input an invalid Value");
                            newSize = InputAsInteger();
                        };
                        g.CreateGarage(newSize);
                        break;

                   
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5, 6, 7)");
                        break;
                }
            }
        } 
    }
}
