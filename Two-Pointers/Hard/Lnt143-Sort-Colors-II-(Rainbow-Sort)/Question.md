Lnt143. Sort Colors II (Rainbow Sort)  

[Original Page](https://www.lintcode.com/problem/sort-colors-ii/description)

Given an array of `n` objects with `k` `different` colors (numbered from `1 to k`),   
sort them so that objects of the `same color` are `adjacent`, with the colors in the order 1, 2, ... k.  

**Note:**   
* You are not suppose to use the library's sort function for this problem.  
* k <= n  

**Example:**  
Given colors=[3, 2, 2, 1, 4], k=4, your code should sort colors `in-place` to [1, 2, 2, 3, 4].  

**Challenge:**  
A rather straight forward solution is a two-pass algorithm using `counting sort`. That will cost `O(k)` extra memory.   
Can you do it `without` using `extra memory`?  

---

* Difficulty: [Hard](https://leetcode.com/problemset/all/?difficulty=Hard)
* Companies: * [Microsoft](https://leetcode.com/company/microsoft/) * [Amazon](https://leetcode.com/company/amazon/) * [Facebook](https://leetcode.com/company/facebook/)
* Related Topics: * [Two Pointers](https://leetcode.com/tag/two-pointers/) 	* [Divide and Conquer](https://leetcode.com/tag/divide-and-conquer/) * [Sort](https://leetcode.com/tag/sort/)
* Similar Questions: 
  * [(M) 148. Sort List](https://leetcode.com/problems/sort-list/description/)
  * [(M) 280. Wiggle Sort](https://leetcode.com/problems/wiggle-sort/description/)
  * [(M) 324. Wiggle Sort II](https://leetcode.com/problems/wiggle-sort-ii/description/)