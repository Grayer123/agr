/*
 * @lc app=leetcode id=973 lang=csharp
 *
 * [973] K Closest Points to Origin
 *
 * https://leetcode.com/problems/k-closest-points-to-origin/description/
 *
 * algorithms
 * Medium (63.65%)
 * Total Accepted:    44.3K
 * Total Submissions: 69.6K
 * Testcase Example:  '[[1,3],[-2,2]]\n1'
 *
 * We have a list of points on the plane.  Find the K closest points to the
 * origin (0, 0).
 * 
 * (Here, the distance between two points on a plane is the Euclidean
 * distance.)
 * 
 * You may return the answer in any order.  The answer is guaranteed to be
 * unique (except for the order that it is in.)
 * 
 * 
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: points = [[1,3],[-2,2]], K = 1
 * Output: [[-2,2]]
 * Explanation: 
 * The distance between (1, 3) and the origin is sqrt(10).
 * The distance between (-2, 2) and the origin is sqrt(8).
 * Since sqrt(8) < sqrt(10), (-2, 2) is closer to the origin.
 * We only want the closest K = 1 points from the origin, so the answer is just
 * [[-2,2]].
 * 
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: points = [[3,3],[5,-1],[-2,4]], K = 2
 * Output: [[3,3],[-2,4]]
 * (The answer [[-2,4],[3,3]] would also be accepted.)
 * 
 * 
 * 
 * 
 * Note:
 * 
 * 
 * 1 <= K <= points.length <= 10000
 * -10000 < points[i][0] < 10000
 * -10000 < points[i][1] < 10000
 * 
 * 
 * 
 */
class Solution {
public:
    vector<vector<int>> kClosest(vector<vector<int>>& points, int k) {
        // heap + hash table
        // tc:O(nlogk); sc:O(n)
        if(points.size() == 0 || k <= 0) {
            return {};
        }
        vector<vector<int>> res;
        // priority_queue<pair<double, vector<int>>, vector<pair<double, vector<int>>>, less<pair<double, vector<int>>>> maxHeap;
        priority_queue<pair<double, vector<int>>> maxHeap;
        double product = 0;
        for(auto point : points) {
            product = point[0] * point[0] + point[1] * point[1];
            maxHeap.push(make_pair(sqrt(product), vector<int>{point[0], point[1]}));
            if(maxHeap.size() > k) {
                maxHeap.pop();
            }
        }
        while(maxHeap.size() > 0) {
            res.push_back(maxHeap.top().second);
            maxHeap.pop();
        }
        return res;
    }
};

