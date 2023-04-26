using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Person
    {
        public string name { get; set; }
        public string surName { get; set; }
        public string number { get; set; }

        public Person (string name, string surName, string number)
        {
            this.name = name;
            this.surName = surName;
            this.number = number;
        }
    }
}
