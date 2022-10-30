using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Area
    {

        static void Main(string[] args)
        {
            Console.Write("Enter Radius: ");
            double rad = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * rad * rad;
            Console.WriteLine("Area of circle is: " + area);
        }
    }
}

