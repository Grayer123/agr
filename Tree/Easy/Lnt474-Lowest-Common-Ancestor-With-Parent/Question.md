# Lnt474. Lowest Common Ancestor II (With Parent Pointer)   
[Original Page](https://www.lintcode.com/problem/lowest-common-ancestor-ii/description)  

Given the root and two nodes in a Binary Tree. Find the lowest common ancestor(LCA) of the two nodes.  
The lowest common ancestor is the node with largest depth which is the ancestor of both nodes.  
The node has an extra attribute parent which point to the father of itself. The root's parent is null.    

**Example 1:**  
<pre>    
Input:
      4
     / \
    3   7
       / \
      5   6
and 3,5
Output: 4
Explanation:LCA(3, 5) = 4
</pre>
  
**Example 2:**  
<pre>    
Input:
      4
     / \
    3   7
       / \
      5   6
and 5,6
Output: 7
Explanation:LCA(5, 6) = 7
</pre>


<div>

<div id="tags" class="btn btn-xs btn-warning">Hide Tags</div>

<span class="hidebutton" style="display: inline;">[Tree](/tag/tree/)</span></div>

<div>