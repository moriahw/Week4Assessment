using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Assessment
{
    class Nascar:Car
    {
        private string teamname;

        public string TeamName
        {
            set { teamname = value; }
            get { return teamname; }
        }

        public Nascar()
        {
           TeamName = "";
        }

        public Nascar(string name)
        {
           TeamName = name;
        }

        public Nascar(string carvin, string carmake, string name)
        {
            VIN = carvin;
            Make = carmake;
            TeamName = name;
        }

        public override void PrintInfo()
        {
            Console.WriteLine(VIN + " " + Make + " " + TeamName);
        }

    }
}
