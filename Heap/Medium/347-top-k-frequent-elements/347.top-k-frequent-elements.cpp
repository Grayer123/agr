/*
 * @lc app=leetcode id=347 lang=csharp
 *
 * [347] Top K Frequent Elements
 *
 * https://leetcode.com/problems/top-k-frequent-elements/description/
 *
 * algorithms
 * Medium (54.20%)
 * Total Accepted:    192.1K
 * Total Submissions: 354.4K
 * Testcase Example:  '[1,1,1,2,2,3]\n2'
 *
 * Given a non-empty array of integers, return the k most frequent elements.
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [1,1,1,2,2,3], k = 2
 * Output: [1,2]
 * 
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [1], k = 1
 * Output: [1]
 * 
 * 
 * Note: 
 * 
 * 
 * You may assume k is always valid, 1 ≤ k ≤ number of unique elements.
 * Your algorithm's time complexity must be better than O(n log n), where n is
 * the array's size.
 * 
 * 
 */
class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        // minheap + hash table
        // tc:O(nlogk); sc:O(n)
        if(nums.size() == 0 || k <= 0) {
            return {};
        }
        unordered_map<int, int> dict;
        priority_queue<pair<int, int>, vector<pair<int, int>>, greater<pair<int, int>>> minPq;
        vector<int> res;
        for(int num : nums) { // iterate to generate for each digits how many times it appears
            dict[num] = dict.find(num) == dict.end() ? 1 : ++dict[num];  
        }
        for(auto it = dict.begin(); it != dict.end(); it++) { // only maintain min heap with size k
            minPq.push(make_pair(it->second, it->first));
            if(minPq.size() > k) {
                minPq.pop();
            }           
        }       
        
        while(minPq.size() > 0) {
            res.push_back(minPq.top().second);
            minPq.pop();
        }
        reverse(res.begin(), res.end());
        return res;
    }
};

