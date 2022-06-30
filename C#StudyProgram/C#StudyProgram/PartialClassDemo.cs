using System;
using System.Collections.Generic;

namespace DemoConsole
{

    public partial class A
    {
        public int Add(int a,int b)
        {
            return (a+b);
        }
    }
    public partial class A
    {
        public int sub(int a, int b)
        {
            return (a - b);
        }
    }


    class PartialClassDemo
    {
        static void Main(string[] args)
        {
            //A obj = new A();
            //Console.WriteLine("Addition Is="+obj.Add(10,20));
            //Console.WriteLine("Subtraction Is="+obj.sub(20,10));
            ReverseStringWithInbuiltMethod("CSharpCorner");
            ReverseStringWithoutInbuiltMethod("SANDIP");
            Console.ReadKey();
        }
        private static void ReverseStringWithInbuiltMethod(string stringInput)
        {
            // With Inbuilt Method Array.Reverse Method  
            char[] charArray = stringInput.ToCharArray();
            Array.Reverse(charArray);
            string str = new string(charArray);
            Console.WriteLine(str);
        }


        private static void ReverseStringWithoutInbuiltMethod(string stringInput)
        {
            // Reverse using While loop  
            string reversestring = "";
            int length;

            length = stringInput.Length - 1;

            while (length >= 0)
            {
                reversestring = reversestring + stringInput[length];
                length--;
            }
            Console.WriteLine(reversestring);

            Console.ReadLine();

        }
    }
}
