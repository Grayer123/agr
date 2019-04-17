/*
 * @lc app=leetcode id=264 lang=csharp
 *
 * [264] Ugly Number II
 *
 * https://leetcode.com/problems/ugly-number-ii/description/
 *
 * algorithms
 * Medium (36.00%)
 * Total Accepted:    100.8K
 * Total Submissions: 280.2K
 * Testcase Example:  '10'
 *
 * Write a program to find the n-th ugly number.
 * 
 * Ugly numbers are positive numbers whose prime factors only include 2, 3,
 * 5. 
 * 
 * Example:
 * 
 * 
 * Input: n = 10
 * Output: 12
 * Explanation: 1, 2, 3, 4, 5, 6, 8, 9, 10, 12 is the sequence of the first 10
 * ugly numbers.
 * 
 * Note:  
 * 
 * 
 * 1 is typically treated as an ugly number.
 * n does not exceed 1690.
 * 
 */
class Solution {
public:
    int nthUglyNumber(int n) {
        // heap + hashset
        // tc:O(nlogn); sc:O(n)
        if(n <= 0) {
            return -1;
        }
        priority_queue<long, vector<long>, greater<long>> pq; // min priority queue
        unordered_set<long> hashSet;
        int count = 0;
        long minVal = 0;
        vector<long> arr = {2, 3, 5};
        pq.push(1);
        while(count < n) {
            minVal = pq.top();
            pq.pop();
            count++;
            for(long num : arr) {
                long product = minVal * num;
                if(hashSet.find(product) == hashSet.end()) {
                    hashSet.insert(product);
                    pq.push(product);
                }
            }
        }
        return (int)minVal;
    }
};

