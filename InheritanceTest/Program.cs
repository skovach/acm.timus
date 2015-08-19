using System;

namespace InheritanceTest
{

    class Base
    {
        public virtual void Go()
        {
            Console.WriteLine("Base Go");
        }

    }

    class A : Base
    {
        new public void  Go()
        {
            Console.WriteLine("A Go");
        }

    }

    class B : Base
    {
        public override void Go()
        {
            Console.WriteLine("B Go");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base instanceA = new A();
            Base instanceB = new B();
            instanceA.Go();
            instanceB.Go();

            A shadow = new A();
            shadow.Go();
        }
    }
}
