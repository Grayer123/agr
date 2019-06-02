public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        // math; Boyer-Moore Majority Vote algo; > [n/3] => at most 2 nums satisfys the condition
        // tc:O(n); sc:O(1)
        if(nums == null || nums.Length < 2) {
            return nums;
        }
        int count1 = 0, candidate1 = 0;
        int count2 = 0, candidate2 = 1;
        foreach(int num in nums) {
            if(candidate1 == num) {
                count1++;
            }
            else if(candidate2 == num) {
                count2++;
            }
            else if(count1 == 0) {
                candidate1 = num;
                count1++;
            }
            else if(count2 == 0) {
                candidate2 = num;
                count2++;
            }
            else {
                count1--;
                count2--;
            }
        }
        IList<int> res = new List<int>();
        count1 = 0;
        count2 = 0;
        foreach(int num in nums) { // verify majority element
            if(num == candidate1) {
                count1++;
            }
            else if(num == candidate2) {
                count2++;
            }
        }
        if(count1 > nums.Length / 3) {
            res.Add(candidate1);
        }
        if(count2 > nums.Length / 3) {
            res.Add(candidate2);
        }
        return res;
    }
}