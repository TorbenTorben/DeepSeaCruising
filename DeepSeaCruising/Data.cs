using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaCruising
{
    internal class Data
    {
        public List<Person> PersonList = new List<Person>();
        
        
        public void ShowPassList()
        {
            foreach (Person p in PersonList)
            {
                Console.WriteLine($"Name:{p.Name}   +Description:{p.Description}   +Age:{p.Age()}   \n   +Email:{p.Email}   +Gender:{p.Gender}   +CabinNR:{p.CabinNR}   +PassengerID:{p.IdNumber}   +PhoneNumber:{p.PhoneNo}   \n   {p.Name}'s crew status:{p.CrewStatus} ");
            }

        }
    }
}
