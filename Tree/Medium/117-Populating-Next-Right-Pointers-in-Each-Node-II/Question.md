# 117. Populating Next Right Pointers in Each Node II  
[Original Page](https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii/)   

Given a binary tree

struct Node {  
  int val;   
  Node *left;  
  Node *right;  
  Node *next;  
}  
Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.  

Initially, all next pointers are set to NULL.  

![](https://assets.leetcode.com/uploads/2019/02/15/117_sample.png)  

```
Input: {"$id":"1","left":{"$id":"2","left":{"$id":"3","left":null,"next":null,"right":null,"val":4},"next":null,"right":{"$id":"4","left":null,"next":null,"right":null,"val":5},"val":2},"next":null,"right":{"$id":"5","left":null,"next":null,"right":{"$id":"6","left":null,"next":null,"right":null,"val":7},"val":3},"val":1}

Output: {"$id":"1","left":{"$id":"2","left":{"$id":"3","left":null,"next":{"$id":"4","left":null,"next":{"$id":"5","left":null,"next":null,"right":null,"val":7},"right":null,"val":5},"right":null,"val":4},"next":{"$id":"6","left":null,"next":null,"right":{"$ref":"5"},"val":3},"right":{"$ref":"4"},"val":2},"next":null,"right":{"$ref":"6"},"val":1}

Explanation: Given the above binary tree (Figure A), your function should populate each next pointer to point to its next right node, just like in Figure B.
```

**Note:**  
1. You may only use constant extra space.
2. Recursive approach is fine, implicit stack space does not count as extra space for this problem.

<div class="spoilers" style="display: block;">**Hints:**

If you notice carefully in the flattened tree, each node's right child points to the next node of a pre-order traversal.

</div>

<div>

<div id="company_tags" class="btn btn-xs btn-warning">Hide Company Tags</div>

<span class="hidebutton" style="display: inline;">[Microsoft](/company/microsoft/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Show Tags</div>

<span class="hidebutton">[Tree](/tag/tree/) [Depth-first Search](/tag/depth-first-search/)</span></div>