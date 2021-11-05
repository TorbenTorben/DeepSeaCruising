using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaCruising
{
    internal class Person
    {
        public string Name { get; set; }        //Done
        public string Email { get; set; }       //Done
        public string PhoneNo { get; set; }     //Done
        public enum GenderEnum { Female, Male, Other}       //Done
        public DateTime DoB { get; set; }       //Done
        public GenderEnum Gender { get; set; } = Person.GenderEnum.Other;       //Done
        public string Description { get; set; }             //Done
        public string CabinNR { get; set; }         //Auto Done
        public bool OnBoard { get; set; }       //??
        public string PersonId { get; set; }        //Auto Done
        public bool CrewStatus { get; set; }        //Done
        public bool PetStatus { get; set; }         //Not Done
        public enum PortsOfCallEnum { Bangkok, HongKong, PortAuPrince, Esbjerg, Newcastle, Mandalay }
        public PortsOfCallEnum Origin { get; set; } = PortsOfCallEnum.Bangkok;
        public PortsOfCallEnum Destination { get; set; } = PortsOfCallEnum.Bangkok;
        public DateTime DepartureDate { get; set; }
        public DateTime EndDate { get; set; }
        public int IdNumber { get; set; }
        public bool ScheduledOnBoard { get; set; } //Til senere. If else, om de har behov for at check om de er ombord
        public DateTime MakeDate { get; set; }



        // DoB Method
        public int Age()
        {
            //TimeSpan t = DateTime.Now - DoB;
            //DateTime dt = new DateTime(t.Ticks);
            //int age = dt.Year;
            //return age;


            DateTime checkDT = new DateTime(DateTime.Now.Year, DoB.Month, DoB.Day);
            int age = DateTime.Now.Year - DoB.Year - 1;
            if (DateTime.Now > checkDT) age++;
            return age;
        }
        

    }
    internal class Pet
    {
        public string PetName { get; set; }
        public string PetType { get; set; }
    }
}
