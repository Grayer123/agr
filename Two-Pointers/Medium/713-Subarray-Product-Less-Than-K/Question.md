# 713. Subarray Product Less Than K  
[Original Page](https://leetcode.com/problems/subarray-product-less-than-k/)

Your are given an array of positive integers nums.  

Count and print the number of (contiguous) subarrays where the product of all the elements in the subarray is less than k.  


**Example 1:**    
Input: nums = [10, 5, 2, 6], k = 100  
Output: 8  
Explanation: The 8 subarrays that have product less than 100 are: [10], [5], [2], [6], [10, 5], [5, 2], [2, 6], [5, 2, 6].  
Note that [10, 5, 2] is not included as the product of 100 is not strictly less than k.  
   
**Note:**
1. 0 < nums.length <= 50000.
2. 0 < nums[i] < 1000.
3. 0 <= k < 10^6.

**Hint:**  
For each j, let opt(j) be the smallest i so that nums[i] * nums[i+1] * ... * nums[j] is less than k. opt is an increasing function.  

---

* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Medium)
* Companies:  * [Coursera](https://leetcode.com/company/coursera/) 
* Related Topics: * [Array](https://leetcode.com/tag/array/) 	* [Two Pointers](https://leetcode.com/tag/two-pointers/)
