public class Solution {
    public double MyPow(double x, int n) {
        //binary search
        //tc:O(lgn); sc:O(1)
        if(x == 0){ //corner case
            return 0;
        }
        if(n == 0){ //corner case
            return 1;
        }
        long sup = n > 0 ? n : -(long)n; //avoid overflow
        return n > 0 ? DoPow(x, sup) : 1 / DoPow(x, sup);
        
    }
    
    private double DoPow(double x, long n){
        if(n == 1){
            return x;
        }
        double tmp = DoPow(x, n / 2);
        return n % 2 == 0 ? tmp * tmp : x * tmp * tmp;
    }
}