# 249. Group Shifted Strings

[Original Page](https://leetcode.com/problems/group-shifted-strings/)

Given a string, we can "shift" each of its letter to its successive letter, for example: `"abc" -> "bcd"`. We can keep "shifting" which forms the sequence:

<pre>"abc" -> "bcd" -> ... -> "xyz"</pre>

Given a list of strings which contains only lowercase alphabets, group all strings that belong to the same shifting sequence.

For example, given: `["abc", "bcd", "acef", "xyz", "az", "ba", "a", "z"]`,  
A solution is:

<pre>[
  ["abc","bcd","xyz"],
  ["az","ba"],
  ["acef"],
  ["a","z"]
]</pre>

<div>

<div id="company_tags" class="btn btn-xs btn-warning">Hide Company Tags</div>

<span class="hidebutton" style="display: inline;">[Google](/company/google/) [Uber](/company/uber/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Hide Tags</div>

<span class="hidebutton" style="display: inline;">[Hash Table](/tag/hash-table/) [String](/tag/string/)</span></div>

<div>

<div id="similar" class="btn btn-xs btn-warning">Hide Similar Problems</div>

<span class="hidebutton" style="display: inline;">[(M) Group Anagrams](/problems/anagrams/)</span></div>