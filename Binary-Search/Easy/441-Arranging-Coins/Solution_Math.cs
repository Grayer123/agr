public class Solution {
    public int ArrangeCoins(int n) {
        //math;
        //tc:O(1); sc:O(1)
        if(n <= 0){ //corner case
            return 0;
        }
        return Convert.ToInt32(Math.Floor(Math.Sqrt((double)n * 2 + 0.25) - 0.5));
    }
}