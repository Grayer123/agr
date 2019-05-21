# 239. Sliding Window Maximum  
[Original Page](https://leetcode.com/problems/sliding-window-maximum/)  

Given an array nums, there is a sliding window of size k which is moving from the very left of the array to the very right. You can only see the k numbers in the window.   
Each time the sliding window moves right by one position. Return the max sliding window.  

```
Example1: 

Input: nums = [1,3,-1,-3,5,3,6,7], and k = 3
Output: [3,3,5,5,6,7] 
Explanation: 

Window position                Max
---------------               -----
[1  3  -1] -3  5  3  6  7       3
 1 [3  -1  -3] 5  3  6  7       3
 1  3 [-1  -3  5] 3  6  7       5
 1  3  -1 [-3  5  3] 6  7       5
 1  3  -1  -3 [5  3  6] 7       6
 1  3  -1  -3  5 [3  6  7]      7
```

**Note:** 
You may assume k is always valid, 1 ≤ k ≤ input array's size for non-empty array.  

**Follow up:**  
Could you solve it in linear time?  

<div>

<div id="company_tags" class="btn btn-xs btn-warning">Hide Company Tags</div>

<span class="hidebutton" style="display: inline;">[LinkedIn](/company/linkedin/) [Facebook](/company/facebook/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Hide Tags</div>

<span class="hidebutton" style="display: inline;">[Sliding Window](/tag/sliding-window/)</span></div>

<div>

<div id="similar" class="btn btn-xs btn-warning">Hide Similar Problems</div>

<span class="hidebutton" style="display: inline;">[(H) 76. Minimum Window Substring](https://leetcode.com/problems/minimum-window-substring/) [(H) Paint House II](/problems/paint-house-ii/)</span></div>