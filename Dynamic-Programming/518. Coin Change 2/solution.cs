public class Solution {
    public int Change(int amount, int[] coins) {
        // dp
        // tc:O(a * c); sc: O:(a * c)
        if(amount == 0) {
            return 1;
        }
        if(coins == null || coins.Length == 0) {
            return 0;
        }
        int[,] f = new int[coins.Length + 1, amount + 1];
        
        // initialization
        for(int i = 0; i <= coins.Length; i++) {
            f[i, 0] = 1;
        }
        for(int i = 1; i <= amount; i++) { // actually no need for this, by default is 0
            f[0, i] = 0; 
        }
        for(int i = 1; i <= coins.Length; i++) {
            for(int j = 1; j <= amount; j++) {
                int withoutThisCoin = f[i - 1, j];
                int currentCoinValue = coins[i - 1]; // for coins array, it starts with 0, 0 ~ coins.Length - 1
                int withThisCoin = j >= currentCoinValue ? f[i, j - currentCoinValue] : 0;
                f[i, j] = withoutThisCoin + withThisCoin;
            }
        }
        return f[coins.Length, amount];
    }
}