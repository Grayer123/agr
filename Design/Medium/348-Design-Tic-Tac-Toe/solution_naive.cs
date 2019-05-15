public class TicTacToe {
    // TC:O(n); SC:O(n^2)

    /** Initialize your data structure here. */
    public TicTacToe(int n) {
        matrix = new int[n, n];
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
        matrix[row, col] = player;
        return CheckResult(row, col, player);
    }
    
    private int CheckResult(int row, int col, int player) {
        if(CheckRow(row, player) || CheckColumn(col, player) || CheckDiagnal(player)) {
             return player;
        }
        return 0;
        
    }
    
    private bool CheckRow(int row, int player) {
        for(int i = 0; i < matrix.GetLength(0); i++) {
            if(matrix[row, i] != player) {
                return false;
            }
        }
        return true;
    }
    
    private bool CheckColumn(int col, int player) {
        for(int i = 0; i < matrix.GetLength(0); i++) {
            if(matrix[i, col] != player) {
                return false;
            }
        }
        return true;
    }
    
    private bool CheckDiagnal(int player) {
        bool isWinning = true;
        for(int i = 0; i < matrix.GetLength(0); i++) {  // major diagonal
            if(matrix[i, i] != player) {
                isWinning = false;
                break;
            }
        }
        
        if(!isWinning) {
            for(int i = 0; i < matrix.GetLength(0); i++) {
                if(matrix[i, matrix.GetLength(0) - i - 1] != player) {  // minor diagonal
                    return false;
                }
            }
        }
        return true;
    }
    
    private int[,] matrix;
}

/**
 * Your TicTacToe object will be instantiated and called as such:
 * TicTacToe obj = new TicTacToe(n);
 * int param_1 = obj.Move(row,col,player);
 */