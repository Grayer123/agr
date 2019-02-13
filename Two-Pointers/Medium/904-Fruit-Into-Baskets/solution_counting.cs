public class Solution {
    public int TotalFruit(int[] tree) {
        // two pointers: counting
        // TC:O(n); SC:O(n)
        if(tree.Length <= 2) {
            return tree.Length;
        } 
        int first = -1, second = -1;
        int countLast = 0, len = 0, maxLen = 0;
        
        foreach(int f in tree) {
            if(f == second) {
                countLast++;
                len++;
            }
            else if(f == first) {
                len++;
                countLast = 1; // count of last same elem stopped => get new elem
                first = second;
                second = f;
            }
            else {
                len = countLast + 1;
                first = second;
                second = f;
                countLast = 1;
            }
            maxLen = Math.Max(len, maxLen);
        }
        return maxLen;
    }
}