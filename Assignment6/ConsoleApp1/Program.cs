
using System;
namespace MulticastDelegateDemo
{
    public class Anyone
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine($"Area is {Width * Height}");
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine($"Perimeter is {2 * (Width + Height)}");
        }
        static void Main(string[] args)
        {
            Anyone rect = new Anyone();
            rect.GetArea(23.45, 67.89);
            rect.GetPerimeter(23.45, 67.89);
            Console.ReadKey();
        }
    }
}