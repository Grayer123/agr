public class Solution {
    public int FindRadius(int[] houses, int[] heaters) {
        //sort; binary search
        //tc:O(nlgn); sc:O(1)
        if(houses == null || heaters == null || houses.Length == 0 || heaters.Length == 0){
            return -1; //corner case
        }
        Array.Sort(heaters);
        int res = 0;
        foreach(int house in houses){
            int index = Array.BinarySearch(heaters, house);
            if(index < 0){ //if index>0, then found the elem: heater in house => distance=0;
                index = ~index; //~index == (-index - 1)
                //heaters[index-1] would be the left heater; heaters[index] would be the right heater
                int leftDis = index >= 1 ? house - heaters[index - 1] : Int32.MaxValue;
                int rightDis = index < heaters.Length ? heaters[index] - house : Int32.MaxValue;
                int minDis = Math.Min(leftDis, rightDis); //get the smaller distance
                res = Math.Max(res, minDis);
            }
        }
        return res;
    }
}