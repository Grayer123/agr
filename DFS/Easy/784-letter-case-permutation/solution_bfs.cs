/*
 * @lc app=leetcode id=784 lang=csharp
 *
 * [784] Letter Case Permutation
 *
 * https://leetcode.com/problems/letter-case-permutation/description/
 *
 * algorithms
 * Easy (55.53%)
 * Total Accepted:    41K
 * Total Submissions: 73.7K
 * Testcase Example:  '"a1b2"'
 *
 * Given a string S, we can transform every letter individually to be lowercase
 * or uppercase to create another string.  Return a list of all possible
 * strings we could create.
 * 
 * 
 * Examples:
 * Input: S = "a1b2"
 * Output: ["a1b2", "a1B2", "A1b2", "A1B2"]
 * 
 * Input: S = "3z4"
 * Output: ["3z4", "3Z4"]
 * 
 * Input: S = "12345"
 * Output: ["12345"]
 * 
 * 
 * Note:
 * 
 * 
 * S will be a string with length between 1 and 12.
 * S will consist only of letters or digits.
 * 
 * 
 */
 
public class Solution {
    public IList<string> LetterCasePermutation(string s) {
        // bfs: queue
        // tc:O(2^n * n); sc:O(n)
        if(s == null) {
            return new List<string>();
        }
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(s);
        for(int i = 0; i < s.Length; i++) {
            if(Char.IsDigit(s[i])) {
                continue;
            }
            int len = queue.Count;
            for(int j = 0; j < len; j++) {
                var str = queue.Dequeue();
                char[] charArr = str.ToCharArray();
                charArr[i] = Char.ToLower(s[i]);
                queue.Enqueue(new String(charArr));
                charArr[i] = Char.ToUpper(s[i]);
                queue.Enqueue(new String(charArr));
            }
        }
        return queue.ToList();       
    }
}