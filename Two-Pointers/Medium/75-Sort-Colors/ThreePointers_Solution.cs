public class Solution {
    public void SortColors(int[] nums) {
        //three pointers; one times iterations
        //TC:O(n); SC:O(1)
        if(nums == null || nums.Length == 0) { //corner case
            return;
        }
        int pl = 0, pr = nums.Length - 1, cur = 0;
        while(cur <= pr) {
            if(nums[cur] == 0) {
                Swap(ref nums, pl, cur);
                pl++;
                cur++;
            }
            else if(nums[cur] == 1) {
                cur++;
            }
            else { //when nums[cur]==2,the elem exchanged from pr could be anything, so cur could not ++
                Swap(ref nums, cur, pr);
                pr--;
            }
        }
    }
    
    private void Swap(ref int[] nums, int idx1, int idx2) {
        int tmp = nums[idx1];
        nums[idx1] = nums[idx2];
        nums[idx2] = tmp;
    }
}