public class Solution {
    public int MaxProfit(int[] prices) {
        // enumeration
        // tc:O(n); sc:O(1)
        if(prices == null || prices.Length == 0) {
            return 0;
        }
        int minPrice = prices[0];
        int res = 0;
        foreach(var price in prices) {
            if(price < minPrice) {
                minPrice = price;
            }
            else {
                res = Math.Max(res, (price - minPrice));
            }
        }
        return res;
    }
}