public class Solution {
    public bool BackspaceCompare(string S, string T) {
        // stack
        // tc:O(n); sc:O(n)
        return BuildStack(ref S) == BuildStack(ref T);
    }
    
    private string BuildStack(ref string s) {
        Stack<char> stk = new Stack<char>();
        foreach(var c in s) {
            if(c != '#') {
                stk.Push(c);
            }
            else if(c == '#' && stk.Count != 0) {
                stk.Pop();
            }
        }
        return new String(stk.ToArray());
    }
}