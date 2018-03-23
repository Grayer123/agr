public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        if(nums1.Length == 0 || nums2.Length == 0){//corner case
            return new int[0]; 
        }
        Dictionary<int, int> ht = new Dictionary<int, int>();
        foreach(int num in nums1){ //traverse array nums1, and add each num in Dictionary
            if(!ht.ContainsKey(num)){
                ht.Add(num, 1);
            }
            else{
                ht[num]++;
            }
        }
        ICollection<int> collection = new System.Collections.ObjectModel.Collection<int>();
        foreach(int num in nums2){
            if(ht.ContainsKey(num)){
                if(--ht[num] == 0){ //decrease the value by 1, and if value = 0, then remove the key
                    ht.Remove(num);
                }
                collection.Add(num);
            }
        }
        return collection.ToArray();
    }
}