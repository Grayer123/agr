# 323. Number of Connected Components in an Undirected Graph  
[Original Page](https://leetcode.com/problems/number-of-connected-components-in-an-undirected-graph/)    

Given n nodes labeled from `0` to `n - 1` and a list of `undirected` edges (each edge is a pair of nodes), write a function to find the number of connected components in an undirected graph.

**Example1:**  
Input: n = 5 and edges = [[0, 1], [1, 2], [3, 4]]  
<pre>
     0          3  
     |          |  
     1 --- 2    4   
</pre>  
Output: 2  

**Example2:**  
Input: n = 5 and edges = [[0, 1], [1, 2], [2, 3], [3, 4]]  
<pre>
     0           4
     |           |
     1 --- 2 --- 3
</pre>  
Output:  1   

**Note:**  
*  you can assume that no duplicate edges will appear in edges. Since all edges are undirected, [0,1] is the same as [1,0] and thus will not appear together in edges.  

* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Midium)
* Companies: * [LinkedIn](https://leetcode.com/company/linkedin/) * [Amazon](https://leetcode.com/company/amazon/)
* Related Topics: * [DFS](https://leetcode.com/tag/depth-first-search/) * [BFS](https://leetcode.com/tag/breadth-first-search/) * [Union Find](https://leetcode.com/tag/union-find/)
   * [graph](https://leetcode.com/tag/graph/)
* Similar Questions * [(M) 261. Graph Valid Tree](https://leetcode.com/problems/graph-valid-tree/)