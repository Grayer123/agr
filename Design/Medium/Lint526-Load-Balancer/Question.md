# 526. Load Balancer   
[Original Page](https://www.lintcode.com/problem/load-balancer/description)  

Implement a load balancer for web servers. It provide the following functionality:

Add a new server to the cluster => `add(server_id)`.
Remove a bad server from the cluster => `remove(server_id)`.
Pick a server in the cluster randomly with `equal probability` => `pick()`.
At beginning, the cluster is empty. When pick() is called you need to randomly return a server_id in the cluster.

**Example:**  
```
Input:
  add(1)
  add(2)
  add(3)
  pick()
  pick()
  pick()
  pick()
  remove(1)
  pick()
  pick()
  pick()
Output:
  1
  2
  1
  3
  2
  3
  3
Explanation: The return value of pick() is random, it can be either 2 3 3 1 3 2 2 or other.
```

<div>

<div id="company_tags" class="btn btn-xs btn-warning">Hide Company Tags</div>

<span class="hidebutton" style="display: inline;">[Google](/company/google/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Hide Tags</div>

<span class="hidebutton" style="display: inline;">[Hash Table](/tag/hash-table/) [Design](/tag/design/)</span></div>

<div>

<div id="similar" class="btn btn-xs btn-warning">Hide Similar Problems</div>

<span class="hidebutton" style="display: inline;">[(M) Add and Search Word - Data structure design](/problems/add-and-search-word-data-structure-design/)</span></div>