namespace TriviaGameForm
{
    partial class Trivia
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wrongButton = new System.Windows.Forms.Button();
            this.beginButton = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(129, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(347, 29);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to my Trivia Game!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "We\'re going to test your knowledge with some basic questions.";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // wrongButton
            // 
            this.wrongButton.Location = new System.Drawing.Point(239, 154);
            this.wrongButton.Name = "wrongButton";
            this.wrongButton.Size = new System.Drawing.Size(120, 30);
            this.wrongButton.TabIndex = 2;
            this.wrongButton.Text = "Begin";
            this.wrongButton.UseVisualStyleBackColor = true;
            this.wrongButton.Click += new System.EventHandler(this.wrongClick);
            // 
            // beginButton
            // 
            this.beginButton.AutoSize = true;
            this.beginButton.Location = new System.Drawing.Point(254, 187);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(95, 13);
            this.beginButton.TabIndex = 3;
            this.beginButton.Text = "Click here to begin";
            this.beginButton.Click += new System.EventHandler(this.nextScreen);
            // 
            // easyButton
            // 
            this.easyButton.Location = new System.Drawing.Point(113, 134);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(120, 50);
            this.easyButton.TabIndex = 4;
            this.easyButton.Text = "EASY";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Visible = false;
            this.easyButton.Click += new System.EventHandler(this.setMode);
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(239, 134);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(120, 50);
            this.mediumButton.TabIndex = 5;
            this.mediumButton.Text = "MEDIUM";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Visible = false;
            this.mediumButton.Click += new System.EventHandler(this.setMode);
            // 
            // hardButton
            // 
            this.hardButton.Location = new System.Drawing.Point(365, 134);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(120, 50);
            this.hardButton.TabIndex = 6;
            this.hardButton.Text = "HARD";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Visible = false;
            this.hardButton.Click += new System.EventHandler(this.setMode);
            // 
            // Trivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 221);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.wrongButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Trivia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trivia Game";
            this.Load += new System.EventHandler(this.Trivia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wrongButton;
        private System.Windows.Forms.Label beginButton;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
    }
}

