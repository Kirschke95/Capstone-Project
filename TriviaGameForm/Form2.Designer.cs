namespace TriviaGameForm
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.AChoice = new System.Windows.Forms.Button();
            this.BChoice = new System.Windows.Forms.Button();
            this.DChoice = new System.Windows.Forms.Button();
            this.CChoice = new System.Windows.Forms.Button();
            this.answerA = new System.Windows.Forms.Label();
            this.answerB = new System.Windows.Forms.Label();
            this.answerC = new System.Windows.Forms.Label();
            this.answerD = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.TryAgain = new System.Windows.Forms.Button();
            this.ExitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.Location = new System.Drawing.Point(210, 9);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(124, 31);
            this.difficultyLabel.TabIndex = 0;
            this.difficultyLabel.Text = "difficulty";
            this.difficultyLabel.Click += new System.EventHandler(this.difficultyLabel_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.questionLabel.Location = new System.Drawing.Point(14, 60);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(97, 16);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "questinLabel";
            this.questionLabel.Visible = false;
            // 
            // AChoice
            // 
            this.AChoice.BackColor = System.Drawing.Color.Transparent;
            this.AChoice.Font = new System.Drawing.Font("Arial", 8.25F);
            this.AChoice.Location = new System.Drawing.Point(17, 104);
            this.AChoice.Name = "AChoice";
            this.AChoice.Size = new System.Drawing.Size(30, 30);
            this.AChoice.TabIndex = 3;
            this.AChoice.Text = "A";
            this.AChoice.UseVisualStyleBackColor = false;
            this.AChoice.Visible = false;
            this.AChoice.Click += new System.EventHandler(this.GetUserAnswer);
            // 
            // BChoice
            // 
            this.BChoice.BackColor = System.Drawing.Color.Transparent;
            this.BChoice.Font = new System.Drawing.Font("Arial", 8.25F);
            this.BChoice.Location = new System.Drawing.Point(17, 140);
            this.BChoice.Name = "BChoice";
            this.BChoice.Size = new System.Drawing.Size(30, 30);
            this.BChoice.TabIndex = 4;
            this.BChoice.Text = "B";
            this.BChoice.UseVisualStyleBackColor = false;
            this.BChoice.Visible = false;
            this.BChoice.Click += new System.EventHandler(this.GetUserAnswer);
            // 
            // DChoice
            // 
            this.DChoice.BackColor = System.Drawing.Color.Transparent;
            this.DChoice.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DChoice.Location = new System.Drawing.Point(308, 144);
            this.DChoice.Name = "DChoice";
            this.DChoice.Size = new System.Drawing.Size(30, 30);
            this.DChoice.TabIndex = 5;
            this.DChoice.Text = "D";
            this.DChoice.UseVisualStyleBackColor = false;
            this.DChoice.Visible = false;
            this.DChoice.Click += new System.EventHandler(this.GetUserAnswer);
            // 
            // CChoice
            // 
            this.CChoice.BackColor = System.Drawing.Color.Transparent;
            this.CChoice.Font = new System.Drawing.Font("Arial", 8.25F);
            this.CChoice.Location = new System.Drawing.Point(308, 108);
            this.CChoice.Name = "CChoice";
            this.CChoice.Size = new System.Drawing.Size(30, 30);
            this.CChoice.TabIndex = 6;
            this.CChoice.Text = "C";
            this.CChoice.UseVisualStyleBackColor = false;
            this.CChoice.Visible = false;
            this.CChoice.Click += new System.EventHandler(this.GetUserAnswer);
            // 
            // answerA
            // 
            this.answerA.AutoSize = true;
            this.answerA.Location = new System.Drawing.Point(53, 112);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(35, 13);
            this.answerA.TabIndex = 7;
            this.answerA.Text = "label1";
            this.answerA.Visible = false;
            this.answerA.Click += new System.EventHandler(this.answerA_Click);
            // 
            // answerB
            // 
            this.answerB.AutoSize = true;
            this.answerB.Location = new System.Drawing.Point(53, 148);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(35, 13);
            this.answerB.TabIndex = 8;
            this.answerB.Text = "label1";
            this.answerB.Visible = false;
            this.answerB.Click += new System.EventHandler(this.answerB_Click);
            // 
            // answerC
            // 
            this.answerC.AutoSize = true;
            this.answerC.Location = new System.Drawing.Point(344, 116);
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(35, 13);
            this.answerC.TabIndex = 9;
            this.answerC.Text = "label1";
            this.answerC.Visible = false;
            this.answerC.Click += new System.EventHandler(this.answerC_Click);
            // 
            // answerD
            // 
            this.answerD.AutoSize = true;
            this.answerD.Location = new System.Drawing.Point(344, 152);
            this.answerD.Name = "answerD";
            this.answerD.Size = new System.Drawing.Size(35, 13);
            this.answerD.TabIndex = 10;
            this.answerD.Text = "label1";
            this.answerD.Visible = false;
            this.answerD.Click += new System.EventHandler(this.answerD_Click);
            // 
            // Score
            // 
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(243, 82);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(136, 23);
            this.Score.TabIndex = 13;
            this.Score.Visible = false;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(256, 135);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(102, 47);
            this.continueButton.TabIndex = 12;
            this.continueButton.Text = "Next Question";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Visible = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // TryAgain
            // 
            this.TryAgain.ForeColor = System.Drawing.Color.Black;
            this.TryAgain.Location = new System.Drawing.Point(227, 186);
            this.TryAgain.Name = "TryAgain";
            this.TryAgain.Size = new System.Drawing.Size(75, 23);
            this.TryAgain.TabIndex = 14;
            this.TryAgain.Text = "Try Again";
            this.TryAgain.UseVisualStyleBackColor = true;
            this.TryAgain.Visible = false;
            this.TryAgain.Click += new System.EventHandler(this.TryAgain_Click);
            // 
            // ExitGame
            // 
            this.ExitGame.Location = new System.Drawing.Point(308, 186);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(75, 23);
            this.ExitGame.TabIndex = 15;
            this.ExitGame.Text = "Exit Game";
            this.ExitGame.UseVisualStyleBackColor = true;
            this.ExitGame.Visible = false;
            this.ExitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 221);
            this.Controls.Add(this.ExitGame);
            this.Controls.Add(this.TryAgain);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.answerD);
            this.Controls.Add(this.answerC);
            this.Controls.Add(this.answerB);
            this.Controls.Add(this.answerA);
            this.Controls.Add(this.CChoice);
            this.Controls.Add(this.DChoice);
            this.Controls.Add(this.BChoice);
            this.Controls.Add(this.AChoice);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.difficultyLabel);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Mode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button AChoice;
        private System.Windows.Forms.Button BChoice;
        private System.Windows.Forms.Button DChoice;
        private System.Windows.Forms.Button CChoice;
        private System.Windows.Forms.Label answerA;
        private System.Windows.Forms.Label answerB;
        private System.Windows.Forms.Label answerC;
        private System.Windows.Forms.Label answerD;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button TryAgain;
        private System.Windows.Forms.Button ExitGame;
    }
}