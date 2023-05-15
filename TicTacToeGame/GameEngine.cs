using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToeGame
{
    internal class GameEngine
    {
        private WhooseTurn Turn { get; set; } = WhooseTurn.Player1;

        private string Winner { get; set; } = "";

        private int player1Score;
        private int player2Score;
        private int numberOfDraws;


        private const char X_MARK = 'X';
        private const char EMPTY_CELL = '-';
        private const char O_MARK = 'O';


        private char[][] gameField = new char[][]
        {
            new char[] {EMPTY_CELL, EMPTY_CELL, EMPTY_CELL },
            new char[] {EMPTY_CELL, EMPTY_CELL, EMPTY_CELL },
            new char[] {EMPTY_CELL, EMPTY_CELL, EMPTY_CELL }
        };

        public WhooseTurn GetCurrentTurn()
        {
            return Turn;
        }

        public string GetCurrentWinner()
        {
            return Winner;
        }

        public bool IsPlayer1Turn()
        {
            return Turn == WhooseTurn.Player1;
        }

        public void SetPlayer1Turn()
        {
            Turn = WhooseTurn.Player1;
        }

        public void ResetScore()
        {
            player1Score = 0;
            player2Score = 0;
            numberOfDraws = 0;
        }

        public void StartGame()
        {
            ResetScore();

            Turn = WhooseTurn.Player1;
        }

        public string GetCurrentMarkLabelString()
        {
            if (IsPlayer1Turn())
            {
                return X_MARK.ToString();
            }
            else
            {
                return O_MARK.ToString();
            }
        }

        public Color GetCurrentMarkLabelColor()
        {
            if (IsPlayer1Turn())
            {
                return Color.Gold;
            }
            else
            {
                return Color.Fuchsia;
            }
        }

        public int GetPlayer1Score()
        {
            return player1Score;
        }

        public int GetPlayer2Score()
        {
            return player2Score;
        }

        public void ClearGameField()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    gameField[row][col] = EMPTY_CELL;
                }
            }
        }

        public void MakeTurnAndFillGameFieldCell(int row, int column)
        {
            if (IsPlayer1Turn())
            {
                gameField[row][column] = X_MARK;
                Turn = WhooseTurn.Player2;
            }
            else
            {
                gameField[row][column] = O_MARK;
                Turn = WhooseTurn.Player1;
            }
        }

        public bool IsAnyFreeCell()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (gameField[row][col] == EMPTY_CELL)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsDraw()
        {
            bool isNoFreeCellsLeft = !IsAnyFreeCell();
            if (isNoFreeCellsLeft)
            {
                numberOfDraws++;
            }
            return isNoFreeCellsLeft;
        }


        private bool CheckWinOnHorizontalCellsAndUpdateWinner()
        {
            for (int row = 0; row < 3; row++)
            {
                int sumX = 0; int sumO = 0;
                for (int col = 0; col < 3; col++)
                {
                    sumX += gameField[row][col] == X_MARK ? 1 : 0;
                    sumO += gameField[row][col] == O_MARK ? 1 : 0;
                }
                if (sumX == 3)
                {
                    // X победили
                    Winner = "Player1";
                    player1Score++;
                    return true;
                }
                else if (sumO == 3)
                {
                    // O победили
                    Winner = "Player2";
                    player2Score++;
                    return true;
                }
            }
            return false;
        }

        private bool CheckWinOnVerticalCellsAndUpdateWinner()
        {
            for (int col = 0; col < 3; col++)
            {
                int sumX = 0; int sumO = 0;
                for (int row = 0; row < 3; row++)
                {
                    sumX += gameField[row][col] == X_MARK ? 1 : 0;
                    sumO += gameField[row][col] == O_MARK ? 1 : 0;
                }

                if (sumX == 3)
                {
                    // X победили
                    Winner = "Player1";
                    player1Score++;
                    return true;
                }
                else if (sumO == 3)
                {
                    // O победили
                    Winner = "Player2";
                    player2Score++;
                    return true;
                }
            }
            return false;
        }

        private bool CheckWinOnDiagonalCellsAndUpdateWinner()
        {
            int diag1sumX = 0, diag2sumX = 0;
            int diag1sumO = 0, diag2sumO = 0;
            for (int row = 0; row < 3; row++)
            {
                if (gameField[row][row] == O_MARK)
                {
                    diag1sumO++;
                }
                if (gameField[row][row] == X_MARK)
                {
                    diag1sumX++;
                }
                if (gameField[row][2 - row] == O_MARK)
                {
                    diag2sumO++;
                }
                if (gameField[row][2 - row] == X_MARK)
                {
                    diag2sumX++;
                }
            }

            if (diag1sumX == 3 || diag2sumX == 3)
            {
                Winner = "Player1";
                player1Score++;
                return true;
            }
            else if (diag1sumO == 3 || diag2sumO == 3)
            {
                Winner = "Player2";
                player2Score++;
                return true;
            }

            return false;
        }

        public bool IsWin()
        {
            if (CheckWinOnHorizontalCellsAndUpdateWinner())
            {
                return true;
            }

            if (CheckWinOnVerticalCellsAndUpdateWinner())
            {
                return true;
            }

            if (CheckWinOnDiagonalCellsAndUpdateWinner())
            {
                return true;
            }

            return false;
        }

        internal enum WhooseTurn
        {
            Player1,
            Player2
        }

    }
}
