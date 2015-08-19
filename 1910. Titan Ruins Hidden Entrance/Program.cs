using System;
using System.Linq;

namespace _1910.Titan_Ruins_Hidden_Entrance
{
    class Program
    {
        static void Main(string[] args)
        {
            string sections = Console.ReadLine();
            string[] forces = Console.ReadLine().Split(' ');

            int entrance = 0;
            int maxForce = 0;
            for (int i = 1; i < forces.Length - 1; i++)
            {
                int localForce = Convert.ToInt32(forces[i - 1]) + Convert.ToInt32(forces[i]) + Convert.ToInt32(forces[i + 1]);
                if (maxForce < localForce)
                {
                    maxForce = localForce;
                    entrance = i + 1;
                }
            }
            Console.WriteLine("{0} {1}", maxForce, entrance);
        }
    }
}
