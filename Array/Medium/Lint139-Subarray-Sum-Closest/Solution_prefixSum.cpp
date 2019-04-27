class Solution {
public:
    /*
     * @param nums: A list of integers
     * @return: A list of integers includes the index of the first number and the index of the last number
     */
    vector<int> subarraySumClosest(vector<int> &nums) {
        // prefix sum 
        // tc:O(nlogn); sc:O(n)
        if(nums.size() == 0) {
            return {};
        }
        vector<pair<int, int>> prefixSumArr = vector<pair<int, int>>(nums.size() + 1); // pair<sum, index>
        prefixSumArr[0] = make_pair(0, -1);
        int sum = 0;
        for(int i = 0; i < nums.size(); i++) {
            sum += nums[i];
            prefixSumArr[i + 1] = make_pair(sum, i);
        }
        sort(prefixSumArr.begin(), prefixSumArr.end());
        int minDiff = INT_MAX;
        vector<int> res = vector<int>(2);
        for(int i = 0; i < prefixSumArr.size() - 1; i++) {
            int diff = prefixSumArr[i + 1].first - prefixSumArr[i].first;
            if(diff < minDiff) {
                minDiff = diff;
                res[0] = min(prefixSumArr[i + 1].second, prefixSumArr[i].second) + 1;
                res[1] = max(prefixSumArr[i + 1].second, prefixSumArr[i].second);
            }
        }
        return res;
    }
};