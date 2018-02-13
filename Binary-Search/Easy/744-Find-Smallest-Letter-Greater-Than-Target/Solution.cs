public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        //binary search
        //tc:O(lgn); sc:O(1)
        if(letters == null || letters.Length == 0){
            throw new Exception("Invalid arguments");
        }
        int start = 0, end = letters.Length - 1;
        while(start < end){
            int mid = start + (end - start) / 2;
            if(letters[mid] - target <= 0){
                start = mid + 1;
            }
            else{
                end = mid;
            }
        }
        return letters[start] - target > 0 ? letters[start] : letters[0]; //handle corner case, if no larger than, then wrap around
    }
}