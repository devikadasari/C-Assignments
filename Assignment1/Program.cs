using  System;
using System.ComponentModel;

namespace Assignment1
{
     internal class calculator
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            Console.WriteLine("calculator program");
            Console.WriteLine("enter number 1");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter number 2");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter an option ");
            Console.WriteLine("+ : Add");
            Console.WriteLine("-: subtract");
            Console.WriteLine("* : Multiply");
            Console.WriteLine("/: Division");
            Console.Write("enter an option ");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("your result :Add=" + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("your result : subtract=" + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("your result : Multiply=" + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine("your result : Division=" + result);
                    break;
                default:
                    Console.WriteLine("not an valid option");
                    break;
            }
                    Console.ReadKey();
            
        }
    }
}






        















            
                    
    


