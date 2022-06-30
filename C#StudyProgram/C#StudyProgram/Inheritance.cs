using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    class Inheritance
    {
        class A
        {
          public  int a = 10;
          protected  int b = 20;
        }
        class B : A 
        {
           void printA()
            {
                Console.WriteLine(a+b);
            }
        }
        class c:B
        {
            void printB()
            {
                Console.WriteLine(a + b);
            }

            public static void Main()
            {

            }
        }
    }
}
