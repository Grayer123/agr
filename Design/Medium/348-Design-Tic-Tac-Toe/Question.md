# 348. Design Tic-Tac-Toe

[Original Page](https://leetcode.com/problems/design-tic-tac-toe/)

Design a Tic-tac-toe game that is played between two players on a _n_ x _n_ grid.

You may assume the following rules:

1.  A move is guaranteed to be valid and is placed on an empty block.
2.  Once a winning condition is reached, no more moves is allowed.
3.  A player who succeeds in placing _n_ of their marks in a horizontal, vertical, or diagonal row wins the game.

**Example:**  

<pre>Given _n_ = 3, assume that player 1 is "X" and player 2 is "O" in the board.

TicTacToe toe = new TicTacToe(3);

toe.move(0, 0, 1); -> Returns 0 (no one wins)
|X| | |
| | | |    // Player 1 makes a move at (0, 0).
| | | |

toe.move(0, 2, 2); -> Returns 0 (no one wins)
|X| |O|
| | | |    // Player 2 makes a move at (0, 2).
| | | |

toe.move(2, 2, 1); -> Returns 0 (no one wins)
|X| |O|
| | | |    // Player 1 makes a move at (2, 2).
| | |X|

toe.move(1, 1, 2); -> Returns 0 (no one wins)
|X| |O|
| |O| |    // Player 2 makes a move at (1, 1).
| | |X|

toe.move(2, 0, 1); -> Returns 0 (no one wins)
|X| |O|
| |O| |    // Player 1 makes a move at (2, 0).
|X| |X|

toe.move(1, 0, 2); -> Returns 0 (no one wins)
|X| |O|
|O|O| |    // Player 2 makes a move at (1, 0).
|X| |X|

toe.move(2, 1, 1); -> Returns 1 (player 1 wins)
|X| |O|
|O|O| |    // Player 1 makes a move at (2, 1).
|X|X|X|
</pre>

**Follow up:**  
Could you do better than O(_n_<sup>2</sup>) per `move()` operation?

**Hint:**

[Show Hint](#)

1.  Could you trade extra space such that `move()` operation can be done in O(1)?[Show More Hint](#)
2.  You need two arrays: int rows[n], int cols[n], plus two variables: diagonal, anti_diagonal.

<div>

<div id="company_tags" class="btn btn-xs btn-warning">Hide Company Tags</div>

<span class="hidebutton" style="display: inline;">[Microsoft](/company/microsoft/) [Google](/company/google/)</span></div>

<div>

<div id="tags" class="btn btn-xs btn-warning">Hide Tags</div>

<span class="hidebutton" style="display: inline;">[Design](/tag/design/)</span></div>