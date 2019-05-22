/**
 * Definition for a point.
 * struct Point {
 *     int x;
 *     int y;
 *     Point() : x(0), y(0) {}
 *     Point(int a, int b) : x(a), y(b) {}
 * };
 */

class Solution {
public:
    /**
     * @param points: a list of points
     * @param origin: a point
     * @param k: An integer
     * @return: the k closest points
     */
    vector<Point> kClosest(vector<Point> &points, Point &origin, int k) {
        // heap
        // tc:O(nlogk); sc:O(k)
        if(points.size() == 0 || k <= 0) {
            return {};
        }
        vector<Point> res(k);
        auto comp = [&origin](Point p1, Point p2) -> bool {
            int px1 = p1.x - origin.x, py1 = p1.y - origin.y;
            int px2 = p2.x - origin.x, py2 = p2.y - origin.y;
            long long disp1 = px1 * px1 + py1 * py1;
            long long disp2 = px2 * px2 + py2 * py2;
            
            if(disp1 == disp2) {
                if(p1.x == p2.x) {
                    return p1.y < p2.y;
                }
                return p1.x < p2.x;
            }
            return disp1 < disp2;
        };
        priority_queue<Point, vector<Point>, decltype(comp)> maxHeap(comp);
        for(auto point : points) {
            maxHeap.push(point);
            if(maxHeap.size() > k) {
                maxHeap.pop();
            }
        }
        while(maxHeap.size() > 0) {
            res[--k] = maxHeap.top();
            maxHeap.pop();
        }
        return res;
    }
};