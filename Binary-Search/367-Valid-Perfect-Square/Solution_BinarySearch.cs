public class Solution {
    public bool IsPerfectSquare(int num) {
        //binary search
        //tc:O(lgn); sc:O(1)
        if(num == 1){
            return true;
        }
        int start = 1, end = num / 2;
        while(start + 1 < end){
            int mid = start + (end - start) / 2; //avoid overflow
            if(num / mid == mid && num % mid == 0){
                return true;
            }
            else if(num / mid < mid){
                end = mid;
            }
            else{
                start = mid;
            }
        }
        if(num / start == start && num % start == 0 || num / end == end && num % end == 0){
            return true;
        }
        return false;
    }
}