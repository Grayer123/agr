public class Solution {
    public int RemoveDuplicates(int[] nums) {
        //array
        //tc:O(n); sc:O(1)
        if(nums == null || nums.Length == 0){
            return 0;
        }
        int prev = nums[0], cur = 1, times = 1;
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] == prev){
                if(times == 1){
                    nums[cur++] = nums[i];
                    times++;
                }
                // else{
                //     continue;
                // }
            }
            else{
                nums[cur++] = nums[i];
                prev = nums[i];
                times = 1;
            }
        }
        return cur;
    }
}