using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaCruising
{
    internal class Menu
    {

        public Menu() // Constructor
        {
            // Menu system start
            MenuSwitch();

        }
        
        private void MenuSwitch()
        {
            Console.WriteLine("Menu\n");
            Console.WriteLine("Køb billet: 1");
            Console.WriteLine("Logind: 2");
            string choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                
                case "1":
                    Console.WriteLine("Ønsker du at købe en billet?\n");
                    Console.WriteLine("Ja: 1");
                    Console.WriteLine("Nej: 2");
                    string choice1 = Console.ReadLine();
                    Console.Clear();
                    if(choice1 == "1")
                    {
                        Passenger();
                    }
                    else
                    {
                        MenuSwitch();
                    }
                    break;

                case "2":
                    Console.WriteLine("Har Du et Logind?\n");
                    Console.WriteLine("Ja: 1");
                    Console.WriteLine("Nej: 2");
                    string choice2 = Console.ReadLine();
                    Console.Clear();
                    if (choice2 == "1")
                    {

                    }
                    else
                    {
                        MenuSwitch();
                    }
                    break;
                case "3":
                    Console.WriteLine("Har Du et Logind?\n");
                    Console.WriteLine("Ja: 1");
                    Console.WriteLine("Nej: 2");
                    string choice3 = Console.ReadLine();
                    Console.Clear();
                    if (choice3 == "1")
                    {

                    }
                    else
                    {
                        MenuSwitch();
                    }
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }

        }
        // Input Method

        private Passenger Passenger()
        {
            Passenger passenger = new Passenger();
           
            //Passenger indputs name
            Console.Write("Please Indput your name: ");
            passenger.Name = Console.ReadLine();
           
            
            passenger.Description = Console.ReadLine();
           
            
            passenger.IdPassenger = Console.ReadLine();

            //passenger indputs their gender
            Console.Write("Please indput your gender: ");
            foreach(var g in Enum.GetValues( typeof(Passenger.GenderEnum)))
            {
                Console.WriteLine((int)g + g.ToString());
            }
            passenger.Gender = (Passenger.GenderEnum)int.Parse(Console.ReadLine());
            
            
            passenger.CabinNR = int.Parse(Console.ReadLine());

            Console.Write("Please indput your date of birth yyyy-");
            passenger.DoB = DateTime.Parse(Console.ReadLine());

            return passenger;
        }

    }
}
