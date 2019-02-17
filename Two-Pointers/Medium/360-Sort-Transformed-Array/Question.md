# 360. Sort Transformed Array  
[Original Page](https://leetcode.com/problems/sort-transformed-array/)

Given a `sorted` array of integers nums and integer values a, b and c. Apply a quadratic function of the form `f(x) = ax2 + bx + c` to each element x in the array.

The returned array must be in sorted order.

Expected time complexity: `O(n)`


**Example 1:**
Input: nums = [-4,-2,2,4], a = 1, b = 3, c = 5  
Output: [3,9,15,33]  

**Example 2:**
Input: nums = [-4,-2,2,4], a = -1, b = 3, c = 5  
Output: [-23,-5,1,7]  
 
**Hint 1:**
x^2 + x will form a parabola.  

**Hint 2:**
Parameter A in: A * x^2 + B * x + C dictates the shape of the parabola.  
Positive A means the parabola remains concave (high-low-high), but negative A inverts the parabola to be convex (low-high-low).  

---

* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Medium)
* Companies:  * [Amazon](https://leetcode.com/company/amazon/) * [Google](https://leetcode.com/company/google/)
* Related Topics: * [Two Pointers](https://leetcode.com/tag/two-pointers/) 	* [Math](https://leetcode.com/tag/math/)
