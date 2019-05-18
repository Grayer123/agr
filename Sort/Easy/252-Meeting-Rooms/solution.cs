public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
        // sort; interval
        // tc:O(nlogn); sc:O(1)
        if(intervals == null || intervals.Length == 0) {
            return true;
        }
        Array.Sort(intervals, (x, y) => x[0] - y[0]);
        for(int i = 1; i < intervals.Length; i++) {
            if(intervals[i][0] < intervals[i -1][1]) {
                return false;
            }
        }
        return true;
    }
}