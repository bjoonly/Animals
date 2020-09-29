using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    sealed class Frog: Amphibian
    {
        private int jumpHeight;
        public int JumpHeight
        {
            get { return jumpHeight; }
            set
            {
                if (value < 1)
                    value = 1;
                jumpHeight = value;
            }
        }
        public Frog():this("Eoropean tree frog","Green",3,15,15) { }
        public Frog(string name, string color, int speed, int temperature,int jumpHeight):base(name,color,speed,temperature)
        {
            JumpHeight = jumpHeight;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Jump height: "+JumpHeight);
        }
        public override void Say()
        {
            Console.WriteLine("*Croak*");
        }
    }
}
