# 75. Sort Colors
[Original Page](https://leetcode.com/problems/sort-colors/description/)

Given an array with n objects colored red, white or blue, sort them `in-place` so that objects of the same color are adjacent, with the colors in the order red, white and blue.

Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.

Note: You are not suppose to use the library's sort function for this problem.

```
Example:
Input: [2,0,2,1,1,0]
Output: [0,0,1,1,2,2]
```

**Follow up:**

A rather straight forward solution is a two-pass algorithm using **counting sort**.
First, iterate the array counting number of 0's, 1's, and 2's, then overwrite array with total number of 0's, then 1's and followed by 2's.

Could you come up with a **one-pass** algorithm using only constant space?

---

* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Medium)
* Companies: * [Microsoft](https://leetcode.com/company/microsoft/) * [Amazon](https://leetcode.com/company/amazon/) * [Facebook](https://leetcode.com/company/facebook/)
* Related Topics: * [Two Pointers](https://leetcode.com/tag/two-pointers/) 	* [Array](https://leetcode.com/tag/array/) 	* [Sort](https://leetcode.com/tag/sort/)
* Similar Questions: 
  * [(M) 148. Sort List](https://leetcode.com/problems/sort-list/description/)
  * [(M) 280. Wiggle Sort](https://leetcode.com/problems/wiggle-sort/description/)
  * [(E) 324. Wiggle Sort II](https://leetcode.com/problems/wiggle-sort-ii/description/)
