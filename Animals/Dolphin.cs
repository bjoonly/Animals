using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dolphin:Mammal
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
        public Dolphin():this("Risso's dophin","Grey",50,250) { }
        public Dolphin(string name, string color, int speed, int depth) : base(name, color, speed, 1)
        {
            Depth = depth;
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("At depth: "+Depth);
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Depth: "+Depth);
        }
        public override void Say()
        {
            Console.WriteLine("*Dolphin whistle*");
        }

    }
}
