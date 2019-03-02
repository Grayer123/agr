# 269. Alien Dictionary  
[Original Page](https://leetcode.com/problems/alien-dictionary/)  


There is a new alien language which uses the latin alphabet. However, the order among letters are unknown to you.   
You receive a list of `non-empty` words from the dictionary, where words are `sorted lexicographically by the rules of this new language`. Derive the order of letters in this language.

**Example 1:**   
Input:  
[  
  "wrt",  
  "wrf",  
  "er",  
  "ett",  
  "rftt"  
]  
Output: "wertf"   

**Example 2:**  
Input:  
[  
  "z",  
  "x"  
]   
Output: "zx"  

**Example 3:**  
Input:  
[  
  "z",  
  "x",  
  "z"  
]   
Output: ""   
Explanation: The order is invalid, so return "".  

**Note:**  

* You may assume all letters are in lowercase.
* You may assume that if a is a prefix of b, then a must appear before b in the given dictionary.
* If the order is invalid, return an empty string.
* There may be multiple valid order of letters, return any one of them is fine.

<div>

<div id="tags" class="btn btn-xs btn-warning">Hide Tags</div>

<span class="hidebutton" style="display: inline;">[Graph](/tag/graph/) [Topological Sort](/tag/topological-sort/)</span></div>