public class Solution {
    public bool RotateString(string A, string B) {
        //TC:O(n); SC:O(n)
        if(A == null || B == null || A.Length != B.Length){ //corner case
            return false;
        }
        return (A + A).Contains(B);       
    }
}