using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R45_M3_Class_21_Work_01
{
    public abstract class Person
    {
        public Person() { }
        public Person(string name, DateTime birthDate) { this.Name = name; this.BirthDate = birthDate; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public abstract int Age();
    }
}
