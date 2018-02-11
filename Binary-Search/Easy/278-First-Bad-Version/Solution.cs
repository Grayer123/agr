/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        //tc: O(lgn); sc:O(1)
        if(n <= 1){ //corner case
            return n;
        }
        int start = 0, end = n;
        while(start < end){
            int mid = start + (end - start) / 2;
            if(IsBadVersion(mid)){
                end = mid;
            }
            else{
                start = mid + 1;
            }
        }
        return start;
    }
}