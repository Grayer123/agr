using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDebug
{
    public class PancakeSort
    {
        public void PancakeSorting(int[] arr) {
            if(arr == null || arr.Length == 0) {
                return;
            }
            int curIdx = arr.Length - 1;
            while(curIdx > 0) {
                int idx = FindMax(arr, curIdx);
                Flip(arr, idx);
                Flip(arr, curIdx);
                curIdx--;
            }
        }

        // flip(arr, i): reverse array from 0 to idx 
        private void Flip(int[] arr, int idx) {
            if(arr == null || arr.Length == 0) {
                return;
            }
            Array.Reverse(arr, 0, idx + 1);
        }

        private int FindMax(int[] arr, int endIdx) {
            int max = arr[0];
            int index = 0;
            for(int i = 1; i <= endIdx; i++) {
                if(max < arr[i]) {
                    max = arr[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
