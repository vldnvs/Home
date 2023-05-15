namespace TicTacToeGame
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            cell0_0 = new Panel();
            cell0_1 = new Panel();
            cell0_2 = new Panel();
            cell1_0 = new Panel();
            cell1_1 = new Panel();
            cell1_2 = new Panel();
            cell2_0 = new Panel();
            cell2_1 = new Panel();
            cell2_2 = new Panel();
            labelPlayer1Score = new Label();
            labelPlayer2Score = new Label();
            NewGameButton = new Button();
            ResetGameButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(832, 12);
            button1.Name = "button1";
            button1.Size = new Size(101, 81);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ExitButton_Click;
            // 
            // cell0_0
            // 
            cell0_0.BackColor = Color.Black;
            cell0_0.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cell0_0.Location = new Point(12, 12);
            cell0_0.Name = "cell0_0";
            cell0_0.Size = new Size(150, 150);
            cell0_0.TabIndex = 1;
            cell0_0.Click += cell0_0_Click;
            // 
            // cell0_1
            // 
            cell0_1.BackColor = Color.Gainsboro;
            cell0_1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cell0_1.Location = new Point(168, 12);
            cell0_1.Name = "cell0_1";
            cell0_1.Size = new Size(150, 150);
            cell0_1.TabIndex = 2;
            cell0_1.Click += cell0_1_Click;
            // 
            // cell0_2
            // 
            cell0_2.BackColor = Color.Gainsboro;
            cell0_2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cell0_2.Location = new Point(324, 12);
            cell0_2.Name = "cell0_2";
            cell0_2.Size = new Size(150, 150);
            cell0_2.TabIndex = 2;
            cell0_2.Click += cell0_2_Click;
            // 
            // cell1_0
            // 
            cell1_0.BackColor = Color.Gainsboro;
            cell1_0.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cell1_0.Location = new Point(12, 168);
            cell1_0.Name = "cell1_0";
            cell1_0.Size = new Size(150, 150);
            cell1_0.TabIndex = 2;
            cell1_0.Click += cell1_0_Click;
            // 
            // cell1_1
            // 
            cell1_1.BackColor = Color.Gainsboro;
            cell1_1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cell1_1.Location = new Point(168, 168);
            cell1_1.Name = "cell1_1";
            cell1_1.Size = new Size(150, 150);
            cell1_1.TabIndex = 2;
            cell1_1.Click += cell1_1_Click;
            // 
            // cell1_2
            // 
            cell1_2.BackColor = Color.Gainsboro;
            cell1_2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cell1_2.Location = new Point(324, 168);
            cell1_2.Name = "cell1_2";
            cell1_2.Size = new Size(150, 150);
            cell1_2.TabIndex = 2;
            cell1_2.Paint += cell1_2_Paint;
            // 
            // cell2_0
            // 
            cell2_0.BackColor = Color.Gainsboro;
            cell2_0.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cell2_0.Location = new Point(12, 324);
            cell2_0.Name = "cell2_0";
            cell2_0.Size = new Size(150, 150);
            cell2_0.TabIndex = 2;
            cell2_0.Click += cell2_0_Click;
            // 
            // cell2_1
            // 
            cell2_1.BackColor = Color.Gainsboro;
            cell2_1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cell2_1.Location = new Point(168, 324);
            cell2_1.Name = "cell2_1";
            cell2_1.Size = new Size(150, 150);
            cell2_1.TabIndex = 2;
            cell2_1.Click += cell2_1_Click;
            // 
            // cell2_2
            // 
            cell2_2.BackColor = Color.Gainsboro;
            cell2_2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cell2_2.Location = new Point(324, 324);
            cell2_2.Name = "cell2_2";
            cell2_2.Size = new Size(150, 150);
            cell2_2.TabIndex = 2;
            cell2_2.Click += cell2_2_Click;
            // 
            // labelPlayer1Score
            // 
            labelPlayer1Score.AutoSize = true;
            labelPlayer1Score.BackColor = Color.White;
            labelPlayer1Score.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayer1Score.Location = new Point(536, 328);
            labelPlayer1Score.Name = "labelPlayer1Score";
            labelPlayer1Score.Size = new Size(0, 32);
            labelPlayer1Score.TabIndex = 3;
            // 
            // labelPlayer2Score
            // 
            labelPlayer2Score.AutoSize = true;
            labelPlayer2Score.BackColor = Color.White;
            labelPlayer2Score.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayer2Score.Location = new Point(801, 328);
            labelPlayer2Score.Name = "labelPlayer2Score";
            labelPlayer2Score.Size = new Size(0, 32);
            labelPlayer2Score.TabIndex = 4;
            // 
            // NewGameButton
            // 
            NewGameButton.Location = new Point(536, 37);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(234, 70);
            NewGameButton.TabIndex = 5;
            NewGameButton.Text = "New Game";
            NewGameButton.UseVisualStyleBackColor = true;
            NewGameButton.Click += NewGameButton_Click;
            // 
            // ResetGameButton
            // 
            ResetGameButton.Location = new Point(536, 125);
            ResetGameButton.Name = "ResetGameButton";
            ResetGameButton.Size = new Size(234, 70);
            ResetGameButton.TabIndex = 6;
            ResetGameButton.Text = "Reset Game";
            ResetGameButton.UseVisualStyleBackColor = true;
            ResetGameButton.Click += ResetGameButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(945, 521);
            ControlBox = false;
            Controls.Add(ResetGameButton);
            Controls.Add(NewGameButton);
            Controls.Add(labelPlayer2Score);
            Controls.Add(labelPlayer1Score);
            Controls.Add(cell2_2);
            Controls.Add(cell2_1);
            Controls.Add(cell2_0);
            Controls.Add(cell1_2);
            Controls.Add(cell1_1);
            Controls.Add(cell1_0);
            Controls.Add(cell0_2);
            Controls.Add(cell0_1);
            Controls.Add(cell0_0);
            Controls.Add(button1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicTacToe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;

        private Panel cell0_0;
        private Panel cell0_1;
        private Panel cell0_2;
        private Panel cell1_0;
        private Panel cell1_1;
        private Panel cell1_2;
        private Panel cell2_0;
        private Panel cell2_1;
        private Panel cell2_2;
        private Label labelPlayer1Score;
        private Label labelPlayer2Score;
        private Button NewGameButton;
        private Button ResetGameButton;
    }
}