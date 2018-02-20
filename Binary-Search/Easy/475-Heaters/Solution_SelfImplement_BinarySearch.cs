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
            int index = LibraryBinarySearch(heaters, house);
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
    private int LibraryBinarySearch<T>(T[] nums, T target) where T : IComparable<T> {
        if (nums.Length == 0){
            return -1; // corner case
        }
        int start = 0, end = nums.Length - 1;
        while (start < end)
        {
            int mid = start + (end - start) / 2; // prevent overflow like (start+end)/2
            if (nums[mid].CompareTo(target) < 0){ // nums[mid] < target       
                start = mid + 1;
            }
            else{ // nums[mid] >= target          
                end = mid;
            }
        }
        if(nums[start].CompareTo(target) == 0){//return 0 based index if found
            return start;
        }
        else if(nums[start].CompareTo(target) > 0){ //return the complement of the insert_point
            return ~start;
        }
        else{//return the complement of the insert_point
            return ~(start + 1);
        }
    }
}