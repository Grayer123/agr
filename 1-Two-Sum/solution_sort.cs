public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //two pointer; sort
        //TC:O(nlogn); SC:O(n)
        if(nums.Length < 2){
            throw new ArgumentException("Invalid Input.");
        }
        var lst = nums.ToList();
        lst.Sort();
        int left = 0, right = nums.Length - 1;
        bool flag = false;
        while(left < right){
            if(lst[left] == target - lst[right]){
                return AddItem(nums, lst[left], lst[right]);
            }
            else if(lst[left] < target - lst[right]){
                left++;
            }
            else{
                right--;
            }
        }
        throw new ArgumentException("No two sum solution");
    }
    
    public int[] AddItem(int[] nums, int val1, int val2){
        List<int> res = new List<int>();
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == val1 || nums[i] == val2){
                res.Add(i);
                if(res.Count == 2){
                    break;;
                }
            }
        }
        return res.ToArray();
    }
}