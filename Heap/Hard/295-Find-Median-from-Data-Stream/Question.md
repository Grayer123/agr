# 295. Find Median from Data Stream

[Original Page](https://leetcode.com/problems/find-median-from-data-stream/)

Median is the middle value in an ordered integer list. If the size of the list is even, there is no middle value. So the median is the mean of the two middle value.

Examples:  

`[2,3,4]` , the median is `3`

`[2,3]`, the median is `(2 + 3) / 2 = 2.5`

Design a data structure that supports the following two operations:

*   void addNum(int num) - Add a integer number from the data stream to the data structure.
*   double findMedian() - Return the median of all elements so far.

For example:

<pre>add(1)
add(2)
findMedian() -> 1.5
add(3) 
findMedian() -> 2
</pre>

**Credits:**  
Special thanks to [@Louis1992](https://leetcode.com/discuss/user/Louis1992) for adding this problem and creating all test cases.

<div>

<div id="company_tags" class="btn btn-xs btn-warning">Hide Company Tags</div>

<span class="hidebutton" style="display: inline;">[Google](/company/google/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Hide Tags</div>

<span class="hidebutton" style="display: inline;">[Heap](/tag/heap/) [Design](/tag/design/)</span></div>