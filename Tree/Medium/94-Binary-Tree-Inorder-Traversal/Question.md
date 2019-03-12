# 94. Binary Tree Inorder Traversal

[Original Page](https://leetcode.com/problems/binary-tree-inorder-traversal/)

Given a binary tree, return the _inorder_ traversal of its nodes' values.

For example:  
Given binary tree `{1,#,2,3}`,  

<pre>   1
    \
     2
    /
   3
</pre>

return `[1,3,2]`.

**Note:** Recursive solution is trivial, could you do it iteratively?

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

<span class="hidebutton" style="display: inline;">[Microsoft](/company/microsoft/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Hide Tags</div>

<span class="hidebutton" style="display: inline;">[Tree](/tag/tree/) [Hash Table](/tag/hash-table/) [Stack](/tag/stack/)</span></div>

<div>

<div id="similar" class="btn btn-xs btn-warning">Hide Similar Problems</div>

<span class="hidebutton" style="display: inline;">[(M) Validate Binary Search Tree](/problems/validate-binary-search-tree/) [(M) Binary Tree Preorder Traversal](/problems/binary-tree-preorder-traversal/) [(H) Binary Tree Postorder Traversal](/problems/binary-tree-postorder-traversal/) [(M) Binary Search Tree Iterator](/problems/binary-search-tree-iterator/) [(M) Kth Smallest Element in a BST](/problems/kth-smallest-element-in-a-bst/) [(H) Closest Binary Search Tree Value II](/problems/closest-binary-search-tree-value-ii/) [(M) Inorder Successor in BST](/problems/inorder-successor-in-bst/)</span></div>