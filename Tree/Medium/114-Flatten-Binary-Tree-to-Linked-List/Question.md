# 114. Flatten Binary Tree to Linked List

[Original Page](https://leetcode.com/problems/flatten-binary-tree-to-linked-list/)

Given a binary tree, flatten it to a linked list in-place.

For example,  
Given

<pre>         1
        / \
       2   5
      / \   \
     3   4   6
</pre>

The flattened tree should look like:  

<pre>   1
    \
     2
      \
       3
        \
         4
          \
           5
            \
             6
</pre>

[click to show hints.](#)

<div class="spoilers" style="display: block;">**Hints:**

If you notice carefully in the flattened tree, each node's right child points to the next node of a pre-order traversal.

</div>

<div>

<div id="company_tags" class="btn btn-xs btn-warning">Hide Company Tags</div>

<span class="hidebutton" style="display: inline;">[Microsoft](/company/microsoft/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Show Tags</div>

<span class="hidebutton">[Tree](/tag/tree/) [Depth-first Search](/tag/depth-first-search/)</span></div>