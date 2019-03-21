# 578. Lowest Common Ancestor III        
[Original Page](https://www.lintcode.com/problem/lowest-common-ancestor-iii/description)     

Given the root and two nodes in a Binary Tree. Find the lowest common ancestor(LCA) of the two nodes.  
The lowest common ancestor is the node with largest depth which is the ancestor of both nodes.  
Return null if LCA does not exist.  


**Example 1:**  
<pre>
Input: 
{4, 3, 7, #, #, 5, 6}
3 5
Output: 
4
Explanation:
  4
 / \
3   7
   / \
  5   6

LCA(3, 5) = 4
</pre>

**Example 2:**  
<pre>
Input: 
{4, 3, 7, #, #, 5, 6}
5 8
Output: 
null
Explanation:
  4
 / \
3   7
   / \
  5   6

LCA(5, 8) = null
</pre>


<div>

<div id="company_tags" class="btn btn-xs btn-warning">Show Company Tags</div>

<span class="hidebutton">[LinkedIn](/company/LinkedIn/)</span><span class="hidebutton">[Facebook](/company/facebook/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Show Tags</div>

<span class="hidebutton">[Tree](/tag/tree/) [Array](/tag/array/) [Depth-first Search](/tag/depth-first-search/)</span></div>