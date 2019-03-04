# 261. Graph Valid Tree  

[Original Page](https://leetcode.com/problems/graph-valid-tree/)  

Given n nodes labeled from `0` to `n-1` and a list of `undirected edges` (each edge is a pair of nodes), write a function to check whether these edges make up a `valid tree`.  

**Example1:**  
Input: n = 5, and edges = [[0,1], [0,2], [0,3], [1,4]]  
Output: true  

**Example2:**  
Input: n = 5, and edges = [[0,1], [1,2], [2,3], [1,3], [1,4]]  
Output: false   

**Note:**  
*  you can assume that no duplicate edges will appear in edges. Since all edges are undirected, [0,1] is the same as [1,0] and thus will not appear together in edges.  

**Hint1:**   
* Given n = 5 and edges = [[0, 1], [1, 2], [3, 4]], what should your return? Is this case a valid tree?

**Hint2:** 
According to the definition of tree on Wikipedia: “a tree is an undirected graph in which any two vertices are connected by exactly one path. In other words, any connected graph without simple cycles is a tree.”


* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Midium)
* Companies: * [LinkedIn](https://leetcode.com/company/linkedin/)
* Related Topics: * [DFS](https://leetcode.com/tag/depth-first-search/) * [BFS](https://leetcode.com/tag/breadth-first-search/) * [Union Find](https://leetcode.com/tag/union-find/)
   * [graph](https://leetcode.com/tag/graph/)
* Similar Questions * [(M) 323. Number of Connected Components in an Undirected Graph](https://leetcode.com/problems/number-of-connected-components-in-an-undirected-graph/)