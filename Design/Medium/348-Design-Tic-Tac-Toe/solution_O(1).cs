public class TicTacToe {
    // tc:O(1); sc:O(n)

    /** Initialize your data structure here. */
    public TicTacToe(int n) {
        rows = new int[n];
        cols = new int[n];
        majorDiagonal = 0;
        minorDiagonal = 0;
    }
    
    /** Player {player} makes a move at ({row}, {col}).
        @param row The row of the board.
        @param col The column of the board.
        @param player The player, can be either 1 or 2.
        @return The current winning condition, can be either:
                0: No one wins.
                1: Player 1 wins.
                2: Player 2 wins. */
    public int Move(int row, int col, int player) {
        int numToAdd = player == 1 ? 1 : -1;
        rows[row] += numToAdd;
        cols[col] += numToAdd;
        if(row == col) {  // in major diagonal
            majorDiagonal += numToAdd;
        }
        if(row == cols.Length - col - 1) { // in minor diagonal
            minorDiagonal += numToAdd;
        }
        if(Math.Abs(rows[row]) == rows.Length || Math.Abs(cols[col]) == cols.Length  
            || Math.Abs(majorDiagonal) == rows.Length || Math.Abs(minorDiagonal) == rows.Length) {
            return player;
        }
        return 0;
    }
    
    private int[] rows;
    private int[] cols;
    private int majorDiagonal, minorDiagonal; 
}

/**
 * Your TicTacToe object will be instantiated and called as such:
 * TicTacToe obj = new TicTacToe(n);
 * int param_1 = obj.Move(row,col,player);
 */