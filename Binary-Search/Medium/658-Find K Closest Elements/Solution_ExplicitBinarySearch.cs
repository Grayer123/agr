//do binary search first, then do two pointers to shrink the window size to k
public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        //tc:O(logn + k); sc:O(k)
        int len = arr.Length;
        int min = arr[0], max = arr[len - 1];
        if (x <= min)  //corner case
        {
            int[] res = new int[k];
            Array.Copy(arr, 0, res, 0, k);
            return new List<int>(res);
        }
        else if (x >= max)  //corner case
        {
            int[] res = new int[k];
            Array.Copy(arr, len - k, res, 0, k);
            return new List<int>(res);
        }

        /*
            * The zero-based index of item in the sorted arr, if item is found; 
            * otherwise, a negative number that is the bitwise complement of the index of the next element that is larger than item,
            * or, if there is no larger element, the bitwise complement of Length.
        */
        int index = Array.BinarySearch(arr, x);
        index = index < 0 ? (-index - 1) : index;
        int start = Math.Max(0, index - k), end = Math.Min(len - 1, index + k - 1); //have 2 k size window
        while (end - start > k - 1) //shrink the window to size k
        {
            if (Math.Abs(x - arr[start]) <= Math.Abs(arr[end] - x))
            {
                end--;
            }
            else
            {
                start++;
            }
        }
        int[] resArr = new int[k];
        Array.Copy(arr, start, resArr, 0, k);
        return new List<int>(resArr);  //resArr.ToList(); -> we need to import Linq
    }
}