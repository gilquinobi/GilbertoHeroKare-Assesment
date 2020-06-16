using System;

namespace GilbertoHeroKare.Helpers
{
    public static class MathHelper
    {
        public static decimal GetMedian(int [] numbers)
        {
            // Create a copy of the input, and sort the copy
            Array.Sort(numbers);

            int count = numbers.Length;
            if (count == 0)
            {
                return 0;
            }
            else if (count % 2 == 0)
            {
                // count is even, average two middle elements
                int a = numbers[count / 2 - 1];
                int b = numbers[count / 2];
                return (a + b) / 2m;
            }
            else
            {
                // count is odd, return the middle element
                return numbers[count / 2];
            }
        }


    }
}