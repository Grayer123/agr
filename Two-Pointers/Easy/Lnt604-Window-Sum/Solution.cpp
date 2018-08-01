class Solution {
public:
    /**
     * @param nums: a list of integers.
     * @param k: length of window.
     * @return: the sum of the element inside the window at each moving.
     */
    vector<int> winSum(vector<int> &nums, int k) {
        // two pointers
        // tc:O(n); sc:O(1)
        if(nums.size() == 0 || nums.size() < k) {
            return vector<int>();
        }
        vector<int> res(nums.size() - k + 1, 0);
        for(int i = 0; i < k; i++) {
            res[0] += nums[i];
        }
        for(int i = 1; i <= nums.size() - k; i++) {
            res[i] = res[i - 1] - nums[i - 1] + nums[i + k - 1];
        }
        return res;
    }
};