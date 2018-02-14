public class Solution {
    public int RemoveDuplicates(int[] nums) {
        //array;
        //tc:O(n); sc:O(1)
        if(nums == null || nums.Length == 0){ //corner case
            return 0;
        }
        int prev = nums[0], cur = 1;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == prev){
                continue;
            }
            nums[cur++] = nums[i];
            prev = nums[i];
        }
        return cur;
    }
}