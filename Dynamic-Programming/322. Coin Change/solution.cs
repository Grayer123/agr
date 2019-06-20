public class Solution {
    public int CoinChange(int[] coins, int amount) {
        // dp
        // tc:O(n * m); sc:O(n)
        if(amount == 0) {
            return 0;
        }
        int[] f = new int[amount + 1];
        f[0] = 0;
        for(int i = 1; i <= amount; i++) {
            int minTimes = Int32.MaxValue;
            foreach(var coin in coins) {
                int times = i < coin ? Int32.MaxValue : f[i - coin];
                minTimes = Math.Min(minTimes, times);
            }
            f[i] = minTimes == Int32.MaxValue ? Int32.MaxValue : minTimes + 1;
        }
        return f[amount] == Int32.MaxValue ? -1 : f[amount];
    }
}