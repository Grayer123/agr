public class Solution {
    public double MyPow(double x, int n) {
        // math; binary search
        // tc:O(logn); sc:O(1)
        if(x == 0 || x == 1 || n == 1) {
            return x;
        }
        if(n == 0) {
            return 1;
        }
        int sign = n < 0 ? -1 : 1;
        long n_abs = Math.Abs((long)n);
        return sign == 1 ? GetPositivePow(x, n_abs) : 1 / GetPositivePow(x, n_abs);
        
    }
    
    private double GetPositivePow(double x, long n) {
        if(n == 1) {
            return x;
        }
        if(n == 0) {
            return 1;
        }
        double pow = GetPositivePow(x, n / 2);
        return n % 2 == 0 ? pow * pow : x * pow * pow;
    }
}