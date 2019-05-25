public class Solution {
    public bool ValidTicTacToe(string[] board) {
        // math; string; check reverse condition
        // tc:O(n^2); sc:O(1)
        if(board == null || board.Length == 0) {
            return true;
        }
        int size = board.Length;
        int countX = 0, countO = 0;
        foreach(string str in board) {
            foreach(char c in str) {
                if(c == 'X') {
                    countX++;
                }
                else if(c == 'O') { // NOT else since including ' ' character
                    countO++;
                }
            }
        }
        if(countX != countO && countX != countO + 1) { // case 0
            return false;
        }
        if(CheckWinning(board, 'X') && countX != countO + 1) { // case 1
            return false;
        }
        if(CheckWinning(board, 'O') && countX != countO) { // case 2 (case 1 && case2 together covers both winning situation)
            return false;
        }
        return true;
    }
    
    private bool CheckWinning(string[] board, char player) {
        for(int i = 0; i <3; i++) {
            if(board[i][0] == player && board[i][1] == player && board[i][2] == player) { // row
                return true;
            }
            if(board[0][i] == player && board[1][i] == player && board[2][i] == player) { // column
                return true;
            }
        }
        if(board[0][0] == player && board[1][1] == player && board[2][2] == player) { // major diagonal
            return true;
        }
        if(board[0][2] == player && board[1][1] == player && board[2][0] == player) { // major diagonal
            return true;
        }
        return false;
    }
}