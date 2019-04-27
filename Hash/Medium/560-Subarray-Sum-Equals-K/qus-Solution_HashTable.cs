/*
 * @lc app=leetcode id=560 lang=csharp
 *
 * [560] Subarray Sum Equals K
 *
 * https://leetcode.com/problems/subarray-sum-equals-k/description/
 *
 * algorithms
 * Medium (41.72%)
 * Total Accepted:    85.7K
 * Total Submissions: 205.3K
 * Testcase Example:  '[1,1,1]\n2'
 *
 * Given an array of integers and an integer k, you need to find the total
 * number of continuous subarrays whose sum equals to k.
 * 
 * Example 1:
 * 
 * Input:nums = [1,1,1], k = 2
 * Output: 2
 * 
 * 
 * 
 * Note:
 * 
 * The length of the array is in range [1, 20,000].
 * The range of numbers in the array is [-1000, 1000] and the range of the
 * integer k is [-1e7, 1e7].
 * 
 * 
 * 
 */
public class Solution {
    public int SubarraySum(int[] nums, int k) {
        // prefixSum + hashtable
        // tc:O(n); sc:O(n)
        if(nums == null || nums.Length == 0) {
            return 0;
        }
        // int[] prefixSum = new int[nums.Length + 1];  // need to count times => use dictionary as prefixsum array
        // prefixSum[0] = 0;
        Dictionary<int, int> prefixSumDict = new Dictionary<int, int>(); // <sum, count>
        prefixSumDict.Add(0, 1); // prepare: prefix = 0, appear time: 1 (for some case like nums[0] == k)
        int sum = 0;
        int res = 0;
        foreach(int num in nums) {
            sum += num;
            int target = sum - k;
            if(prefixSumDict.ContainsKey(target)) {
                res += prefixSumDict[target];
            }
            prefixSumDict[sum] = prefixSumDict.ContainsKey(sum) ? ++prefixSumDict[sum] : 1; // add sum after check if valid res exists => [1], k = 0
        }
        return res;
    }
}


