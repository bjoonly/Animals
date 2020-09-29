using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 1)
                    value = 1;
                speed = value;
            }
        }
        public Animal() : this("No type", "No name", "No color", 1) { }
        public Animal(string type, string name, string color, int speed)
        {
            Type = type;
            Name = name;
            Color = color;
            Speed = speed;
        }
        virtual public void Move()
        {
            Console.WriteLine($"{Name} moving with speed: {Speed}");
        }
        virtual public void Show()
        {
            Console.WriteLine($"Type: {Type}\nName: {Name}\nColor: {Color}\nSpeed: {Speed}");
        }

        virtual public void Say()
        {
            Console.WriteLine("Says something.");
        }
    }
}
