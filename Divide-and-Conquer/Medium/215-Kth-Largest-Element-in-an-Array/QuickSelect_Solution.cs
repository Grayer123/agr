public class Solution {
    public int FindKthLargest(int[] nums, int k) {
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
        if(end - left + 1 >= k) {
            return QuickSelect(nums, left, end, k);
        }
        else {
            // left, right might not be adjacent (left, x, right) => so use left - 1 instead of right
            // x = k-(end-left+1): means kth elem not in right side; find xth largest in left side
            return QuickSelect(nums, start, left - 1, k - (end - left + 1));
        }
    }
}