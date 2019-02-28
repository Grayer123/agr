class Solution {
public:
    int numSquares(int n) {
        //DP; SR;
        //TC:O(n^2); SC:O(n)
        if(n < 1){//corner case
            return 0;
        }
        //state
        int f[n + 1];
        //initialization
        fill_n(f, n + 1, INT_MAX);
        f[0] = 0;
        //function
        for(int i = 1; i <= n; i++){
            for(int j = 1; j * j <= i; j++){
                f[i] = min(f[i], f[i - j * j] + 1);
            }
        }
        return f[n];
    }
};