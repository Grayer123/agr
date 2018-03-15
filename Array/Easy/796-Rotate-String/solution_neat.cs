public class Solution {
    public bool RotateString(string A, string B) {
        //TC:O(n); SC:O(1)
        if(A == null || B == null || A.Length != B.Length){ //corner case
            return false;
        }
        return (A + A).Contains(B);
        
    }
}