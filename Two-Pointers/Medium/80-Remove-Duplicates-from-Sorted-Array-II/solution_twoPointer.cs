public class Solution {
    public int RemoveDuplicates(int[] nums) {
        //array; two pointers
        //tc:O(n); sc:O(1)
        if(nums == null || nums.Length == 0){
            return 0;
        }
        
        int slow = 0, fast = 1, times = 0;
        while(slow <= fast && fast < nums.Length) {
            if(nums[slow] == nums[fast]) {
                if(times == 0) {
                    times++;
                    nums[++slow] = nums[fast];
                }
            }
            else {
                times = 0;
                nums[++slow] = nums[fast];
            }
            fast++;
        }
        return slow + 1;
    }
}