/*
 * @lc app=leetcode id=165 lang=csharp
 *
 * [165] Compare Version Numbers
* Tags: string
* Companies: apple | microsoft

Compare two version numbers version1 and version2.
If version1 > version2 return 1; if version1 < version2 return -1;otherwise return 0.

You may assume that the version strings are non-empty and contain only digits and the . character.

The . character does not represent a decimal point and is used to separate number sequences.

For instance, 2.5 is not "two and a half" or "half way to version three", it is the fifth second-level revision of the second first-level revision.

You may assume the default revision number for each level of a version number to be 0. For example, version number 3.4 has a revision number of 3 and 4 for its first and second level revision number. Its third and fourth level revision number are both 0.

 

Example 1:

Input: version1 = "0.1", version2 = "1.1"
Output: -1
Example 2:

Input: version1 = "1.0.1", version2 = "1"
Output: 1
Example 3:

Input: version1 = "7.5.2.4", version2 = "7.5.3"
Output: -1
Example 4:

Input: version1 = "1.01", version2 = "1.001"
Output: 0
Explanation: Ignoring leading zeroes, both “01” and “001" represent the same number “1”
Example 5:

Input: version1 = "1.0", version2 = "1.0.0"
Output: 0
Explanation: The first version number does not have a third level revision number, which means its third level revision number is default to "0"
 

Note:

Version strings are composed of numeric strings separated by dots . and this numeric strings may have leading zeroes.
Version strings do not start or end with dots, and they will not be two consecutive dots.
 */
 
public class Solution {
    public int CompareVersion(string version1, string version2) {
        // string 
        // tc:O(n); sc:O(n)
        if(String.IsNullOrEmpty(version1) || String.IsNullOrEmpty(version2)) {
            throw new ArgumentException("Invalid Argument");
        }
        string[] versionArr1 = version1.Split('.');
        string[] versionArr2 = version2.Split('.');
        int len = Math.Max(versionArr1.Length, versionArr2.Length);
        int num1 = 0, num2 = 0;
        for(int i = 0; i < len; i++) {
            num1 = i >= versionArr1.Length ? 0 : Int32.Parse(versionArr1[i]);
            num2 = i >= versionArr2.Length ? 0 : Int32.Parse(versionArr2[i]);
            if(num1 > num2) {
                return 1;
            }
            else if(num1 < num2) {
                return -1;
            }
        }
        return 0;
    }
}
