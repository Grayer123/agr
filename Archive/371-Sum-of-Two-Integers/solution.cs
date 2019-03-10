public class Solution {
    public int GetSum(int a, int b) {
        //bit manipulation
        //TC:O(n); SC:O(1)
        int val1 = a & b;
        int val2 = a ^ b;
        val1 = (val1 << 1);
        if((val1 & val2) == 0){
            return val1 | val2;
        }
        else{
            return GetSum(val1, val2);
        }
    }
}