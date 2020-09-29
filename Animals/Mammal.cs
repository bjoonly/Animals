using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Mammal : Animal
    {
        private int avgNumberOfOffspring;
        public int AvgNumberOfOffstring
        {
            get { return avgNumberOfOffspring; }
            set
            {
                if (value < 1)
                    value = 1;
                avgNumberOfOffspring = value;
            }
        }
        public Mammal() : this("No name", "No color", 1, 1) { }
        public Mammal(string name, string color, int speed, int offspring) : base("Mammal", name, color, speed)
        {
            AvgNumberOfOffstring = offspring;
        }

        public override void Move()
        {
            Console.Write(Type + " ");
            base.Move();
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Average number of offspring: " + AvgNumberOfOffstring);
        }
        public override void Say()
        {
            Console.WriteLine("*Unidentified sounds*");
        }
    }
}
