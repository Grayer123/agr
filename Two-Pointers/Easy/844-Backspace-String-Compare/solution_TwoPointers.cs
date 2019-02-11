public class Solution {
    public bool BackspaceCompare(string S, string T) {
        // two pointers
        // tc:O(n); sc:O(1)
        int curS = S.Length - 1, curT = T.Length - 1;
        int countS = 0, countT = 0;
        
        while(curS >= 0 || curT >= 0) {
            while(curS >= 0 && (S[curS] == '#' || countS > 0)) {
                if(S[curS] == '#') {
                    countS++;
                    curS--;
                }
                else{
                    countS--;
                    curS--;
                }
            }
            while(curT >= 0 && (T[curT] == '#' || countT > 0)) {
                if(T[curT] == '#') {
                    countT++;
                    curT--;
                }
                else{
                    countT--;
                    curT--;
                }
            }

            if(curS >= 0 && curT >= 0 && S[curS] != T[curT]) {
                    return false;
            }
            else if((curS < 0) != (curT < 0)) { // one < 0 && one >= 0
                return false;
            }
            curS--;
            curT--;
        }
        return true;
    }
}