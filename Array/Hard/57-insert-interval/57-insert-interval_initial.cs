/*
 * @lc app=leetcode id=57 lang=csharp
 *
 * [57] Insert Interval
 
 Tags
array | sort

Companies
facebook | google | linkedin

Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary).

You may assume that the intervals were initially sorted according to their start times.

Example 1:

Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
Output: [[1,5],[6,9]]
Example 2:

Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
Explanation: Because the new interval [4,8] overlaps with [3,5],[6,7],[8,10].
NOTE: input types have been changed on April 15, 2019. Please reset to default code definition to get new method signature.
 */
public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        // binary search; merge interval
        // tc:O(n); sc:O(n)
        if(intervals == null || intervals.Length == 0) {
            return new int[][]{newInterval};
        }
        if(newInterval == null || newInterval.Length == 0) {
            return intervals;
        }
        int pos = FindInsertPosition(intervals, newInterval[0]);
        var intervalArr = intervals.ToList();
        intervalArr.Add(new int[0]);
        InsertInterval(intervalArr, newInterval, pos);
        return MergeIntervals(intervalArr);
        
    }
    
    private int FindInsertPosition(int[][] intervals, int target) {
        if(target <intervals[0][0]) {
            return 0;
        }
        if(target >= intervals[intervals.Length - 1][0]) {
            return intervals.Length;
        }
        int start = 0, end = intervals.Length - 1;
        while(start < end) {
            int mid = start + (end - start) / 2;
            if(intervals[mid][0] <= target) {
                start = mid + 1;
            }
            else {
                end = mid;
            }
        }
        return start;
    }
    
    private void InsertInterval(List<int[]> intervals, int[] newInterval, int pos) {
        if(pos == intervals.Count) {
            intervals[pos] = newInterval;
            return;
        }
        for(int i = intervals.Count - 1; i > pos; i--) {
            intervals[i] = intervals[i -1];
        }
        intervals[pos] = newInterval;
    }
    
    private int[][] MergeIntervals(List<int[]> intervals) {
        List<int[]> res = new List<int[]>();
        foreach(var interval in intervals) {
            if(res.Count == 0) {
                res.Add(interval);
                continue;
            }
            int[] arr = res[res.Count - 1];
            if(interval[0] >= arr[0] && interval[0] <= arr[1]) {
                res[res.Count - 1][1] = Math.Max(arr[1], interval[1]);
            }
            else {
                res.Add(interval);
            }
        }
        return res.ToArray();
    }
}

