using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    sealed class Carp:Fish
    {
        private int scalesLateralLine;
        public int ScalesLateralLine
        {
            get { return scalesLateralLine; }
            set
            {
                if (value < 1)
                    value = 1;
                scalesLateralLine = value;
            }
        }
        public Carp() : this("Common carp","Golden",12,3 ,35) { }
        public Carp(string name, string color, int speed, int depth,int scales):base(name,color,speed,depth)
        {
            ScalesLateralLine = scales;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Scales in the lateral line: "+ScalesLateralLine);
        }
        public override void Say()
        {
            Console.WriteLine("*Bul-bul*");
        }
    }
}
