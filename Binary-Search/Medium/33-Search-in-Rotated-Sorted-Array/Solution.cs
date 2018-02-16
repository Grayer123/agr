public class Solution {
    public int Search(int[] nums, int target) {
        //binary search
        //tc:O(lgn); sc:O(1)
        if(nums == null || nums.Length == 0){ //corner case
            return -1;
        }
        int start = 0, end = nums.Length - 1;
        int cmp = nums[end];
        while(start < end){
            int mid = start + (end - start) / 2;
            if(nums[mid] == target){
                return mid;
            }
            if(nums[mid] < cmp){ //pivot has occurred before mid
                if(target > nums[mid] && target <= cmp){
                    start = mid + 1;
                }
                else{ //target is after pivot
                    end = mid;
                }
            } 
            else{  //pivot has yet come
                if(target > cmp && target < nums[mid]){
                    end = mid;
                }
                else{
                    start = mid + 1;
                }
            }
        }
        return nums[start] == target ? start : -1;
    }
}