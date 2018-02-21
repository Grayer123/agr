public class Solution {
    public int FindDuplicate(int[] nums) {
        //binary search
        //tc:O(nlgn); sc:O(1)
        if(nums == null || nums.Length < 2){
            throw new Exception("Invalid arguments.");
        }
        int start = 1, end = nums.Length - 1;
        while(start < end){
            int mid = start + (end - start) / 2;
            int count = CountSmaller(ref nums, mid, start);
            if(count <= mid - start + 1){ //duplicates in (mid, end]
                start = mid + 1;
            }
            else { //duplicates in [start, mid]
                end = mid;
            }
        }
        return start;
    }
    
    //auxiliary function to calculate how many: start <= num <= mid
    private int CountSmaller(ref int[] nums, int mid, int start){
        int count = 0;
        foreach(int num in nums){
            if(num <= mid && num >= start){
                count++;
            }
        }
        return count;
    }
}