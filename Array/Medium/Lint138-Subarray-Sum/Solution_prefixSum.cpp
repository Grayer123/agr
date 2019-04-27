class Solution {
public:
    /**
     * @param nums: A list of integers
     * @return: A list of integers includes the index of the first number and the index of the last number
     */
    vector<int> subarraySum(vector<int> &nums) {
        // prefix sum 
        // tc:O(n); sc:O(n)
        if(nums.size() == 0) {
            return {};
        }
        // vector<int> prefixSumArr = vector<int>(nums.size() + 1); // use hash table as the prefixSum array
        // prefixSumArr[0] = 0;
        unordered_map<int, int> prefixSumDict;  // <sum, index>
        prefixSumDict[0] = -1; // for preparation
        int sum = 0;
        for(int i = 0; i < nums.size(); i++) {
            sum += nums[i];
            if(prefixSumDict.find(sum) != prefixSumDict.end()) {
                return {prefixSumDict[sum] + 1, i};
            }
            prefixSumDict[sum] = i;
        }
        return {};
    }
};