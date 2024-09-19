using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class Patient
    {
        public int Id { get;  set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Illness { get; set; }

        public Patient(int id, string name, int age, string illness)
        {
            Id = id;
            Name = name;
            Age = age;
            Illness = illness;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}, Illness: {Illness}";
        }
    }

}
