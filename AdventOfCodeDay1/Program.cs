using System;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateMeasurements();
        }

        static int CalculateMeasurements()
        {
            var numberOfLargerMeasurements = 0;
            var measurements = ParseInput();

            for (int i = 0; i < measurements.Length; i++)
            {
                if (i == 1999)
                {
                    break;
                } 
                else if (measurements[i] < measurements[i + 1])
                {
                    numberOfLargerMeasurements++;
                }
            }

            Console.WriteLine(numberOfLargerMeasurements);
            return numberOfLargerMeasurements;
        }

        static int[] ParseInput()
        {
            string[] input = File.ReadAllLines(@"C:\Dev Projects\AdventOfCodeDay1\AdventOfCodeDay1\Day01Input.txt");
            int[] measurements = input.Select(n => Convert.ToInt32(n)).ToArray();

            return measurements;
        }
    }
}
