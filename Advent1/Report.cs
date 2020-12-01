using System;

namespace Advent1
{
    public class Report
    {
        static void Main(string[] args)
        {
        }

        public int findSum(int[] input)
        {
            int totalNumber = 0;
            foreach (int number in input)
            {
                foreach (int otherNumber in input)
                {
                    if (number + otherNumber == 2020)
                    {
                        totalNumber = number * otherNumber;
                    }
                }
            }
            return totalNumber;
        }
    }
}
