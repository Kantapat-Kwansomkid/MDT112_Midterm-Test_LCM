using System;

namespace MDT112_Midterm_Test_LCM
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, lcm;

            Console.WriteLine("Please input number a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input number b : ");
            b = int.Parse(Console.ReadLine());

            while(b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            lcm = (a * b) / a;

            Console.WriteLine("The least common multiple (L.C.M.) is {0}",lcm);
            Console.ReadLine();
        }
    }
}
