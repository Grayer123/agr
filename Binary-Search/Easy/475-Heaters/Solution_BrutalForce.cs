public class Solution {
    public int FindRadius(int[] houses, int[] heaters) {
        //sort;
        //tc:O(mn); sc:O(1)
        if(houses == null || heaters == null || houses.Length == 0 || heaters.Length == 0){
            return -1; //corner case
        }
        Array.Sort(heaters);
        int res = 0;
        foreach(int house in houses){ //brutal force to find the min radius => high TC => use Binary Search
            int dis = FindMinRadius(ref heaters, house);
            res = res < dis ? dis : res;
        }
        return res;
    }
    //auxiliary function to find the nearest left heater and right heater
    private int FindMinRadius(ref int[] heaters, int house) {
        int leftPos = -1, rightPos = -1;
        foreach(int heater in heaters){
            if(heater == house){ //heater is in the house 
                return 0;
            }
            else if(heater < house){
                leftPos = heater;
            }
            else{ //find the nearest right heater: break the loop
                rightPos = heater;
                break;
            }
        }
        int leftDis = leftPos != -1 ? house - leftPos : Int32.MaxValue;
        int rightDis = rightPos != -1 ? rightPos - house : Int32.MaxValue;
        return Math.Min(leftDis, rightDis);
    }
}