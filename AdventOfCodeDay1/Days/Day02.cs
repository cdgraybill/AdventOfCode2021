using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Days
{
    public class Day02
    {
        public int distance = 0;
        public int depth = 0;

        public void CalculateAnswer()
        {
            List<object[]> moves = ParseInput();

            foreach(var move in moves)
            {
                if ((string)move[0] == "f")
                {
                    distance += (int)move[1];
                }
                else if ((string)move[0] == "d")
                {
                    depth += (int)move[1];
                }
                else
                {
                    depth -= (int)move[1];
                }
            }

            Console.WriteLine(distance * depth);
        }

        private static List<object[]> ParseInput()
        {
            string[] input = File.ReadAllLines(@"C:\Dev Projects\AdventOfCodeDay1\AdventOfCodeDay1\Inputs\Day02Input.txt");
            string[] directions = input.Select(n => Convert.ToString(n[0])).ToArray();
            int[] measurements = input.Select(n => Convert.ToInt32(n[n.Length - 1] - 48)).ToArray();

            List<object[]> moves = new List<object[]>();

            for (int i = 0; i < directions.Length; i++)
            {
                object[] move = new object[2];

                move[0] = directions[i];
                move[1] = measurements[i];

                moves.Add(move);
            }

            return moves;
        }
    }
}
