using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Bird : Animal
    {
        private int flightAltitude;
        public int FlightAltitude
        {
            get { return flightAltitude; }
            set
            {
                if (value < 1)
                    value = 1;
                flightAltitude = value;
            }
        }
        public Bird() : this("No name", "No color", 1, 1) { }
        public Bird(string name, string color, int speed, int height) : base("Bird", name, color, speed)
        {
            FlightAltitude = height;
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("At an altitude of " + FlightAltitude);
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Flight altitude: " + FlightAltitude);
        }
        public override void Say()
        {
            Console.WriteLine("*Chirping*");
        }
    }
}
