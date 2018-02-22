public class Solution {
    public int Divide(int dividend, int divisor) {
        if(divisor == 0){
            throw new Exception("Invalid argument.");
        }
        //xor and bit shift to get the sign bit, 0 means two nums have same bit sign, 1 means different
        int sign = (dividend ^ divisor) >> 31; 
        long dd = dividend > 0 ? dividend : -(long)dividend;
        long ds = divisor > 0 ? divisor : -(long)divisor;
        if(dd < ds){
            return 0;
        }
        long res = 0, perRes = 1;
        long dsCopy = ds << 1;
        
        while(dd >= ds){
            if(dd >= dsCopy){
                perRes = perRes << 1;
                dd -= dsCopy;
                dsCopy = dsCopy << 1;
            }
            else{
                dd -= ds;
                dsCopy = ds << 1;
                perRes = 1;
            }
            res += perRes;
        }
        //handle overflow: dividend = Int32.MinValue, divisor = -1, => 2,147,483,648 => overflow
        return sign == 0 ? (res <= Int32.MaxValue ? Convert.ToInt32(res) : Int32.MaxValue) : Convert.ToInt32(-res);
    }
}