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

        static private List<float> floatList = new List<float>() { (float)Math.PI, 0.5f, 0.1234f, 0.3f, 0.01f, 2f, 3f };
        static private List<double> doubleList = new List<double>() { Math.PI, 0.5d, 0.1234d, 0.3d, 0.01d, 2d, 3d };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello floating point!");

            foreach (var floatValue in floatList)
            {
                Console.WriteLine($"AddMilF({floatValue}) is {AddMilF(floatValue)}");
            }

            foreach (var doubleValue in doubleList)
            {
                Console.WriteLine($"AddMilD({doubleValue}) is {AddMilD(doubleValue)}");
            }
        }
    }
}
