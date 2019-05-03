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
 
class Element {
public:
    int row;
    int col;
    Interval* interval;
    Element(int r, int c, Interval* i): row(r), col(c), interval(i){}
 };
 
class CompareElem {
public:
    bool operator()(Element* a, Element* b) { // minheap comparer
        return a->interval->start >= b->interval->start;
    }
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
        priority_queue<Element*, vector<Element*>, CompareElem> minHeap;
        for(int i = 0; i < intervals.size(); i++) {
            if(intervals[i].size() > 0) {
                minHeap.push(new Element(i, 0, new Interval(intervals[i][0].start, intervals[i][0].end)));
            }
        }
        vector<Interval> res;
        while(!minHeap.empty()) {
            auto elem = minHeap.top();
            minHeap.pop();
            res.push_back(Interval(elem->interval->start, elem->interval->end));
            if((elem->col + 1) < intervals[elem->row].size()) {
                minHeap.push(new Element(elem->row, (elem->col + 1), new Interval(intervals[elem->row][elem->col + 1].start, intervals[elem->row][elem->col + 1].end)));
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