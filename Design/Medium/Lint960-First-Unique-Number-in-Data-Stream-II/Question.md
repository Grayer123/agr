# 960. First Unique Number in Data Stream II  
[Original Page](https://www.lintcode.com/problem/first-unique-number-in-data-stream-ii/description)  

We need to implement a data structure named `DataStream`. There are two methods required to be implemented:

`void add(number)` // add a new number
`int firstUnique()` // return first unique number
You can assume that there must be at least one unique number in the stream when calling the firstUnique.

```
Example 1:

Input:
add(1)
add(2)
firstUnique()
add(1)
firstUnique()
Output:
[1,2]
```   

```
Example 2:

Input:
add(1)
add(2)
add(3)
add(4)
add(5)
firstUnique()
add(1)
firstUnique()
add(2)
firstUnique()
add(3)
firstUnique()
add(4)
firstUnique()
add(5)
add(6)
firstUnique()
Output:
[1,2,3,4,5,6]
```

<div>

<div id="company_tags" class="btn btn-xs btn-warning">Hide Company Tags</div>

<span class="hidebutton" style="display: inline;">[Google](/company/google/) [Uber](/company/uber/) [Zenefits](/company/zenefits/) [Amazon](/company/amazon/) [Microsoft](/company/microsoft/) [Bloomberg](/company/bloomberg/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Hide Tags</div>

<span class="hidebutton" style="display: inline;">[Design](/tag/design/)</span></div>