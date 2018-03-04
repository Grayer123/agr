/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public int[] FindRightInterval(Interval[] intervals) {
        //binary search; hash table
        //TC:O(nlogn); SC:O(n)
        if(intervals == null || intervals.Length == 0){ //corner case
            return new int[0];
        }
        int len = intervals.Length;
        Tuple<int, int>[] dicts = new Tuple<int, int>[len];
        int[] res = new int[len];
        for(int i = 0; i < len; i++){
            dicts[i] = new Tuple<int, int>(intervals[i].start, i);
        }
        //Array.Sort(dicts);
        Array.Sort(dicts, (x, y) => x.Item1.CompareTo(y.Item1));
        for(int i = 0; i < len; i++){
            int idx = BinarySearch(ref dicts, intervals[i].end);
            res[i] = idx == len ? -1 : idx;
        }
        return res;
    }
    
    int BinarySearch(ref Tuple<int, int>[] dicts, int target){
        int low = 0, high = dicts.Length - 1;
        while(low < high){
            int mid = low + (high - low) / 2;
            if(dicts[mid].Item1 == target){
                return dicts[mid].Item2;
            }
            else if(dicts[mid].Item1 < target){
                low = mid + 1;
            }
            else{
                high = mid;
            }
        }
        return dicts[low].Item1 < target ? dicts.Length : dicts[low].Item2;
    }
}

