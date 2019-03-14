# 98. Validate Binary Search Tree      
[Original Page](https://leetcode.com/problems/validate-binary-search-tree/)   

Given a binary tree, determine if it is a valid binary search tree (BST).  
Assume a BST is defined as follows:  

* The left subtree of a node contains only nodes with keys less than the node's key.
* The right subtree of a node contains only nodes with keys greater than the node's key.
* Both the left and right subtrees must also be binary search trees.


**Example 1:**  
<pre>
Input:
    2
   / \
  1   3

Output: true
</pre>

**Example 2:**  
<pre>
    5
   / \
  1   4
     / \
    3   6
    
Output: false
Explanation: The input is: [5,1,4,null,null,3,6]. The root node's value
             is 5 but its right child's value is 4.
</pre>

**Note:**  
You may assume that duplicates do not exist in the tree.  

<div>

<div id="company_tags" class="btn btn-xs btn-warning">Show Company Tags</div>

<span class="hidebutton">[Bloomberg](/company/bloomberg/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Show Tags</div>

<span class="hidebutton">[Tree](/tag/tree/) [Array](/tag/array/) [Depth-first Search](/tag/depth-first-search/)</span></div>

<div>

<div id="similar" class="btn btn-xs btn-warning">Show Similar Problems</div>

<span class="hidebutton">[(M) Construct Binary Tree from Inorder and Postorder Traversal](/problems/construct-binary-tree-from-inorder-and-postorder-traversal/)</span></div>