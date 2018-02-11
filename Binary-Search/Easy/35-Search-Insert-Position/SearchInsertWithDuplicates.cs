public class Solution {
    public int SearchInsertWithDuplicates(int[] nums, int target)
        {
            //tc:O(lgn); sc:O(1)
            if (nums.Length == 0)
            {
                return 0; //corner case
            }
            int start = 0, end = nums.Length - 1;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }
            if (nums[start] >= target)
            {
                return start;
            }
            else
            {
                return start + 1;
            }
        }
}