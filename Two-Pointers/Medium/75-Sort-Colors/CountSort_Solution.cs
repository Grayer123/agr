public class Solution {
    public void SortColors(int[] nums) {
        //counting sort; two times iterations
        //TC:O(2n); SC:O(1)
        if(nums == null || nums.Length == 0) { //corner case
            return;
        }
        int num0 = 0, num1 = 0, num2 = 0;
        foreach(int num in nums) {
            if(num == 0) {
                num0++;
            }
            else if(num == 1) {
                num1++;
            }
            else{
                num2++;
            }
        }
        int count = 0;
        while(num0-- > 0) {
            nums[count++] = 0;
        }
        while(num1-- > 0) {
            nums[count++] = 1;
        }
        while(num2-- > 0) {
            nums[count++] = 2;
        }
    }
}