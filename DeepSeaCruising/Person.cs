using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaCruising
{
    internal class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public enum GenderEnum { Female, Male, Other}
        public DateTime DoB { get; set; }
        public GenderEnum Gender { get; set; } = Person.GenderEnum.Other;
        public string Description { get; set; }
        public string CabinNR { get; set; }
        public bool OnBoard { get; set; }



        // DoB Method
        public int Age()
        {
            TimeSpan t = DateTime.Now - DoB;
            DateTime dt = new DateTime(t.Ticks);
            int age = dt.Year;
            return age;
        }

    }
}
