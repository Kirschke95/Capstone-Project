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
        /// <summary>
        /// initializes first form
        /// </summary>
        public Trivia()
        {
            InitializeComponent();
        }             

        /// <summary>
        /// TRICK button! LOL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wrongClick(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Wrong click fool, try again.";
            label1.Text = "You're already not looking too hot. Click HERE to proceed.";
            welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
        }

        /// <summary>
        /// advances through program with begin click, to select user difficulty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// takes a button press and converts it to a string and use a switch statement in order to set modeChoice and
        /// send it to the second form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            GameForm Game;
            Game = new GameForm(modeChoice);
            Game.Show();
            this.Hide();

        }

        private void Trivia_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

