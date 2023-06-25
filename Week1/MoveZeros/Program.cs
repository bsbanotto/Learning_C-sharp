using System;

namespace MoveZeros
{
    static class Program
    {
        public static void Main()
        {
            int[] nums1 = { 0, 1, 0, 3, 12 , 7, 0, 42};
            Console.WriteLine("Original List = [" + string.Join(",", nums1) + "]");
            Console.WriteLine("Moved Zeros = [" + string.Join(",", MoveZeros(nums1)) + "]");
        }

        private static int[] MoveZeros(int[] nums1)
        // Move all zeros in a list to the end while maintaining order of other integers
        {
            int i, k = 0;
            int end = nums1.Length;
            // Create list of zeros same length as provided list.
            int[] newList = new int[end];

            for (i = 0; i < end; i++)
            {
                if (nums1[i] != 0)
                {
                    newList[k] = nums1[i];
                    k++;
                }
            }
            return (newList);
        }
    }
}