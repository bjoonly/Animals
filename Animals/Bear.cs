using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
   sealed class Bear:Mammal
    {
        private int hibernationDuration;
        public int HibernationDuration
        {
            get { return hibernationDuration; }
            set
            {
                if (value < 0)
                    value = 0;
                hibernationDuration = value;

            }
        }
        public Bear() : this("Brown bear","Brown", 50, 2, 100) { }
        public Bear(string name,string color,int speed, int offspring,int hibernationDuration):base(name,color,speed,offspring)
        {
            HibernationDuration = hibernationDuration;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Hibernation duration: "+HibernationDuration + " days");
        }

        public override void Say()
        {
            Console.WriteLine("*Roar*");
        }
    }

}
