public class Solution {
    public int SearchInsert(int[] nums, int target) {
        //tc:O(lgn); sc:O(1)
        if(nums.Length == 0){
            return 0; //corner case
        }
        int start = 0, end = nums.Length - 1;
        while(start + 1 < end){
            int mid = start + (end - start) / 2;
            if(nums[mid] < target){
                start = mid;
            }
            else{
                end = mid;
            }
        }
        if(nums[end] < target){
            return end + 1;
        }
        else if(nums[end] == target){
            return end;
        }
        else if(nums[start] < target){
            return start + 1;
        }
        return start;
    }
}