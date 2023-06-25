using System;

namespace MergeLists
{
    static class Program
    {
        public static void Main()
        {
            int[] nums1 = { 2, 7, 11, 15 };
            int[] nums2 = { 3, 5, 13 };
            Console.WriteLine("nums1 = [" + string.Join(",", nums1) + "]");
            Console.WriteLine("nums2 = [" + string.Join(",", nums2) + "]");
            Console.WriteLine("Merged List = [" + string.Join(",",MergeLists(nums1,nums2)) + "]");
        }

        static int[] MergeLists(int[] nums1, int []nums2)
            // Merge two sorted lists
        {
            int i = 0, j = 0, k = 0;
            int len1 = nums1.Length;
            int len2 = nums2.Length;
            // Console.WriteLine($"Merged Length = {len1 + len2}");
            int []mergedList = new int[len1 + len2];

            // While there is a comparison to be made, do it
            while (i < len1 && j < len2)
            {
                if (nums1[i] < nums2[j])
                    mergedList[k++] = nums1[i++];
                else
                    mergedList[k++] = nums2[j++];
            }

            // If nums1 is longer, store remaining elements
            while (i < len1)
                mergedList[k++] = nums1[i++];
            // If nums2 is longer, store remaining elements
            while (j < len2)
                mergedList[k++] = nums2[j++];
            
            return (mergedList);
        }
    }
}
