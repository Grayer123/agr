public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        //hash table; C#
        //TC:O(n); sc:O(n)
        if (nums1.Length == 0 || nums2.Length == 0) {
                return new int[0];
        }
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        foreach(var num in nums1){
            if(!dict.ContainsKey(num)){
                dict[num] = 1;
            }
            else{
                dict[num]++;
            }
        }
        List<int> lst = new List<int>();
        foreach(var num in nums2){
            if(dict.ContainsKey(num) && dict[num] != 0){
                dict[num]--;
                lst.Add(num);
            }
        }
        return lst.ToArray();        
    }
}