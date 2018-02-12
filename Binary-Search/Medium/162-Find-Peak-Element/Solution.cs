public class Solution {
    public int FindPeakElement(int[] nums) {
        //binary search
        //tc:O(lgn); sc:O(1)
        if(nums == null || nums.Length == 0){ //no available solution
            return -1;
        }
        int len = nums.Length;
        int start = 0, end = len - 1;
        while(start < end){
            int mid = start + (end - start) / 2; //avoid overflow
            if(mid == 0){  //corner case: in this case, we could not do nums[mid-1]
                if(nums[mid] > nums[mid + 1]){
                    end--;
                }
                else{
                    start++;
                }
                continue;
            }
            if(nums[mid] < nums[mid + 1]){ //up trend
                start = mid + 1;
            }
            else{ //nums[mid] > nums[mid+1]; down trend
                if(nums[mid] > nums[mid - 1]){ //find the result
                    return mid;
                }
                else{
                    end = mid;
                }              
            }
        }
        return start;
    }
}