# 101. Symmetric Tree

[Original Page](https://leetcode.com/problems/symmetric-tree/)

Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).

For example, this binary tree is symmetric:

<pre>    1
   / \
  2   2
 / \ / \
3  4 4  3
</pre>

But the following is not:  

<pre>    1
   / \
  2   2
   \   \
   3    3
</pre>

**Note:**  
Bonus points if you could solve it both recursively and iteratively.

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

<span class="hidebutton" style="display: inline;">[Microsoft](/company/microsoft/) [Bloomberg](/company/bloomberg/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Show Tags</div>

<span class="hidebutton">[Tree](/tag/tree/) [Depth-first Search](/tag/depth-first-search/)</span></div>