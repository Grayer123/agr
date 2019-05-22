# Lnt 1563. Shortest path to the destination   
[Original Page](https://www.lintcode.com/problem/shortest-path-to-the-destination/description?_from=ladder&&fromId=88)  

Given a 2D array representing the coordinates on the map, there are only values `0, 1, 2` on the map.   
value 0 means that it can pass, value 1 means not passable, value 2 means target place.   
Starting from the coordinates [0,0],You can only go up, down, left and right.  
Find the shortest path that can reach the destination, and return the length of the path.  

**Example1:**    
<pre>
Input:
[
 [0, 0, 0],
 [0, 0, 1],
 [0, 0, 2]
]
Output: 4
Explanation: [0,0] -> [1,0] -> [2,0] -> [2,1] -> [2,2]
</pre>
  
**Example2:**   
<pre>
Input:
[
    [0,1],
    [0,1],
    [0,0],
    [0,2]
]
Output: 4
Explanation: [0,0] -> [1,0] -> [2,0] -> [3,0] -> [3,1]
</pre>
  
---  

* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Midium)
* Companies: * [Amazon](https://leetcode.com/company/amazon/) * [Microsoft](https://leetcode.com/company/microsoft/)
* Related Topics: * [BFS](https://leetcode.com/tag/breadth-first-search/) 