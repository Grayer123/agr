public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // sort + two pointers
        // tc:O(nlogn); sc:O(n)
        if(nums == null || nums.Length < 2) {
            return new int[0];
        }
        int[] sortedArr = new int[nums.Length];
        Array.Copy(nums, sortedArr, nums.Length);
        Array.Sort(sortedArr);
        
        int start = 0, end = sortedArr.Length - 1;
        while(start < end) {
            if(sortedArr[start] < target - sortedArr[end]) {
                start++;
            }
            else if(sortedArr[start] == target - sortedArr[end]) {
                int idx1 = Array.IndexOf(nums, sortedArr[start]);
                int idx2 = Array.LastIndexOf(nums, sortedArr[end]);
                return new int[] { Math.Min(idx1, idx2), Math.Max(idx1, idx2) };
            }
            else {
                end--;
            }
        }
        return new int[0];
    }
}