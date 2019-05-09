public class Solution {
    class Pair {
        public int row, col;
        
        public Pair(int row, int col) {
            this.row = row;
            this.col = col;
        }
    }
    
    /**
     * @param arrs: the arrays
     * @return: the number of the intersection of the arrays
     */
    public int intersectionOfArrays(int[][] arrs) {
        Comparator<Pair> comparator = new Comparator<Pair>() {
          public int compare(Pair x, Pair y) {
            return arrs[x.row][x.col] - arrs[y.row][y.col];
          }
        };
        
        Queue<Pair> queue = new PriorityQueue<>(arrs.length, comparator);
        
        for (int i = 0; i < arrs.length; i++) {
            if (arrs[i].length == 0) {
                return 0;
            }
            
            Arrays.sort(arrs[i]);
            queue.offer(new Pair(i, 0));
        }
        
        int lastValue = 0, count = 0;
        int intersection = 0;
        while (!queue.isEmpty()) {
            Pair pair = queue.poll();
            if (arrs[pair.row][pair.col] != lastValue || count == 0) {
                if (count == arrs.length) {
                  intersection++;
                }
                lastValue = arrs[pair.row][pair.col];
                count = 1;
            } else {
                count++;
            }
            
            pair.col++;
            if (pair.col < arrs[pair.row].length) {
              queue.offer(pair);
            }
        }
        
        // kickoff the last number
        if (count == arrs.length) {
            intersection++;
        }
        
        return intersection;
    }
}