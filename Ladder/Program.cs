using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');

            double a = double.Parse(inputs[0]);
            double v = double.Parse(inputs[1]);            

            Console.WriteLine(Math.Ceiling((a / Math.Tan(v * (Math.PI / 180))) / Math.Cos(v * (Math.PI / 180))));
        }
    }
}
