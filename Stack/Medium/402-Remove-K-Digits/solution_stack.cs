public class Solution {
    public string RemoveKdigits(string num, int k) {
        // string + stack
        // tc:O(k*n); sc:O(n)
        if(String.IsNullOrEmpty(num) || num.Length <= k) {
            return "0";
        }
        Stack<char> stack = new Stack<char>();
        stack.Push(num[0]);
        int pos = 1;
        int len = num.Length - k;
        while(pos < num.Length) {
            if(stack.Count > 0 && stack.Peek() > num[pos] && k > 0) {
                stack.Pop();
                k--;
            }
            else {
                stack.Push(num[pos]);
                pos++;
            }
        }
        while(stack.Count > len) {
            stack.Pop();
        }
        char[] charArr = stack.ToArray();
        Array.Reverse(charArr);
                      
        pos = 0;
        while(pos < charArr.Length && charArr[pos] == '0') {
            pos++;
        }
        return pos == charArr.Length ? "0" : new String(charArr, pos, charArr.Length - pos);
    }
}