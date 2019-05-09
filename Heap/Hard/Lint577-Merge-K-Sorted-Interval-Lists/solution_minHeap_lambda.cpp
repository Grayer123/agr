/**
 * Definition of Interval:
 * classs Interval {
 *     int start, end;
 *     Interval(int start, int end) {
 *         this->start = start;
 *         this->end = end;
 *     }
 * }
 */
 
class Coordinate {
public:
    int row;
    int col;
    Coordinate(int r, int c): row(r), col(c) {}
 };

class Solution {
public:
    /**
     * @param intervals: the given k sorted interval lists
     * @return:  the new sorted interval list
     */
    vector<Interval> mergeKSortedIntervalLists(vector<vector<Interval>> &intervals) {
        // minheap
        // tc:O(nlogk); sc:O(n)
        if(intervals.size() == 0) {
            return {};
        }
        auto comp = [&intervals](Coordinate* c1, Coordinate* c2) -> bool {
            return intervals[c1->row][c1->col].start >= intervals[c2->row][c2->col].start;  
        };
        priority_queue<Coordinate*, vector<Coordinate*>, decltype(comp)> minHeap(comp);
        for(int i = 0; i < intervals.size(); i++) {
            if(intervals[i].size() > 0) {
                minHeap.push(new Coordinate(i, 0));
            }
        }
        vector<Interval> res;
        while(!minHeap.empty()) {
            auto elem = minHeap.top();
            minHeap.pop();
            res.push_back(intervals[elem->row][elem->col]);
            if(elem->col + 1 < intervals[elem->row].size()) {
                minHeap.push(new Coordinate(elem->row, elem->col + 1));
            }
        }
        return mergeIntervals(res);
    }
private:
    vector<Interval> mergeIntervals(vector<Interval>& intervalArr) {
        vector<Interval> res;
        for(auto interval : intervalArr) {
            if(res.size() == 0 || interval.start > res[res.size() - 1].end) {
                res.push_back(interval);
            }
            else {
                res[res.size() - 1].end = max(interval.end, res[res.size() - 1].end);
            }
        }
        return res;
    }
};