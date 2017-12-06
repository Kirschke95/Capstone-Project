namespace TriviaGameForm
{
    partial class Form2
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
            this.easyLabel = new System.Windows.Forms.Label();
            this.easyQuestion = new System.Windows.Forms.Label();
            this.beginButton = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // easyLabel
            // 
            this.easyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.easyLabel.AutoSize = true;
            this.easyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyLabel.Location = new System.Drawing.Point(110, 9);
            this.easyLabel.Name = "easyLabel";
            this.easyLabel.Size = new System.Drawing.Size(158, 31);
            this.easyLabel.TabIndex = 0;
            this.easyLabel.Text = "Easy Mode";
            // 
            // easyQuestion
            // 
            this.easyQuestion.AutoSize = true;
            this.easyQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyQuestion.Location = new System.Drawing.Point(13, 139);
            this.easyQuestion.Name = "easyQuestion";
            this.easyQuestion.Size = new System.Drawing.Size(118, 20);
            this.easyQuestion.TabIndex = 1;
            this.easyQuestion.Text = "easyQuestion";
            this.easyQuestion.Visible = false;
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(136, 65);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(102, 47);
            this.beginButton.TabIndex = 2;
            this.beginButton.Text = "Let\'s Go";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AChoice
            // 
            this.AChoice.BackColor = System.Drawing.Color.Transparent;
            this.AChoice.Font = new System.Drawing.Font("Arial", 8.25F);
            this.AChoice.Location = new System.Drawing.Point(17, 200);
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
            this.BChoice.Location = new System.Drawing.Point(17, 236);
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
            this.DChoice.Location = new System.Drawing.Point(17, 308);
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
            this.CChoice.Location = new System.Drawing.Point(17, 272);
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
            this.answerA.Location = new System.Drawing.Point(53, 208);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(35, 13);
            this.answerA.TabIndex = 7;
            this.answerA.Text = "label1";
            this.answerA.Visible = false;
            // 
            // answerB
            // 
            this.answerB.AutoSize = true;
            this.answerB.Location = new System.Drawing.Point(53, 244);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(35, 13);
            this.answerB.TabIndex = 8;
            this.answerB.Text = "label1";
            this.answerB.Visible = false;
            // 
            // answerC
            // 
            this.answerC.AutoSize = true;
            this.answerC.Location = new System.Drawing.Point(53, 280);
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(35, 13);
            this.answerC.TabIndex = 9;
            this.answerC.Text = "label1";
            this.answerC.Visible = false;
            // 
            // answerD
            // 
            this.answerD.AutoSize = true;
            this.answerD.Location = new System.Drawing.Point(53, 316);
            this.answerD.Name = "answerD";
            this.answerD.Size = new System.Drawing.Size(35, 13);
            this.answerD.TabIndex = 10;
            this.answerD.Text = "label1";
            this.answerD.Visible = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(74, 188);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(57, 20);
            this.Score.TabIndex = 11;
            this.Score.Text = "label1";
            this.Score.Visible = false;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(136, 272);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(102, 47);
            this.continueButton.TabIndex = 12;
            this.continueButton.Text = "Next Question";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Visible = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 363);
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
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.easyQuestion);
            this.Controls.Add(this.easyLabel);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Mode";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label easyLabel;
        private System.Windows.Forms.Label easyQuestion;
        private System.Windows.Forms.Button beginButton;
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
    }
}