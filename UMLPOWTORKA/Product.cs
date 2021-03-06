using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLPOWTORKA
{
    abstract class Product:IThing
    {
        private string name;

        public string Name { get => this.name; set => name = value; }

        public Product(string name)
        {
            this.name = name;
        }

        public virtual void Print(string prefix)
        {
            Console.WriteLine($"{prefix}{name}");
        }
    }
}
