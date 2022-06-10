using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLPOWTORKA
{
    class Buyer : Person
    {
        protected List<Product> tasks = new List<Product>();

        public Buyer(string name, int age) : base(name, age)
        {
          
        }

        internal void AddProduct(Product product)
        {
            tasks.Add(product);
        }

        internal void RemoveProduct(int index)
        {
            tasks.RemoveAt(index);
        }

        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix}Buyer:");
            base.Print(prefix);

            if (tasks.Count > 0)
            {
                Console.WriteLine($"{prefix}{prefix}-- Products: --");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.Write(prefix);
                    tasks[i].Print("\t");
                }
            }

        }
    }
}
