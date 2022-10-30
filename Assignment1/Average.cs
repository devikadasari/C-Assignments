using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Q2
        {
            static void Main(string[] args)
            {
            int n1, n2, n3, n4, n5; int  largest =0;
                Console.WriteLine("enter number n1");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter number n2");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter number n3");
                n3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter number n4");
                n4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter number n5");
                n5 = Convert.ToInt32(Console.ReadLine());
            
        if(n1>n2 && n1>n3 &&n1>n4&&n1>n5)
            
            largest=n1;
            
         else if(n2>n1&&n2>n3&&n2>n4&&n2>n5)
            
            largest=n2;
            
         else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5)
              
             largest = n3;
             
          else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5)

    largest = n4;

else if(n5>n1&&n5>n2&&n5>n3&&n5>n4)

    largest = n5;
        Console.WriteLine("largest is :" +largest);
            Console.ReadKey();


         }
         }
         }

    
    
    

    

