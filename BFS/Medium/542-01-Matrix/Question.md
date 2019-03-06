# 542. 01 Matrix  
[Original Page](https://leetcode.com/problems/01-matrix/)  

Given a matrix consists of 0 and 1, find the distance of the nearest 0 for each cell.  
The distance between two adjacent cells is 1.  

**Example1:**   
Input:  
<pre>
0 0 0
0 1 0
0 0 0
</pre>

Output:
<pre>
0 0 0
0 1 0
0 0 0
</pre>

**Example2:**  
Input:  
<pre>
0 0 0
0 1 0
1 1 1
</pre>

Output:
<pre>
0 0 0
0 1 0
1 2 1
</pre> 

**Note:**  
* The number of elements of the given matrix will not exceed 10,000.
* There are at least one 0 in the given matrix.
* The cells are adjacent in only four directions: up, down, left and right.


* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Midium)
* Companies: * [Uber](https://leetcode.com/company/uber/)
* Related Topics: * [DFS](https://leetcode.com/tag/depth-first-search/) * [BFS](https://leetcode.com/tag/breadth-first-search/) * [DP](https://leetcode.com/tag/dynamic-programming/)