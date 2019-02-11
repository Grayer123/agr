public class Solution {
    public bool IsLongPressedName(string name, string typed) {
        // two pointers
        // tc:O(n); sc:O(1)
        int pointerName = 0, pointerTyped = 0;
        while(pointerName < name.Length && pointerTyped < typed.Length) {
            if(name[pointerName] != typed[pointerTyped]) {
                if(pointerTyped > 0 && typed[pointerTyped] == typed[pointerTyped - 1]) {
                    pointerTyped++;
                }
                else {
                    return false;
                }
            }
            else {
                pointerName++;
                pointerTyped++;
            }
        }
        if(pointerName != name.Length) {
            return false;
        }
        while(pointerTyped > 0 && pointerTyped < typed.Length) {
            if(typed[pointerTyped] != typed[pointerTyped - 1]) {
                return false;
            }
            pointerTyped++;
        }
        return true;
    }
}