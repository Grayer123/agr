/*
 * @lc app=leetcode id=443 lang=csharp
 *
 * [443] String Compression
 Tags
string

Companies
bloomberg | microsoft | snapchat | yelp

Given an array of characters, compress it in-place.

The length after compression must always be smaller than or equal to the original array.

Every element of the array should be a character (not int) of length 1.

After you are done modifying the input array in-place, return the new length of the array.

 
Follow up:
Could you solve it using only O(1) extra space?

 
Example 1:

Input:
["a","a","b","b","c","c","c"]

Output:
Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]

Explanation:
"aa" is replaced by "a2". "bb" is replaced by "b2". "ccc" is replaced by "c3".
 

Example 2:

Input:
["a"]

Output:
Return 1, and the first 1 characters of the input array should be: ["a"]

Explanation:
Nothing is replaced.
 

Example 3:

Input:
["a","b","b","b","b","b","b","b","b","b","b","b","b"]

Output:
Return 4, and the first 4 characters of the input array should be: ["a","b","1","2"].

Explanation:
Since the character "a" does not repeat, it is not compressed. "bbbbbbbbbbbb" is replaced by "b12".
Notice each digit has it's own entry in the array.
 

Note:

All characters have an ASCII value in [35, 126].
1 <= len(chars) <= 1000.
 */
 
public class Solution {
    public int Compress(char[] chars) {
        // array
        // tc:O(n); sc:O(1)
        if(chars == null || chars.Length == 0) {
            return 0;
        }
        //Array.Sort(chars);
        int pos = 0;
        int newPos = 0;
        while(pos < chars.Length) {
            char curChar = chars[pos];
            int count = 0;
            while(pos < chars.Length && chars[pos] == curChar) {
                count++;
                pos++;
            }
            WriteNumInArray(chars, curChar, ref newPos, count);
        }
        return newPos;
    }
    
    private void WriteNumInArray(char[] chars, char curChar, ref int newPos, int count) {
        chars[newPos++] = curChar; 
        if(count == 1) {
            return;
        }
        int startIdx = newPos;
        while(count != 0) {
            chars[newPos++] = Convert.ToChar((count % 10).ToString());
            count /= 10;
        }
        Array.Reverse(chars, startIdx, newPos - startIdx);
    }
}
