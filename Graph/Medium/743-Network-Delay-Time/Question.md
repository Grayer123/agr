# 743. Network Delay Time  
[Original Page](https://leetcode.com/problems/network-delay-time/)  

There are `N` network nodes, labelled `1 to N`.  

Given times, a list of travel times as `directed` edges `times[i] = (u, v, w)`, where u is the source node, v is the target node, and w is the time it takes for a signal to travel from source to target.   

Now, we send a signal from a certain node K. How long will be the shortest time for it take for all nodes to receive the signal? If it is impossible, return -1.  

**Note:**  
* N will be in the range [1, 100].  
* K will be in the range [1, N].  
* The length of times will be in the range [1, 6000].  
* All edges times[i] = (u, v, w) will have 1 <= u, v <= N and 0 <= w <= 100.  

[click to show more hints.](#)

<div class="spoilers" style="display: none;">**Hints:**

1.  We visit each node at some time, and if that time is better than the fastest time we've reached this node, we travel along outgoing edges in sorted order. Alternatively, we could use Dijkstra's algorithm.  

</div>

<div>

<div id="company_tags" class="btn btn-xs btn-warning">Hide Company Tags</div>

<span class="hidebutton" style="display: inline;">[Facebook](/company/facebook/) [Zenefits](/company/zenefits/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Hide Tags</div>

<span class="hidebutton" style="display: inline;">[Depth-first Search](/tag/depth-first-search/) [Breadth-first Search](/tag/breadth-first-search/) [Graph](/tag/graph/) </span></div>
