# 598. Zombie in Matrix       
[Original Page](https://www.lintcode.com/problem/zombie-in-matrix/description)     

Given a 2D grid, each cell is either a `wall 2`, a `zombie 1` or `people 0` (the number zero, one, two).Zombies can turn the `nearest people`(`up/down/left/right`) into zombies every day, but can not through wall. How long will it take to turn all people into zombies? Return `-1` if can not turn all people into zombies.


**Example1:**  
Input:  
[[0,1,2,0,0],  
 [1,0,0,2,1],  
 [0,1,0,0,0]]  
Output:  
2  
  
**Example2:**   
Input:  
[[0,0,0],  
 [0,0,0],  
 [0,0,1]]  
Output:  
4    

* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Midium)
* Companies: * [Apple](https://leetcode.com/company/apple/)
* Related Topics: * [BFS](https://leetcode.com/tag/breadth-first-search/)