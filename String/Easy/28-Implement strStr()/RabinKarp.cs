public class Solution {
    // rabin karp; Hash function
    // TC:O(n+m); SC:O(1)
    private int magicNum = 33;
    private int hashSize = 1000000;
    
    public int StrStr(string haystack, string needle) {
        if(haystack == null || needle == null) { //corner case
            return -1;
        }
        if(needle.Length == 0) { //corner case
            return 0;
        }
        if(haystack.Length < needle.Length) { //corner case
            return -1;
        }
        int lenNeedle = needle.Length;
        int hashNeedle = getHashCode(ref needle, lenNeedle);
        int baseNeedle = getBase(lenNeedle);
        int baseHash = getHashCode(ref haystack, lenNeedle);
        for(int i = 0; i <= haystack.Length - needle.Length; i++) {
            if(i != 0) {
                baseHash = (baseHash * magicNum - haystack[i - 1] * baseNeedle) % hashSize;
                baseHash = baseHash < 0 ? baseHash + hashSize : baseHash;
                baseHash = (baseHash + haystack[i + lenNeedle - 1]) % hashSize;
            }
            //if the hashcode is the same, then need to compare the string
            if(baseHash == hashNeedle && haystack.Substring(i, needle.Length).Equals(needle)) { 
                return i;
            }
        }
        return -1;
    }
    
    private int getHashCode(ref string s, int len) {
        int res = 0;
        for(int i = 0; i < len; i++) {
            res = (res * magicNum + s[i]) % hashSize;
        }
        return res;
    }
    
    private int getBase(int size) {
        int res = 1;
        while(size > 0) {
            res = (res * magicNum) % hashSize;
            size--;
        }
        return res;
    }
}