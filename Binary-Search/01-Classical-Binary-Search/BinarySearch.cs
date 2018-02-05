using System;

namespace ClassicBinarySearch
{
    public static class BinarySearch
    {
        public static int DoBinarySearch<T>(T[] nums, T target) where T: IComparable<T>
        {
            if(nums.Length == 0)
            {
                return -1; // corner case
            }
            int start = 0, end = nums.Length - 1;
            int mid;

            while(start + 1 < end)
            {
                mid = start + (end - start) / 2; // prevent overflow like (start+end)/2

                if(nums[mid].CompareTo(target) == 0) // nums[mid] == target
                {
                    end = mid; // it might have multiple matches, need to find the first one
                }
                else if(nums[mid].CompareTo(target) < 0) // nums[mid] < target
                {
                    start = mid;
                }
                else // nums[mid] > target
                {
                    end = mid;
                }
            }
            if(nums[start].CompareTo(target) == 0) // nums[start] == target
            {
                return start;
            }
            if (nums[end].CompareTo(target) == 0) // nums[end] == target
            {
                return end;
            }
            return -1;
        }
    }
}
