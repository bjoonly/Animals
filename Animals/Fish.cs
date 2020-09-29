using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Fish : Animal
    {
        private int depth;
        public int Depth
        {
            get { return depth; }
            set
            {
                if (value < 1)
                    value = 1;
                depth = value;
            }
        }
        public Fish() : this("No name", "No color", 1, 1) { }
        public Fish(string name, string color, int speed, int depth) : base("Fish", name, color, speed)
        {
            Depth = depth;
        }
        public override void Move()
        {

            base.Move();
            Console.WriteLine("At depth: " + Depth);
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Depth: {depth}");

        }
        public override void Say()
        {
            Console.WriteLine("*Glug*");
        }

    }
}
