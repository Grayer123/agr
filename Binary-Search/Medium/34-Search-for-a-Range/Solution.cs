public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        //binary search
        //tc:O(lgn); sc:O(1)
        if(nums == null || nums.Length == 0){
            return new int[]{-1, -1};
        }
        int start = 0, end = nums.Length - 1;
        while(start < end){
            int mid = start + (end - start) / 2;
            if(nums[mid] == target){
                int low = mid, high = mid;
                while(low >= start && nums[low] == target){
                    low--;
                }

                while(high <= end && nums[high] == target){
                    high++;
                }
                return new int[]{low + 1, high - 1};
            }
            else if(nums[mid] < target){
                start = mid + 1;
            }
            else{
                end = mid;
            }
        }
        return nums[start] == target ? new int[]{start, start} : new int[]{-1, -1};
    }
}