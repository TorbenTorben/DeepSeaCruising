using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaCruising
{
    internal class Passenger
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public enum GenderEnum { Female, Male, Other }
        public DateTime DoB { get; set; }
        public GenderEnum Gender { get; set; } = Passenger.GenderEnum.Other;
        public string Description { get; set; }
        public string CabinNR { get; set; }
        public bool OnBoard { get; set; }
        public string IdPassenger { get; set; }

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
}
