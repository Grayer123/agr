public class Solution {
    public int Divide(int dividend, int divisor) {
        if(divisor == 0){
            throw new Exception("Invalid argument.");
        }
        //xor and bit shift to get the sign bit, 0 means two nums have same bit sign, 1 means different
        int sign = (dividend ^ divisor) >> 31; 
        long dd = dividend > 0 ? dividend : -(long)dividend;
        long ds = divisor > 0 ? divisor : -(long)divisor;
        
        long res = 0;
        while(dd >= ds){
            long dsCopy = ds;
            int count = 0;
            while(dd >= (dsCopy << 1)){
                dsCopy <<= 1;
                count++;
            }
            dd -= dsCopy;
            res += (long)1 << count; // 1<<31 =>Int32.MinValue(-2,147,483,648), here need 2,147,483,648, so convert to long 
        }
        return sign == 0 ? (res <= Int32.MaxValue ? Convert.ToInt32(res) : Int32.MaxValue) : Convert.ToInt32(-res);
    }
}