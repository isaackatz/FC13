using System;
using System.ComponentModel.Design.Serialization;

namespace FC21
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0, b = Math.PI;
            Console.WriteLine("a = {0}     b = {1}", a, b);
            double e = 1.0E-3;
            Console.WriteLine("e = {0}", e);
            bool flag = false;
            double c = Div2(a, b, e, ref flag);
            if (flag)
            {
                Console.WriteLine("c = {0}", c);
                Console.WriteLine("F(c) = {0}", F(c));
            }

            Console.ReadKey();
        }

        static double F(double x)
        {
            return Math.Log(x) - Math.Sin(x);
        }

        static double Div2(double min, double max, double acc, ref bool f)
        {
            double root = 0.0;
            while ((max - min) > acc)
            {
                root = (min + max) / 2.0;

                if (F(root) * F(min) < 0.0)
                {
                    max = root;
                }
                else if (F(root) * F(max) < 0.0)
                {
                    min = root;
                }
            }

            f = true;

            return root;
        }
    }
}
