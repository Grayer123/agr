# 894. Pancake Sorting
[Original Page](https://www.lintcode.com/problem/pancake-sorting/description)

Given an an **unsorted** array, sort the given array. You are allowed to do only following operation on array.

flip(arr, i): **Reverse** array from 0 to i 
Unlike a traditional sorting algorithm, which attempts to sort with the fewest comparisons possible, the goal is to sort the sequence in as few reversals as possible.

```
Example:
Given array = [6, 7, 10, 11, 12, 20, 23]
Use flip(arr, i) function to sort the array.
```

**Notice:**
You only call flip function.
Don't allow to use any sort function or other sort methods.

```
Java：you can call FlipTool.flip(arr, i)
C++： you can call FlipTool::flip(arr, i)
Python2&3 you can call FlipTool.flip(arr, i)
```

---

* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Medium)
* Companies: * [Amazon](https://leetcode.com/company/amazon/)
* Related Topics: * [Array](https://leetcode.com/tag/array/) 	* [Sort](https://leetcode.com/tag/sort/)
* Similar Questions: 
  * [(M) 148. Sort List](https://leetcode.com/problems/sort-list/description/)
  * [(M) 280. Wiggle Sort](https://leetcode.com/problems/wiggle-sort/description/)
  * [(M) 324. Wiggle Sort II](https://leetcode.com/problems/wiggle-sort-ii/description/)
