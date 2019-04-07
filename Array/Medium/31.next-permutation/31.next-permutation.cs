/*
 * @lc app=leetcode id=31 lang=csharp
 *
 * [31] Next Permutation
 *
 * https://leetcode.com/problems/next-permutation/description/
 *
 * algorithms
 * Medium (30.22%)
 * Total Accepted:    224.3K
 * Total Submissions: 742K
 * Testcase Example:  '[1,2,3]'
 *
 * Implement next permutation, which rearranges numbers into the
 * lexicographically next greater permutation of numbers.
 * 
 * If such arrangement is not possible, it must rearrange it as the lowest
 * possible order (ie, sorted in ascending order).
 * 
 * The replacement must be in-place and use only constant extra memory.
 * 
 * Here are some examples. Inputs are in the left-hand column and its
 * corresponding outputs are in the right-hand column.
 * 
 * 1,2,3 → 1,3,2
 * 3,2,1 → 1,2,3
 * 1,1,5 → 1,5,1
 * 
 */
public class Solution {
    public void NextPermutation(int[] nums) {
        // permutation
        // tc:O(n); sc:O(1)
        if(nums == null || nums.Length == 0) {
            return;
        }
        int idx = nums.Length - 1;
        while(idx > 0) {
            if(nums[idx - 1] < nums[idx]) {
                break;
            }
            idx--;
        }
        if(idx == 0) { // array is in descending order
            Array.Reverse(nums); 
            return;
        }
        int targetIdx = idx - 1;
        for(int i = nums.Length - 1; i > targetIdx; i--) {
            if(nums[i] > nums[targetIdx]) {
                Swap(nums, i, targetIdx);
                break;
            }
        }
        Array.Reverse(nums, targetIdx + 1, nums.Length - targetIdx - 1);
    }
    
    private void Swap(int[] nums, int idx1, int idx2) {
        int tmp = nums[idx1];
        nums[idx1] = nums[idx2];
        nums[idx2] = tmp;
    }
}


