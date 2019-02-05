# Lnt31. Partition Array
[Original Page](https://www.lintcode.com/problem/partition-array/description)

Given an array nums of integers and an int k, partition the array (i.e move the elements in "nums") such that:  
All elements `< k` are moved to the left  
All elements `>= k` are moved to the right  
Return the partitioning index, i.e the first index i `nums[i] >= k`.  
  
**Note:**
You should do really partition in array nums instead of just counting the numbers of integers smaller than k.
If all elements in nums are smaller than k, then return nums.length

**Example1:**  
Input: [],9  
Output: 0  

**Example1:**    
Input: [3,2,2,1],2  
Output:1
Explanation: the real array is[1,2,2,3].So return 1    

---

* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Medium)
* Related Topics: * [Two Pointers](https://leetcode.com/tag/two-pointers/) 	* [Hash Table](https://leetcode.com/tag/hash-table/)
