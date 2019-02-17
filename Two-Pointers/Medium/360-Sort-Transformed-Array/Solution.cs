public class Solution {
    public int[] SortTransformedArray(int[] nums, int a, int b, int c) {
        // math: parabola; two opposite pointers
        // tc:O(n); sc:O(1)
        if(nums == null || nums.Length == 0) {
            return new int[0];
        }
        int left = 0, right = nums.Length - 1;
        int cur = -1;
        int[] res = new int[nums.Length];

        while(left <= right) {
            int leftNum = a * nums[left] * nums[left] + b * nums[left] + c;
            int rightNum = a * nums[right] * nums[right] + b * nums[right] + c;
            if(a >= 0) { // cancave: high-low-high
                cur = cur == -1 ? res.Length - 1 : cur;
                if(leftNum <= rightNum) {
                    res[cur] = rightNum;
                    right--;
                }
                else {
                    res[cur] = leftNum;
                    left++;
                }
                cur--;
            }
            else if(a < 0) { // convex: low-high-low
                cur = cur == -1 ? 0 : cur;
                if(leftNum <= rightNum) {
                    res[cur++] = leftNum;
                    left++;
                }
                else {
                    res[cur++] = rightNum;
                    right--;
                }
            }
        }
        return res;
    }
}