# 763. Partition Labels
[Original Page](https://leetcode.com/problems/partition-labels/)

A string S of lowercase letters is given. We want to partition this string into as many parts as possible so that each letter appears in at most one part, and return a list of integers representing the size of these parts.  


**Example 1:**  
Input: S = "ababcbacadefegdehijhklij"  
Output: [9,7,8]  
Explanation:  
The partition is "ababcbaca", "defegde", "hijhklij".  
This is a partition so that each letter appears in at most one part.  
A partition like "ababcbacadefegde", "hijhklij" is incorrect, because it splits S into less parts.  
 
**Note:**
1. S will have length in range [1, 500].
2. S will consist of lowercase letters ('a' to 'z') only.

Hint:
Try to greedily choose the smallest partition that includes the first letter. If you have something like "abaccbdeffed", then you might need to add b.   
You can use an map like "last['b'] = 5" to help you expand the width of your partition.

---

* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Medium)
* Companies:  * [Amazon](https://leetcode.com/company/amazon/) 
* Related Topics: * [Array](https://leetcode.com/tag/array/) 	* [Greedy](https://leetcode.com/tag/greedy/)
