/*
 * @lc app=leetcode id=56 lang=csharp
 *
 * [56] Merge Intervals
 *
 * https://leetcode.com/problems/merge-intervals/description/
 *
 * algorithms
 * Medium (35.23%)
 * Total Accepted:    329.5K
 * Total Submissions: 932.7K
 * Testcase Example:  '[[1,3],[2,6],[8,10],[15,18]]'
 *
 * Given a collection of intervals, merge all overlapping intervals.
 * 
 * Example 1:
 * 
 * 
 * Input: [[1,3],[2,6],[8,10],[15,18]]
 * Output: [[1,6],[8,10],[15,18]]
 * Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into
 * [1,6].
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: [[1,4],[4,5]]
 * Output: [[1,5]]
 * Explanation: Intervals [1,4] and [4,5] are considered overlapping.
 * 
 * NOTE: input types have been changed on April 15, 2019. Please reset to
 * default code definition to get new method signature.
 * 
 */
public class Solution {
    public int[][] Merge(int[][] intervals) {
        // jagged array + sort
        // tc:O(nlogn); sc:O(1)
        if(intervals == null || intervals.Length == 0) {
            return new int[0][];
        }
        Array.Sort(intervals, new Comparison<int[]>((x,y) => { return x[0] < y[0] ? -1 : (x[0] > y[0] ? 1 : 0); }));
        List<int[]> list = new List<int[]>();
        foreach(var interval in intervals) {
            if(list.Count == 0 || interval[0] > list[list.Count - 1][1]) {
                list.Add(interval);
            }         
            else {
                list[list.Count - 1][1] = Math.Max(interval[1], list[list.Count - 1][1]); 
            }
        }
        return list.ToArray();
    }
}

