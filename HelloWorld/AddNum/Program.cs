using System;

namespace AddNum
{
    static class Program
    {
        public static void Main()
        {
            int[] nums = {2, 7, 11, 15};
            int target = 26;
            Console.WriteLine("Results: [" + string.Join(",",AddNum(nums, target)) + "]");
        }

        private static int[] AddNum(int[] nums, int target)
        // Returns the indices of the first two numbers in an array that sum to target
        // Otherwise, returns [-1, -1]
        {
            int start;
            int end = nums.Length - 1;

            int[] results = { -1, -1 };

            for (start = 0; start <= end; start++)
            {
                int index;
                for (index = start; index <= end; index++)
                {
                    if (nums[start] + nums[index] == target)
                    {
                        return(new [] {start, index});
                    }
                }
            }
            return (results);
        }
    }
}