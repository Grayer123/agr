public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        //forward window-two pointers
        //tc:O(n); sc:O(1)
        if(nums == null || nums.Length == 0){ //corner case
            return 0;
        }
        int len = nums.Length;
        int slow = 0, fast = 0, res = Int32.MaxValue;
        long sum = 0;
        while(slow < len){
            while(fast < len && sum < s){
                sum += nums[fast++];
            }
            if(sum < s){
                break;
            }
            int count = fast -slow; //fast here would be (index + 1)
            res = res > count ? count : res;
            sum -= nums[slow];
            slow++;
        }
        return res == Int32.MaxValue ? 0 : res;
    }
}