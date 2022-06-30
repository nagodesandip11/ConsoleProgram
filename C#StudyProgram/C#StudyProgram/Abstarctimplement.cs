using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
   abstract class Abstarct1
    {
        public abstract void add();
        public void subtract()
        {
            Console.WriteLine("Sutraction is"+(20-10));
        }
    }
    class Abstarctimplement : Abstarct1
    {
        public override void add()
        {
            Console.WriteLine("Addition is="+(10+20));

        }
        public static void Main(string[] args)
        {
            Abstarctimplement obj = new Abstarctimplement(); 
            obj.subtract();
        }
    }
}
