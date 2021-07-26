using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new A1();
            var a2 = new A2();
            var a3 = new A3();

            List<B> fff = new List<B>();
            fff.Add(a1);
            fff.Add(a2);


            Some(a1);
            Some(a2);
            Some(a3);
        }

        public static void Some(B a)
        {
            Console.WriteLine(a);
        }
    }

    public class A1 : B
    {
        public int MyProperty { get; set; }
    }

    public class A2 : B
    {
    }

    public class A3 : B
    {
    }

    public class B
    {
    }
}
