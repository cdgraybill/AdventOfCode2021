using System;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateMeasurements(); // Answer for Part 1
            CalculateSumOfMeasurements(); // Answer for Part 2
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

        static int CalculateSumOfMeasurements()
        {
            var numberOfLargerMeasurements = 0;
            var measurements = ParseInput();

            for (int i = 0; i < measurements.Length; i++)
            {
                try
                {
                    int sumOne = measurements[i] + measurements[i + 1] + measurements[i + 2];
                    int sumTwo = measurements[i + 1] + measurements[i + 2] + measurements[i + 3];

                    if (sumOne < sumTwo)
                    {
                        numberOfLargerMeasurements++;
                    }
                }
                catch
                {
                    break;
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
