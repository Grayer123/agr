# 133. Clone Graph

[Original Page](https://leetcode.com/problems/clone-graph/)

Clone an undirected graph. Each node in the graph contains a `label` and a list of its `neighbors`.

<div>  
**OJ's undirected graph serialization:**

Nodes are labeled uniquely.

We use `#` as a separator for each node, and `,` as a separator for node label and each neighbor of the node.

As an example, consider the serialized graph `<font color="red">{<font color="black">0</font>,1,2#</font><font color="blue"><font color="black">1</font>,2#</font><font color="green"><font color="black">2</font>,2}</font>`.

The graph has a total of three nodes, and therefore contains three parts as separated by `#`.

1.  First node is labeled as `<font color="black">0</font>`. Connect node `<font color="black">0</font>` to both nodes `<font color="red">1</font>` and `<font color="red">2</font>`.
2.  Second node is labeled as `<font color="black">1</font>`. Connect node `<font color="black">1</font>` to node `<font color="blue">2</font>`.
3.  Third node is labeled as `<font color="black">2</font>`. Connect node `<font color="black">2</font>` to node `<font color="green">2</font>` (itself), thus forming a self-cycle.

Visually, the graph looks like the following:

<pre>       1
      / \
     /   \
    0 --- 2
         / \
         \_/
</pre>

</div>

<div>

<div id="company_tags" class="btn btn-xs btn-warning">Show Company Tags</div>

<span class="hidebutton" style="display: none;">[Facebook](/company/facebook/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Show Tags</div>

<span class="hidebutton" style="display: none;">[Depth-first Search](/tag/depth-first-search/) [Breadth-first Search](/tag/breadth-first-search/) [Graph](/tag/graph/)</span></div>

<div>

<div id="similar" class="btn btn-xs btn-warning">Show Similar Problems</div>

<span class="hidebutton" style="display: none;">[(H) Copy List with Random Pointer](/problems/copy-list-with-random-pointer/)</span></div>