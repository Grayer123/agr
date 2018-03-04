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
            int idx = Array.BinarySearch(dicts, new Tuple<int, int>(intervals[i].end, 0), new CompareDict());
            idx = idx >= 0 ? idx : ~idx;
            res[i] = idx == len ? -1 : dicts[idx].Item2;
        }
        return res;
    }
    
}

public class CompareDict: IComparer<Tuple<int, int>>{
    public int Compare(Tuple<int, int> t1, Tuple<int, int> t2){
        return t1.Item1.CompareTo(t2.Item1);
    }
}

