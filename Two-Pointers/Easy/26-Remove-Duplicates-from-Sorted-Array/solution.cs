public class Solution {
    public int RemoveDuplicates(int[] nums) {
        //two pointers
        //tc:O(n); sc:O(1)
        if(nums == null || nums.Length == 0){ //corner case
            return 0;
        }
        int slow = 0, fast = 0;
        
        while(slow <= fast && fast < nums.Length) {
            if(nums[slow] != nums[fast]) {
                nums[++slow] = nums[fast];
            }
            fast++;
        }
        return slow + 1;
    }
}