using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaCruising
{
    internal class Menu
    {

        Data dataBase = new Data();
        Random rand = new Random();
        public Menu() // Constructor
        {
            // Menu system start
            MenuSwitch();

        }
        
        private void MenuSwitch()
        {
            while (true)
            {
                // Dette er min menu som brugeren kan bruge til at vælge hvilken handling de vil tage
                
                Console.WriteLine("Menu\n Tilføj person: 1 \n Fjern en person: 3 \n Logind: 2 \n Passenger List: 4 \n Luk programmet : 5");
                string choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {

                    case "1":
                        // Vis man skriver 1 kommer man her til hvor min Passenger methode bruges til at lave en ny Person i systemet
                        Console.WriteLine("Ønsker du at tilføje en person?\n");
                        Console.WriteLine("Ja: 1");
                        Console.WriteLine("Nej: 2");
                        string choice1 = Console.ReadLine();
                        Console.Clear();
                        if (choice1 == "1")
                        {
                            Person p = Passenger();
                            dataBase.PersonList.Add(p);
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "2":
                        
                        Console.WriteLine("Ønsker du at fjerne en person?\n");
                        Console.WriteLine("Ja: 1");
                        Console.WriteLine("Nej: 2");
                        string choice2 = Console.ReadLine();
                        Console.Clear();
                        if (choice2 == "1")
                        {

                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Har du et logind\n");
                        Console.WriteLine("Ja: 1");
                        Console.WriteLine("Nej: 2");
                        string choice3 = Console.ReadLine();
                        Console.Clear();
                        if (choice3 == "1")
                        {

                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "4":
                        // Denne del af min switch bruger jeg til at vise min Passenger List fra data basen
                        Console.WriteLine("Vil du see passengers?\n");
                        Console.WriteLine("Ja: 1");
                        Console.WriteLine("Nej: 2");
                        string choice4 = Console.ReadLine();
                        Console.Clear();
                        if (choice4 == "1")
                        {
                            dataBase.ShowPassList();
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("Er du sikker på at du vil lukke?\n");
                        Console.WriteLine("Ja: 1");
                        Console.WriteLine("Nej: 2");
                        string choice5 = Console.ReadLine();
                        Console.Clear();
                        if(choice5 == "1")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            break ;
                        }
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        // Input Method
        // Passenger indput

        private Person Passenger()
        {
            Person passenger = new Person();

            // Saves current time and date for new person
            passenger.MakeDate = DateTime.Now;
           
            //Passenger indputs name
            Console.Write("Please Indput your name: ");
            passenger.Name = Console.ReadLine();

            //Passenger indputs phone number
            Console.Write("Please Indput your phone number: ");
            passenger.PhoneNo = Console.ReadLine();

            //Passenger indputs email
            Console.Write("Please Indput your email: ");
            passenger.Email = Console.ReadLine();

            //Passenger indputs their description
            Console.Write("Please indput your description: ");
            passenger.Description = Console.ReadLine();

            //passenger indputs their gender
            Console.Write("Please indput your gender: \n");
            foreach(var g in Enum.GetValues( typeof(Person.GenderEnum)))
            {
                Console.WriteLine((int)g + g.ToString());
            }
            passenger.Gender = (Person.GenderEnum)int.Parse(Console.ReadLine());

            //Passenger indputs date of birth 
            Console.Write("Please indput your date of birth yyyy-mm-dd: \n");
            passenger.DoB = DateTime.Parse(Console.ReadLine());
            
            
            // Passenger indputs crew status
            Console.Write("Are you a Crew Member? \n");
            string crewsvar = Console.ReadLine().ToLower();
            if (crewsvar == "yes" )
            {
                passenger.CrewStatus = true;
                int crewRndId = rand.Next(451, 501);
                int crewRndCabin = rand.Next(200, 250);
                Console.Write("Your Id is " + crewRndId + " and youre Cabin number is " + crewRndCabin);
                string crewCabinstr = crewRndCabin.ToString();
                passenger.CabinNR = crewCabinstr;
                passenger.IdNumber = crewRndId;
                Console.ReadKey();
            }
            else
            {
                Console.Write("Do you have a pet with you? \n");
                string petsvar = Console.ReadLine().ToLower();
                if (petsvar == "yes")
                {
                    Pet pet = new Pet();
                    passenger.PetStatus = true;
                    Console.Write("What is its name: ");
                    pet.PetName = Console.ReadLine();
                    Console.Write("What kind of pet is it? \n");
                    pet.PetType = Console.ReadLine();
                }


                    
                passenger.CrewStatus = false;
                int rndId = rand.Next(251, 450);
                int rndCabin = rand.Next(0, 199);
                Console.Write("Your Id is " + rndId + " and youre Cabin number is " + rndCabin);
                string cabinstr = rndCabin.ToString();
                passenger.CabinNR = cabinstr;
                passenger.IdNumber = rndId;
                Console.ReadKey();
            }
            Console.Clear();



            return passenger;
        }
     

    }
}
