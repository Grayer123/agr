public class Solution {
    public int FindMin(int[] nums) {
        //binary search; using the last elem as the compObj
        //tc:O(lgn); sc:O(1)
        if(nums == null || nums.Length == 0){
            throw new Exception("Invalid argument");
        }
        int start = 0, end = nums.Length - 1;
        int compObj = nums[end];
        while(start < end){
            int mid = start + (end - start) / 2;
            if(nums[mid] > compObj){ //the pivot has not occur
                start = mid + 1;
            }
            else{
                end = mid;
            }
        }
        return nums[start];
    }
}