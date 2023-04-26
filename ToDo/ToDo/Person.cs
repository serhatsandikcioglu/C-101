using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(int id,string name,string surName)
        {
            Id = id;
            Name = name;
            Surname = surName;
        }
    }
}
