public class Solution {
    public int FindMin(int[] nums) {
       //binary search
        //tc:O(lgn), wrorst case:O(n) -> too many duplicates; SC:O(1)
        if(nums == null || nums.Length == 0){
            throw new Exception("Invalid arguments");
        }
        int len = nums.Length;
        int cmpObj = nums[len - 1];
        int start = 0, end = len - 1; 
        while(start < end){
            int mid = start + (end - start) / 2;
            if(nums[mid] == cmpObj){ //if nums[mid] == cmpObj, then at least one from nums[start] or nums[end] == cmpObj
                if(nums[start] == cmpObj){
                    start++;
                }
                else if(nums[end] == cmpObj){
                    end--;
                }
            }
            else if(nums[mid] < cmpObj){ //pivot point has occured
                end = mid;               
            }
            else{
                 start = mid + 1;// pivot point has not occured
            }
        }
        return nums[start];
    }
}