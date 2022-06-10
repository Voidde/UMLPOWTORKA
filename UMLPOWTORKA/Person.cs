using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLPOWTORKA
{
    abstract class Person:IThing
    {
        private string name;

        private int age;

        public string Name { get => this.name; set => name = value; }

        public int Age { get => this.age; set => age = value; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void Print(string prefix)
        {
            Console.WriteLine($"{name} {age}y.o\n");
        }

    }
}
