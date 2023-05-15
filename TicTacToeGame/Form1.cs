namespace TicTacToeGame
{
    public partial class MainForm : Form
    {
        private GameEngine engine = new GameEngine();


        public MainForm()
        {
            InitializeComponent();
        }

        private Panel GetPanelCellControlByCell(Cell cell)
        {
            if (cell == null || !cell.IsValidGameFieldCell())
            {
                return null;
            }
            string panelCtrlName = "panelCell" + cell.Row + "_" + cell.Column;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Name.Equals(panelCtrlName) && ctrl is Panel)
                {
                    return (Panel)ctrl;
                }
            }

            return null;
        }

        private void ClearGameField()
        {
            engine.ClearGameField();

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Panel panelCell = GetPanelCellControlByCell(Cell.From(row, col));
                    if (panelCell != null)
                    {
                        panelCell.Controls.Clear();
                    }
                }
            }

            engine.SetPlayer1Turn();
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FillCell(Panel panel, int row, int column)
        {

            engine.MakeTurnAndFillGameFieldCell(row, column);


            if (engine.IsWin())
            {
                // Движок вернул результат, что произошла победа одного из игроков
                MessageBox.Show("Победа! Выиграл " + engine.GetCurrentWinner(), "Крестики-Нолики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelPlayer1Score.Text = engine.GetPlayer1Score().ToString();
                labelPlayer2Score.Text = engine.GetPlayer2Score().ToString();
                ClearGameField();
            }
            else if (engine.IsDraw())
            {
                // Движок вернул результат, что произошла ничья
                MessageBox.Show("Ничья!", "Крестики-Нолики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearGameField();
            }
        }

        private void cell0_0_Click(object sender, EventArgs e)
        {
            FillCell((Panel)sender, 0, 0);
        }

        private void cell0_1_Click(object sender, EventArgs e)
        {
            FillCell((Panel)sender, 0, 1);
        }

        private void cell0_2_Click(object sender, EventArgs e)
        {
            FillCell((Panel)sender, 0, 2);
        }



        private void ResetGame()
        {
            ClearGameField();
            labelPlayer1Score.Text = engine.GetPlayer1Score().ToString();
            labelPlayer2Score.Text = engine.GetPlayer2Score().ToString();
        }

        private void StartNewGame()
        {
            ClearGameField();

            labelPlayer1Score.Text = engine.GetPlayer1Score().ToString();
            labelPlayer2Score.Text = engine.GetPlayer2Score().ToString();

        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void ResetGameButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void cell2_2_Click(object sender, EventArgs e)
        {
            FillCell((Panel)sender, 2, 2);
        }

        private void cell1_0_Click(object sender, EventArgs e)
        {
            FillCell((Panel)sender, 1, 0);
        }

        private void cell1_1_Click(object sender, EventArgs e)
        {
            FillCell((Panel)sender, 1, 1);
        }

        private void cell1_2_Paint(object sender, PaintEventArgs e)
        {
            FillCell((Panel)sender, 1, 2);
        }

        private void cell2_1_Click(object sender, EventArgs e)
        {
            FillCell((Panel)sender, 2, 1);
        }

        private void cell2_0_Click(object sender, EventArgs e)
        {
            FillCell((Panel)sender, 2, 0);
        }
    }
}