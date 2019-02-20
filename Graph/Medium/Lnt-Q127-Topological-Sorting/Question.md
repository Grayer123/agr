# 127. Topological Sorting

[Original Page](https://www.lintcode.com/problem/topological-sorting/description)

Given an directed graph, a topological order of the graph nodes is defined as follow:  
   
For each directed edge A -> B in graph, A must before B in the order list.  
The first node in the order can be any node in the graph with no nodes direct to it.  
Find any topological order for the given graph.   

You can assume that there is at least one topological order in the graph.  

Example:  
For graph as follow:  

![](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThE9AgZZszyhwe0o9qpp3VyizdIj9kWwMY50HiQEysXvkSLsoZ) 

The topological order can be:  

[0, 1, 2, 3, 4, 5]  
[0, 2, 3, 1, 5, 4]  
...  
Challenge  
Can you do it in both BFS and DFS?  

<div>

<div id="company_tags" class="btn btn-xs btn-warning">Show Company Tags</div>

<span class="hidebutton" style="display: none;">[Facebook](/company/facebook/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Show Tags</div>

<span class="hidebutton" style="display: none;">[Depth-first Search](/tag/depth-first-search/) [Breadth-first Search](/tag/breadth-first-search/) [Graph](/tag/graph/)</span></div>

<div>

<div id="similar" class="btn btn-xs btn-warning">Show Similar Problems</div>

<span class="hidebutton" style="display: none;">[(H) Copy List with Random Pointer](/problems/copy-list-with-random-pointer/)</span></div>