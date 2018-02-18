public class Solution {
    public int ArrangeCoins(int n) {
        //math; binary search
        //tc:O(lgn); sc:O(1)
        if(n == 0){ //corner case
            return 0;
        }
        int start = 1, end = n;
        while(start < end){
            int mid = start + (end - start) / 2;
            double temp = (double)n / mid * 2 - 1;
            if(mid  == temp){
                return mid;
            }
            else if(mid > temp){
                end = mid;
            }
            else{
                start = mid + 1;
            }
        }
        return ((double)start * (start + 1) / 2) > n ? start - 1 : start;
    }
}