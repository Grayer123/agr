class Solution {
public:
    int minMeetingRooms(vector<vector<int>>& intervals) {
        // sort + minHeap 
        // tc:O(nlogn); sc:O(n)
        if(intervals.size() == 0) {
            return 0;
        }
        sort(intervals.begin(), intervals.end());
        priority_queue<int, vector<int>, greater<int>> minHeap;
        int rooms = 1;
        minHeap.push(intervals[0][1]);
        for(int i = 1; i < intervals.size(); i++) {
            if(minHeap.top() <= intervals[i][0]) {
                minHeap.pop(); // no need to add new room
            }
            minHeap.push(intervals[i][1]);
        }
        return minHeap.size();
    }
};