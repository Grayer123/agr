# Lint612. K Closest Points   
[Original Page](https://leetcode.com/problems/sliding-window-maximum/)  

Given some points and an origin point in two-dimensional space, find k points which are nearest to the origin.
Return these points sorted by distance, if they are same in distance, sorted by the x-axis, and if they are same in the x-axis, sorted by y-axis.

```
Example 1:

Input: points = [[4,6],[4,7],[4,4],[2,5],[1,1]], origin = [0, 0], k = 3 
Output: [[1,1],[2,5],[4,4]]


Example 2:

Input: points = [[0,0],[0,9]], origin = [3, 1], k = 1
Output: [[0,0]]
```

**Note:** 
You may assume k is always valid, 1 ≤ k ≤ input array's size for non-empty array.  

**Follow up:**  
Could you solve it in linear time?  

<div>

<div id="company_tags" class="btn btn-xs btn-warning">Hide Company Tags</div>

<span class="hidebutton" style="display: inline;">[LinkedIn](/company/linkedin/) [Microsoft](/company/microsoft/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Hide Tags</div>

<span class="hidebutton" style="display: inline;">[Heap](/tag/heap/)</span></div>

<div>

<div id="similar" class="btn btn-xs btn-warning">Hide Similar Problems</div>

<span class="hidebutton" style="display: inline;">[(H) 76. Minimum Window Substring](https://leetcode.com/problems/minimum-window-substring/)</span></div>