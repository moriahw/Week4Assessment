using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] CarList = new Car[6];

            Car One = new Car("1", "Chevy");
            Car Two = new Car("2", "Ford");

            Nascar First = new Nascar("12", "Chevy", "Goals");
            Nascar Second = new Nascar("23", "Chevy", "Bodak");
            Nascar Third = new Nascar("34", "Ford", "IssaTeam");
            Nascar Fourth = new Nascar("45", "Ford", "BackLikeJordan");

            CarList[0] = One;
            CarList[1] = Two;
            CarList[2] = First;
            CarList[3] = Second;
            CarList[4] = Third;
            CarList[5] = Fourth;

            //for (int i = 0; i < CarList.Length; i++)
            //{
            //    CarList[i].PrintInfo();
            //}


            foreach (Car c in CarList)
            {
                Console.WriteLine(c.PrintInfo());
            }

        }
    }
}
