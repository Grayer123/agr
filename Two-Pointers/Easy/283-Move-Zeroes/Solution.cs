public class Solution {
    public void MoveZeroes(int[] nums) {
        // two pointers: same direction
        // tc:O(n); sc:O(1)
        if(nums == null || nums.Length < 2) { //corner case
            return;
        }
        int slow = 0, fast = 0; //slow points to 0 elem; fast points to non-0 elem
        while(fast < nums.Length) {
            if(nums[fast] != 0) {
                if(slow != fast) { // avoid wrost case 1,1,1,1,0
                    nums[slow] = nums[fast];
                }
                slow++; 
            }
            fast++;
        }
        
        while(slow < nums.Length) { // assign 0 to end elems
            if(nums[slow] != 0) {
                nums[slow] = 0;
                slow++;
            }
        }
    }
}