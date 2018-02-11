//combined binary search with two pointers at the same time
public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        //tc:O(logn); sc:O(k)
        int len = arr.Length;
        int start = 0;
        int end = len - k; //ensure k elems between arr[len-k] - arr[len-1]
        while (start < end)
        {
            int mid = start + (end - start) / 2;
            if (Math.Abs(x - arr[mid]) <= Math.Abs(arr[mid + k] - x)) //window size: k; start may advance 1, so keep k+1 elems at first
            { 
                end = mid;
            }
            else
            {
                start = mid + 1;
            }
        }
        int[] res = new int[k];

        Array.Copy(arr, start, res, 0, k);
        return new List<int>(res);
    }
}