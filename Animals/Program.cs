using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{


    class Program
    {

        static void Main(string[] args)
        {
            Animal[] zoo = new Animal[]
            {
                new Mammal("Hourse","White",70,1),
                new Dolphin(),
                new Bear(),

                new Amphibian(),
                new Frog(),

                new Fish("Fish","Golden",10,1000),
                new Carp(),
                
                new Bird("Sparrow","Brown",50,100),
                new Eagle()
            };
            foreach(var animal in zoo)
            {
                animal.Say();
                Console.WriteLine();
                animal.Show();
                Console.WriteLine();
                animal.Move();
                Console.WriteLine(new string('-',30));
            }
                   
        }
    }
}
