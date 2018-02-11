public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        //tc:O(n); sc:O(1)
        //two pointers
        if(numbers == null || numbers.Length < 2){//corner case
            return new int[0];
        }
        //int[] res = new int[2];
        int start = 0, end = numbers.Length - 1;
        while(start < end){
            if(target - numbers[start] == numbers[end]){
                return new int[]{start + 1, end + 1};
            }
            else if(target - numbers[start] < numbers[end]){
                end--;
            }
            else{
                start++;
            }
        }
        return new int[0];
    }
}