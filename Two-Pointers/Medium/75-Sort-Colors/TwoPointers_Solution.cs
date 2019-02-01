public class Solution {
    public void SortColors(int[] nums) {
        //two pointers; two times iterations
        //TC:O(n); SC:O(1)
        if(nums == null || nums.Length == 0) { //corner case
            return;
        }
        int left = 0, right = nums.Length - 1;
        partition(nums, ref left, right, 0);  // first iteration: partition 0
        partition(nums, ref left, right, 1);  // second iteration: partition 1
        
    }
            
    private void partition(int[] nums, ref int start, int end, int target) {
        while(start <= end) {
            while(start <= end && nums[start] == target) {
                start++;
            }
            while(start <= end && nums[end] != target) {
                end--;
            }
            if(start <= end) {
                int tmp = nums[start];
                nums[start] = nums[end];
                nums[end] = tmp;
                start++;
                end--;
            }
        } 
    }
}