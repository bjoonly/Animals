using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
   sealed class Eagle:Bird
    {
        private int wingspan;
        public int Wingspan
        {
            get { return wingspan; }
            set
            {
                if (value < 1)
                    value = 1;
                wingspan = value;
            }
        }
        public Eagle():this("Golden eagle","Brown",270,3000,200) { }
        public Eagle(string name, string color, int speed, int height, int wingspan):base(name,color,speed,height)
        {
            Wingspan = wingspan;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Wingspan: "+wingspan);
        }
        public override void Say()
        {
            Console.WriteLine("*Beak clicks*");
        }
    }
}
