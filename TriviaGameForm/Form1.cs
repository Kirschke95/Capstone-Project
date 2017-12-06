using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaGameForm
{

    public partial class Trivia : Form
    {
        string modeChoice = "";
        public Trivia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wrongClick(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Wrong click fool, try again.";
            label1.Text = "You're already not looking too hot. Click HERE to proceed.";
            welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
        }

        private void nextScreen(object sender, EventArgs e)
        {
            wrongButton.Visible = false;
            beginButton.Visible = false;
            label1.Visible = true;
            welcomeLabel.Text = "Nice job, let's go.";
            welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label1.Text = "Choose your difficulty.";
            easyButton.Visible = true;
            mediumButton.Visible = true;
            hardButton.Visible = true;
        }

        private void setMode(object sender, EventArgs e)
        {
            string difficultyChoice = sender.ToString();
            string modeChoice = "";
            
            
            switch (difficultyChoice)
            {
                case "System.Windows.Forms.Button, Text: EASY":
                    modeChoice = "easy";
                    break;
                case "System.Windows.Forms.Button, Text: MEDIUM":
                    modeChoice = "medium";
                    break;
                case "System.Windows.Forms.Button, Text: HARD":
                    modeChoice = "hard";
                    break;
                default:
                    break;
            }

            Form2 Game;
            Game = new Form2(modeChoice);
            Game.Show();
            

        }
    }
}

