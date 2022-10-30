using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Class2
    {
        
        public void Show(params object[] val)
        {
            

            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
              
            }
        }

        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            class2.Show("64,34,45,78");
        }

    }
}
