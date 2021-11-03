using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaCruising
{
    internal class Crew
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public enum GenderEnum { Female, Male, Other }
        public GenderEnum Gender { get; set; } = Crew.GenderEnum.Other;
    }
}
