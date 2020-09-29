using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Amphibian : Animal
    {
        private int temperature;
        public int Temperature
        {
            get { return temperature; }
            set
            {
                if (value < 1)
                    value = 1;
                temperature = value;

            }
        }
        public Amphibian() : this("No name", "No color", 1, 1) { }
        public Amphibian(string name, string color, int speed, int temperature) : base("Amphibian", name, color, speed)
        {
            Temperature = temperature;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Temperature: " + Temperature);
        }
        public override void Move()
        {
            Console.Write(Type + " ");
            base.Move();
        }
        public override void Say()
        {
            Console.WriteLine("*Splosh*");
        }

    }
}
