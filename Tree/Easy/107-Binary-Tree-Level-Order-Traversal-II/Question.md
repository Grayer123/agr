# 107. Binary Tree Level Order Traversal II  

[Original Page](https://leetcode.com/problems/binary-tree-level-order-traversal-ii/)

Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).  

For example:  
Given binary tree `{3,9,20,#,#,15,7}`,  

<pre>    3
   / \
  9  20
    /  \
   15   7
</pre>

return its level order traversal as:  

<pre>[
  [15,7],
  [9,20],
  [3]
]
</pre>

confused what `"{1,#,2,3}"` means? [> read more on how binary tree is serialized on OJ.](#)

<div class="spoilers" style="display: none;">  
**OJ's Binary Tree Serialization:**

The serialization of a binary tree follows a level order traversal, where '#' signifies a path terminator where no node exists below.

Here's an example:  

<pre>   1
  / \
 2   3
    /
   4
    \
     5
</pre>

The above binary tree is serialized as `"{1,2,3,#,#,4,#,#,5}"`.</div>

<div>

<div id="company_tags" class="btn btn-xs btn-warning">Hide Company Tags</div>

<span class="hidebutton" style="display: inline;">[LinkedIn](/company/linkedin/) [Uber](/company/uber/) [Facebook](/company/facebook/) [Amazon](/company/amazon/) [Microsoft](/company/microsoft/) [Bloomberg](/company/bloomberg/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Hide Tags</div>

<span class="hidebutton" style="display: inline;">[Tree](/tag/tree/) [Breadth-first Search](/tag/breadth-first-search/)</span></div>

<div>

<div id="similar" class="btn btn-xs btn-warning">Hide Similar Problems</div>

<span class="hidebutton" style="display: inline;">[(M) Binary Tree Zigzag Level Order Traversal](/problems/binary-tree-zigzag-level-order-traversal/) [(M) Binary Tree Level Order Traversal](/problems/binary-tree-level-order-traversal/) [(E) Minimum Depth of Binary Tree](/problems/minimum-depth-of-binary-tree/) [(M) Binary Tree Vertical Order Traversal](/problems/binary-tree-vertical-order-traversal/)</span></div>