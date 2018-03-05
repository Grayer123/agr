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
            int idx = Array.BinarySearch(dicts, new Tuple<int, int>(intervals[i].end, 0), 
                                         new CompareDict<Tuple<int, int>>((x,y) => x.Item1.CompareTo(y.Item1)));
            idx = idx >= 0 ? idx : ~idx;
            res[i] = idx == len ? -1 : dicts[idx].Item2;
        }
        return res;
    }
    
}

//generic implementation: using comparison delegate
public class CompareDict<T>: IComparer<T>{
    private readonly Comparison<T> comparison;
    public CompareDict(Comparison<T> cmp){
        this.comparison = cmp;
    }
    
    public int Compare(T x, T y){
        return comparison(x, y);
    }
}