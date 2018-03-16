public class Solution {
    public bool RotateString(string A, string B) {
        //three times reverse
        //TC:O(n^2); SC:O(n)
        if(A == null || B == null || A.Length != B.Length){ //corner case
            return false;
        }
        if(A.Length == 0 && B.Length == 0){ //corner case
            return true;
        }
        for(int i = 0; i < A.Length; i++){
            char[] charArrA = A.ToCharArray();
            if(B == RotateString(ref charArrA, i)){
                return true;
            }
        }       
        return false;
    }
    
    private string RotateString(ref char[] arr, int idx){
        Array.Reverse(arr, 0, idx);
        Array.Reverse(arr, idx, arr.Length - idx);
        Array.Reverse(arr);
        return new string(arr);
    }
}