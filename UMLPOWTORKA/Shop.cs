using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLPOWTORKA
{
    class Shop : IThing
    {
        private string name;

        private Person[] people;

        private Product[] products;

        public string Name { get => this.name; set => Name = value; }

        public Shop(string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;
            this.products = products;
        }
        public void Print()
        {
            Console.WriteLine($"Shop: {name} ");
            Console.WriteLine("-- People: --");

            for (int i = 0; i < people.Length; i++)
            {
                people[i].Print("\t");
            }
            Console.WriteLine("-- Products: --");

            for (int i = 0; i < products.Length; i++)
            {
                products[i].Print("\t");
            }


        }
    }
}
