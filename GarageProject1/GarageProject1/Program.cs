using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
    class Program
    {
       


        static void Main(string[] args)
        {
            

            GarageHandler g = new GarageHandler();


            
            while (true)
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
                       g. ListParkedVehicles();
                        
                     
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
                            vehicle = new Car(reg, Int32.Parse(gearLever), isAutomatic , color, Int32.Parse(numberOfSeats), typeOfFuel);
                            
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
                            double busLength = double.Parse( Console.ReadLine());
                            Console.WriteLine("Enter number of wheels");
                            int numberOfWheels =Int32.Parse(Console.ReadLine());
                            vehicle = new Bus(reg, Int32.Parse(gearLever), isAutomatic, color, busLength, numberOfWheels);
                            

                        }
                        else if(type =="3")
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
                            
                             vehicle= new Motorcycle(reg, Int32.Parse(gearLever), isAutomatic, color, numberOfWheels, typeOfMotorcycle);
                           


                        }
                       g.ParkVehicle(vehicle);
       
                        break;
                    case '4':
                        Console.WriteLine("Enter the registration number");
                        string regNumber = Console.ReadLine();
                        
                       // g.UnParkVehicle(vehicles, regNumber);
                       
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

                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some invalid input (0, 1, 2, 3, 4, 5, 6, 7)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        /*
        static void ExamineList()
        {
            List<string> theList = new List<string>();




            string input = " ";




            while (true)
            {
                Console.WriteLine(" Please type + to add the rest of the input to the list and type - to remove the rest of the input to the list"
                    + " +. AddInput"
                    + "-. RemoveInput"
                    + "\n3. Print out the list"
                    + "\n4. Exit the method"
                    );


                char nav = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine(); //Tries to set input to the first char in an input line
                    nav = input[0];
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                switch (nav)
                {
                    case '+':
                        string value = input.Substring(1);
                        theList.Add(value);

                        break;
                    case '-':
                        string value2 = input.Substring(1);
                        theList.Remove(value2);
                        break;

                    case '3':
                        foreach (var name in theList)
                        {
                            Console.WriteLine(name);
                        }
                        Console.WriteLine(theList.Count);
                        Console.WriteLine(theList.Capacity);
                        break;


                    case '4':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (+,-)");
                        break;




                }
            }






            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
        }


        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        /// 
        /*
        static void ExamineQueue()
        {


            Queue<string> names = new Queue<string>();



            while (true)
            {
                Console.WriteLine("Please enter the corresponding number"
                    + "\n5. Enqueue"
                    + "\n6. Dequeue"
                    + "\n7. Exit the method");
                string input = " ";


                string nav = " "; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine(); //Tries to set input to the first char in an input line
                    nav = input;
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                switch (input)
                {
                    case "5":
                        names.Enqueue("Kalle");
                        names.Enqueue("Greta");
                        names.Enqueue("Stina");
                        names.Enqueue("Olle");
                        foreach (var n in names)
                        {
                            Console.WriteLine(n);
                        }


                        break;

                    case "6":
                        names.Dequeue();
                        foreach (var n in names)
                        {
                            Console.WriteLine(n);
                        }
                        break;

                    case "7":
                        return;


                }
            }




            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        /// */
        /// 
        /*
        static void ExamineStack()
        {

            Stack<string> books = new Stack<string>();


            while (true)
            {
                Console.WriteLine("Please enter the corresponding number"
                    + "\n8. Push"
                    + "\n9. Pop"
                    + "\n10. Exit the method");
                string input = " ";


                string nav = " "; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine(); //Tries to set input to the first char in an input line
                    nav = input;
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                switch (input)
                {
                    case "8":
                        books.Push("Francais");
                        books.Push("Anglais");
                        books.Push("Swahili");
                        books.Push("Kirundi");
                        foreach (var b in books)
                        {
                            Console.WriteLine(b);
                        }


                        break;

                    case "9":

                        books.Pop();
                        foreach (var b in books)
                        {
                            Console.WriteLine(b);
                        }

                        break;

                    case "10":
                        return;





                }
            }



            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        //}
        /*
        static void CheckParanthesis()
        {
            Stack<string> characters = new Stack<string>();

            string input = Console.ReadLine();

            foreach (var character in input)
            {
                Console.WriteLine(character);
            }



            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})]
             * Example of incorrect: (()]), [), {[()}]
             */
             



   

