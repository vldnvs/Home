namespace logCalculator
{
    partial class HypeLog
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
            outputBox = new TextBox();
            label1 = new Label();
            firstBase = new TextBox();
            firstArgument = new TextBox();
            plusButton = new Button();
            minusButton = new Button();
            equalButton = new Button();
            deleteButton = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // outputBox
            // 
            outputBox.Location = new Point(27, 43);
            outputBox.Multiline = true;
            outputBox.Name = "outputBox";
            outputBox.ReadOnly = true;
            outputBox.Size = new Size(423, 51);
            outputBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 144);
            label1.Name = "label1";
            label1.Size = new Size(56, 37);
            label1.TabIndex = 1;
            label1.Text = "log";
            // 
            // firstBase
            // 
            firstBase.Location = new Point(72, 184);
            firstBase.Multiline = true;
            firstBase.Name = "firstBase";
            firstBase.Size = new Size(25, 23);
            firstBase.TabIndex = 3;
            // 
            // firstArgument
            // 
            firstArgument.Location = new Point(99, 159);
            firstArgument.Name = "firstArgument";
            firstArgument.Size = new Size(44, 23);
            firstArgument.TabIndex = 4;
            // 
            // plusButton
            // 
            plusButton.Location = new Point(299, 133);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(49, 39);
            plusButton.TabIndex = 7;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += plusButton_Click;
            // 
            // minusButton
            // 
            minusButton.Location = new Point(354, 133);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(49, 39);
            minusButton.TabIndex = 8;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += minusButton_Click;
            // 
            // equalButton
            // 
            equalButton.Location = new Point(327, 180);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(49, 39);
            equalButton.TabIndex = 9;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = true;
            equalButton.Click += equalButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(27, 100);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(41, 28);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "CE";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.BackColor = Color.Transparent;
            errorLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.DarkRed;
            errorLabel.Location = new Point(68, 9);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 28);
            errorLabel.TabIndex = 11;
            // 
            // HypeLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 250);
            Controls.Add(errorLabel);
            Controls.Add(deleteButton);
            Controls.Add(equalButton);
            Controls.Add(minusButton);
            Controls.Add(plusButton);
            Controls.Add(firstArgument);
            Controls.Add(firstBase);
            Controls.Add(label1);
            Controls.Add(outputBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HypeLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HypeLog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox outputBox;
        private Label label1;
        private TextBox firstBase;
        private TextBox firstArgument;
        private Button plusButton;
        private Button minusButton;
        private Button equalButton;
        private Button deleteButton;
        private Label errorLabel;
    }
}