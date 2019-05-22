public class Solution {
    public string RemoveKdigits(string num, int k) {
        // string
        // tc:O(k*n); sc:O(1)
        if(String.IsNullOrEmpty(num) || num.Length <= k) {
            return "0";
        }
        while(k > 0) {
            int idxToRemove = -1;
            for(int i = 1; i < num.Length; i++) {
                if(num[i - 1] > num[i]) {
                    idxToRemove = i - 1;
                    break;
                }
            }
            idxToRemove = idxToRemove == -1 ? num.Length - 1 : idxToRemove;
            num = num.Remove(idxToRemove, 1);
            k--;
        }
        int count = 0; // count leading 0
        int pos = 0;
        while(pos < num.Length && num[pos] == '0') {
            count++;
            pos++;
        }
        if(count > 0) {
            num = num.Remove(0, count);
        }
        return num.Length == 0 ? "0" : num;
    }
}