public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        // binary search + two pointers
        //tc:O(logn + k); sc:O(k)
        if(arr == null || arr.Length == 0){ //corner case
            return new List<int>();
        }
        int idx = Array.BinarySearch(arr, x);
        idx = idx >= 0 ? idx : ~idx;
        int left = idx - k < 0 ? 0 : idx - k; // keeps a 2k window size, then gradually shrink to k 
        int right = idx + k - 1 >= arr.Length ? arr.Length - 1 : idx + k - 1;
        
        while(right - left > k - 1){
            if((x - arr[left]) <= (arr[right] - x)){
                right--;
            }
            else{
                left++;
            }
        }
        int[] resArr = new int[k];
        Array.Copy(arr, left, resArr, 0, k);
        return new List<int>(resArr);
    }
}