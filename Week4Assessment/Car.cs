using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Assessment
{
    class Car
    {
        private string vin;
        private string make;

        public string VIN
        {
            set { vin = value; }
            get { return vin; }
        }

        public string Make
        {
            set { make = value; }
            get { return make; }
        }

        public Car()
        {
            VIN = "";
            Make = "";
        }

        public Car(string carvin, string carmake)
        {
            VIN = carvin;
            Make = carmake;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(VIN + " " + Make);
        }
    }
}
