# 1026. Maximum Difference Between Node and Ancestor     
[Original Page](https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/)     

Given the root of a binary tree, find the maximum value V for which there exists different nodes A and B where V = |A.val - B.val| and A is an ancestor of B.  

(A node A is an ancestor of B if either: any child of A is equal to B, or any child of A is an ancestor of B.)   

 ![](http://i68.tinypic.com/2whqcep.jpg)    

```
Input: [8,3,10,1,6,null,14,null,null,4,7,13]
Output: 7
Explanation: 
We have various ancestor-node differences, some of which are given below :
|8 - 3| = 5
|3 - 7| = 4
|8 - 1| = 7
|10 - 13| = 3
Among all possible differences, the maximum value of 7 is obtained by |8 - 1| = 7.
```  

**Note:**  
* The number of nodes in the tree is between 2 and 5000.
* Each node will have value between 0 and 100000.


<div>

<div id="company_tags" class="btn btn-xs btn-warning">Hide Company Tags</div>

<span class="hidebutton" style="display: inline;">[Microsoft](/company/microsoft/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Show Tags</div>

<span class="hidebutton">[Tree](/tag/tree/) [Depth-first Search](/tag/depth-first-search/)</span></div>