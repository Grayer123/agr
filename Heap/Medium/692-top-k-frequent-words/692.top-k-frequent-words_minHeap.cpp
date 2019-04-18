/*
 * @lc app=leetcode id=692 lang=csharp
 *
 * [692] Top K Frequent Words
 *
 * https://leetcode.com/problems/top-k-frequent-words/description/
 *
 * algorithms
 * Medium (45.27%)
 * Total Accepted:    58.6K
 * Total Submissions: 129.4K
 * Testcase Example:  '["i", "love", "leetcode", "i", "love", "coding"]\n2'
 *
 * Given a non-empty list of words, return the k most frequent elements.
 * Your answer should be sorted by frequency from highest to lowest. If two
 * words have the same frequency, then the word with the lower alphabetical
 * order comes first.
 * 
 * Example 1:
 * 
 * Input: ["i", "love", "leetcode", "i", "love", "coding"], k = 2
 * Output: ["i", "love"]
 * Explanation: "i" and "love" are the two most frequent words.
 * ⁠   Note that "i" comes before "love" due to a lower alphabetical order.
 * 
 * 
 * 
 * Example 2:
 * 
 * Input: ["the", "day", "is", "sunny", "the", "the", "the", "sunny", "is",
 * "is"], k = 4
 * Output: ["the", "is", "sunny", "day"]
 * Explanation: "the", "is", "sunny" and "day" are the four most frequent
 * words,
 * ⁠   with the number of occurrence being 4, 3, 2 and 1 respectively.
 * 
 * 
 * 
 * Note:
 * 
 * You may assume k is always valid, 1 ≤ k ≤ number of unique elements.
 * Input words contain only lowercase letters.
 * 
 * 
 * 
 * Follow up:
 * 
 * Try to solve it in O(n log k) time and O(n) extra space.
 * 
 * 
 */
class comparePair {
public: 
    bool operator()(pair<int, string> p1, pair<int, string> p2) {
        if(p1.first == p2.first) {
            return p1.second < p2.second; // max (larger alpha comes first => reverse => lower alpha comes first)
        }
        return p1.first >= p2.first; // min heap
    }
};

class Solution {
public:
    vector<string> topKFrequent(vector<string>& words, int k) {
        // minheap + hash table
        // tc:O(nlogk); sc:O(n)
        if(words.size() == 0 || k <= 0) {
            return {};
        }
        unordered_map<string, int> dict;
        priority_queue<pair<int, string>, vector<pair<int, string>>, comparePair> minHeap;
        vector<string> res;
        for(auto word : words) { // get the frequency for each word
            dict[word] = dict.find(word) == dict.end() ? 1 : ++dict[word];
        }
        for(auto it = dict.begin(); it != dict.end(); it++) {
            minHeap.push(make_pair(it->second, it->first));
            if(minHeap.size() > k) { // maintain size k priority queue
                minHeap.pop();
            }
        }
        while(minHeap.size() > 0) {
            res.push_back(minHeap.top().second);
            minHeap.pop();
        }
        reverse(res.begin(), res.end()); // get minHeap, need to reverse
        return res;
    }
};

