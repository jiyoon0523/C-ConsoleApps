using System;
using System.Collections.Generic;
using static System.Math;

namespace FloatingPointStudy
{
    class Program
    {
        static float AddMilF(float a)
        {
            int count = 0;
            float result = 0.0f;
            while (count < 1000000)
            {
                result += a;
                count++;
            }
            return result;
        }

        static double AddMilD(double a)
        {
            int count = 0;
            double result = 0.0f;
            while (count < 1000000)
            {
                result += a;
                count++;
            }
            return result;
        }

        static private List<double> doubleList = new List<double>() { 0.5d, 3d, Math.PI, 0.1234d, 0.3d, 0.01d };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello floating point!");
            Console.WriteLine("");

            foreach (var doubleValue in doubleList)
            {
                Console.WriteLine($"AddMilF({(float)doubleValue}) is {AddMilF((float)doubleValue)}");
                Console.WriteLine($"AddMilD({doubleValue}) is {AddMilD(doubleValue)}");
                Console.WriteLine("");
            }
        }
    }
}
