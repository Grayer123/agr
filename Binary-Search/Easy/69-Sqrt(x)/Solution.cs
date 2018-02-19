public class Solution {
    public int MySqrt(int x) {
        //binary search
        //tc:O(lgn); sc:O(1)
        if(x < 0){
            throw new Exception("Invalid arguments.");
        }
        if(x == 0){ //corner case
            return 0;
        }
        int start = 1 , end = x;
        while(start < end){
            int mid = start + (end - start) / 2;
            if(mid == x / mid){
                return mid;
            }
            else if(mid < x / mid){
                start = mid + 1;
            }
            else{
                end = mid;
            }
        }
        return start <= x / start ? start : start - 1;
    }
}