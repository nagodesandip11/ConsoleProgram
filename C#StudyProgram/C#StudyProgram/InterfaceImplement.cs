using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
 //abstract  class Abstarcttion
 //   {
 //       public abstract void add();
 //       public void sub()
 //       {
 //           Console.WriteLine("Subtraction");
 //       } 
 //   }
 //   class B : Abstarcttion
 //   {
 //       public override void add()
 //       {
 //           throw new NotImplementedException();
 //       } 
 //       public void mult()
 //       { 
        
 //       }

        interface interface1
        {
            void add(int a,int b);
          void Sub();
        }
        class InterfaceImplement : interface1
        {
            public void add(int a,int b)
            {
                Console.WriteLine("Addition is="+(a+b));
            }
        static void Main(string[] args)
        {
            InterfaceImplement obj = new InterfaceImplement();
                obj.add(10,20);
         }

        public void Sub()
        {
            throw new NotImplementedException();
        }
    }

    //}
}
