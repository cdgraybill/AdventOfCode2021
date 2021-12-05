using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2021.Days
{
    public class Day01
    {
        public int numberOfLargerMeasurements = 0;
        public int[] measurements = ParseInput();

        public int CalculateMeasurements()
        {
            for (int i = 1; i < measurements.Length; i++)
            {
                if (measurements[i - 1] < measurements[i])
                {
                    numberOfLargerMeasurements++;
                }
            }

            DisplayAnswer(numberOfLargerMeasurements);
            return numberOfLargerMeasurements;
        }

        public int CalculateSumOfMeasurements()
        {
            for (int i = 3; i < measurements.Length; i++)
            {
                int sumOne = measurements[i - 3] + measurements[i - 2] + measurements[i - 1];
                int sumTwo = measurements[i - 2] + measurements[i - 1] + measurements[i];

                if (sumOne < sumTwo)
                {
                    numberOfLargerMeasurements++;
                }
            }

            DisplayAnswer(numberOfLargerMeasurements);
            return numberOfLargerMeasurements;
        }

        private static int[] ParseInput()
        {
            string[] input = File.ReadAllLines(@"C:\Dev Projects\AdventOfCodeDay1\AdventOfCodeDay1\Inputs\Day01Input.txt");
            int[] measurements = input.Select(n => Convert.ToInt32(n)).ToArray();

            return measurements;
        }

        private void DisplayAnswer(int answer)
        {
            Console.WriteLine(answer);
            answer = 0;
        }
    }
}
