public class Solution {
    public int FindKthSmallest(int[] nums, int k) {
        // quick select
        // tc:O(n); sc:O(1)
        if(nums == null || nums.Length == 0) {
            return int.MinValue;
        }
        return QuickSelect(nums, 0, nums.Length - 1, k);    
    }
    private int QuickSelect(int[] nums, int start, int end, int k) {
        if(start >= end) {
            return nums[start];
        }
        int pivot = nums[start + (end - start) / 2];
        int left = start, right = end;
        
        while(left <= right) {
            while(left <= right && nums[left] < pivot) {
                left++;
            }
            while(left <= right && nums[right] > pivot) {
                right--;
            }
            if(left <= right) {
                int tmp = nums[left];
                nums[left] = nums[right];
                nums[right] = tmp;
                left++;
                right--;
            }
        }

        if(right >= start && right - start + 1 >= k) {
            return QuickSelect(nums, start, right, k);
        }
        // when nums[start] -> pivot, and this time left, right, start point to the same
        // left++, right-- -> this time, start > right => thus, right - start + 1 = 0
        // but actually the first part still have nums[start] elem => so seperate them
        else if(start > right) { 
            return QuickSelect(nums, left, end, k - 1);
        }
        else {
            return QuickSelect(nums, right + 1, end, k - (right - start + 1));
        }
    }
}