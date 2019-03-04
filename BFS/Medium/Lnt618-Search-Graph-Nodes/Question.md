# Lnt 618. Search Graph Nodes     
[Original Page](https://www.lintcode.com/problem/search-graph-nodes/description)   

Given a `undirected graph`, a `node` and a target, return the nearest node to given node which value of it is target, return `NULL` if you can't find.  
There is a `mapping` store the nodes' values in the given parameters.

* It's guaranteed there is only one available solution


**Example1:**  
Input:  
{1,2,3,4#2,1,3#3,1,2#4,1,5#5,4}    
[3,4,5,50,50]  
1  
50  
Output:  
4  
Explanation:  
2------3  5  
 \     |  |   
  \    |  |  
   \   |  |  
    \  |  |  
      1 --4  
Give a node 1, target is 50  

there a hash named values which is [3,4,10,50,50], represent:  
Value of node 1 is 3  
Value of node 2 is 4  
Value of node 3 is 10  
Value of node 4 is 50  
Value of node 5 is 50  

Return node 4  


**Example2:** 
Input:  
{1,2#2,1}  
[0,1]  
1  
1  
Output:  
2   


* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Midium)
* Companies: * [Apple](https://leetcode.com/company/apple/)
* Related Topics: * [BFS](https://leetcode.com/tag/breadth-first-search/) * [graph](https://leetcode.com/tag/graph/)
* Similar Questions * [(M) 323. Number of Connected Components in an Undirected Graph](https://leetcode.com/problems/number-of-connected-components-in-an-undirected-graph/)