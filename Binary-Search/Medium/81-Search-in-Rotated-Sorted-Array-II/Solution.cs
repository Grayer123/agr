public class Solution {
    public bool Search(int[] nums, int target) {
        //binary search; 
        //choose the last elem as the cmp object; worst case TC degraded to O(n)
        if(nums == null || nums.Length == 0){
            return false;
        }
        int start = 0, end = nums.Length - 1;
        int cmpObj = nums[end];
        while(start < end){
            int mid = start + (end - start) / 2;
            if(nums[mid] == target){
                return true;
            }
            if(nums[mid] == cmpObj){
                if(nums[start] == cmpObj){
                    start++;
                }
                else if(nums[end] == cmpObj){
                    end--;
                }
            }
            else if(nums[mid] < cmpObj){ //pivot has occurred
                if(target > nums[mid] && target <= cmpObj){
                    start = mid + 1;
                }
                else{
                    end = mid;
                }
            }
            else{ //nums[mid] > cmpObj: pivot has occurred
                if(target > cmpObj && target < nums[mid]){
                    end = mid;
                }
                else{
                    start = mid + 1;
                }
            }
        }
        return nums[start] == target;
    }
}