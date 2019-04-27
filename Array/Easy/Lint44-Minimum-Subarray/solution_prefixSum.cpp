class Solution {
public:
    /*
     * @param nums: a list of integers
     * @return: A integer indicate the sum of minimum subarray
     */
    int minSubArray(vector<int> &nums) {
        // prefix sum => minSum = prefixSum[i + 1] - max{prefixSum[0], ... , prefixSum[i]}
        // tc:O(n); sc:O(1)
        if(nums.size() == 0) {
            return 0;
        }
        int sum = 0;
        int maxSum = 0;
        int res = nums[0];
        for(int num : nums) {
            sum += num;
            res = res > sum - maxSum ? sum - maxSum : res;
            maxSum = maxSum >= sum ? maxSum : sum;
        }
        return res;
    }
};