using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Days
{
    public class Day03
    {
        public int zeroCounter = 0;
        public int oneCounter = 0;
        public string gammaRate = string.Empty;
        public string epsilonRate = string.Empty;

        public void CalculatePowerConsumption()
        {
            List<string[]> columns = ParseInput();

            for (int i = 0; i < columns.Count; i++)
            {
                foreach (var num in columns[i])
                {
                    if (num == "0")
                    {
                        zeroCounter++;
                    }
                    else
                    {
                        oneCounter++;
                    }
                }

                if (zeroCounter > oneCounter)
                {
                    gammaRate += "0";
                    epsilonRate += "1";
                    zeroCounter = 0;
                    oneCounter = 0;
                }
                else
                {
                    gammaRate += "1";
                    epsilonRate += "0";
                    zeroCounter = 0;
                    oneCounter = 0;
                }
            }

            var gammaRateDecimal = Convert.ToInt32(gammaRate, 2);
            var epsilonRateDecimal = Convert.ToInt32(epsilonRate, 2);

            Console.WriteLine(gammaRateDecimal * epsilonRateDecimal);
        }

        private static List<string[]> ParseInput()
        {
            string[] input = File.ReadAllLines(@"C:\Dev Projects\AdventOfCodeDay1\AdventOfCodeDay1\Inputs\Day03Input.txt");

            List<string[]> columns = new List<string[]>();

            for (int i = 0; i < input[0].Length; i++)
            {
                string[] column = new string[input[0].Length];
                column = input.Select(n => Convert.ToString(n[i])).ToArray();

                columns.Add(column);
            }

            return columns;
        }
    }
}
