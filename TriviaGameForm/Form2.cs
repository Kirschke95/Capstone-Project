using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TriviaGameForm
{


    public partial class GameForm : Form
    {
        string[] questions = new string[0];
        string[] answersArray = new string[4];
        string correctButton;
        int points = 0, count = 0;
        StreamReader triviaQuestions;
        string modeChoice = "";

        /// <summary>
        /// intializes the form and calls the first method, setting the difficulty
        /// </summary>
        /// <param name="modeChoice"></param>
        public GameForm(string modeChoice)
        {
            InitializeComponent();
            SetDifficulty(modeChoice);
        }
        
        /// <summary>
        /// sets the game difficulty based on the string userchoice, sent from the button click from the first form
        /// </summary>
        /// <param name="userChoice"></param>
        private void SetDifficulty(string userChoice)
        {
            modeChoice = userChoice;
            bool buttonsOn = true;
            SetButtonsVisible(buttonsOn);

            //switch sets the data path to pull questions based on the difficulty choice sent to this method
            string dataPath = "";
            switch (modeChoice)
            {
                case "easy":
                    dataPath = @"Data\TriviaQuestionsEasy.txt";
                    difficultyLabel.Text = "Easy Mode";
                    modeChoice = "easy";
                    break;
                case "medium":
                    dataPath = @"Data\TriviaQuestionsMedium.txt";
                    difficultyLabel.Text = "Medium Mode";
                    modeChoice = "medium";
                    break;
                case "hard":
                    dataPath = @"Data\TriviaQuestionsHard.txt";
                    difficultyLabel.Text = "Hard Mode";
                    modeChoice = "hard";
                    break;
                default:
                    break;
            }

            triviaQuestions = new StreamReader(dataPath);
            DisplayQuestions(triviaQuestions);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// quick method to turn specific button visibilities within the form on/off
        /// </summary>
        /// <param name="buttonsOn"></param>
        private void SetButtonsVisible(bool buttonsOn)
        {
            if (buttonsOn)
            {
                questionLabel.Visible = true;
                AChoice.Visible = true;
                answerA.Visible = true;
                BChoice.Visible = true;
                answerB.Visible = true;
                CChoice.Visible = true;
                answerC.Visible = true;
                DChoice.Visible = true;
                answerD.Visible = true;
            }
            else
            {
                questionLabel.Visible = false;
                AChoice.Visible = false;
                answerA.Visible = false;
                BChoice.Visible = false;
                answerB.Visible = false;
                CChoice.Visible = false;
                answerC.Visible = false;
                DChoice.Visible = false;
                answerD.Visible = false; ;
            }

        }

        /// <summary>
        /// this method takes the streamreader we created based on the datapath from the setdifficulty method, and runs through the text file
        /// printing out a question and it's array of answers randomly
        /// </summary>
        /// <param name="triviaQuestions"></param>
        private void DisplayQuestions(StreamReader triviaQuestions)
        {

            string line = triviaQuestions.ReadLine();

            if (line == null)
            {
                GameOver();

            }

            else
            {
                bool visible = true;
                SetButtonsVisible(visible);
                continueButton.Visible = false;

                questionLabel.Text = line;
                string answer = triviaQuestions.ReadLine();
                answersArray = answer.Split(',');
                string correctAnswer = answersArray[0];
                SetButtonAnswers(answersArray);

                correctButton = SetCorrectButton(answersArray, correctAnswer);
            }


        }

        /// <summary>
        /// after the user selects an option A-D we test that against the correct answer and send a boolean to a scorekeeping method
        /// to keep the users score out of questions answered
        /// </summary>
        /// <param name="userAnswer"></param>
        /// <param name="correctButton"></param>
        private void TestAnswer(char userAnswer, string correctButton)
        {
            bool correct = false;
            char[] correctButtonChar = correctButton.ToCharArray();
            char correctLetter = correctButtonChar[0];
            int points = 0;
            int count = 0;


            if (userAnswer == correctLetter)
            {
                correct = true;
                Score.Visible = true;
                Score.Text = "Correct!";
            }
            else
            {
                correct = false;
                Score.Visible = true;
                Score.Text = "Incorrect!";
            }


            continueButton.Visible = true;
            bool visible = false;
            KeepScore(correct);
            SetButtonsVisible(visible);
        }

        /// <summary>
        /// simply takes a boolean of correct or not and increases score if true
        /// </summary>
        /// <param name="correct"></param>
        private void KeepScore(bool correct)
        {

            if (correct)
            {
                points++;
            }

            count++;

        }

        /// <summary>
        /// randomly orders the array of answers from the text file and 
        /// sets them to a Letter button within the form
        /// </summary>
        /// <param name="answersArray"></param>
        private void SetButtonAnswers(string[] answersArray)
        {
            Random rnd = new Random();
            answersArray = answersArray.OrderBy(x => rnd.Next()).ToArray();

            answerA.Text = answersArray[0];
            answerB.Text = answersArray[1];
            answerC.Text = answersArray[2];
            answerD.Text = answersArray[3];
        }

        /// <summary>
        /// this method gets sent the array of random answers and the correct answer in order to 
        /// set the correct one to its corresponding letter value
        /// </summary>
        /// <param name="answersArray"></param>
        /// <param name="correctAnswer"></param>
        /// <returns></returns>
        private string SetCorrectButton(string[] answersArray, string correctAnswer)
        {
            string correctButton = "";
            Random rnd = new Random();
            answersArray = answersArray.OrderBy(x => rnd.Next()).ToArray();

            if (answersArray[0] == correctAnswer)
            {
                correctButton = "A";
            }
            else if (answersArray[1] == correctAnswer)
            {
                correctButton = "B";
            }
            else if (answersArray[2] == correctAnswer)
            {
                correctButton = "C";
            }
            else if (answersArray[3] == correctAnswer)
            {
                correctButton = "D";
            }

            return correctButton;
        }

        /// <summary>
        /// this is the method that takes the button choice from the user, and sets that answer to a char variable A-D
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetUserAnswer(object sender, EventArgs e)
        {
            string userChoice = sender.ToString();
            char userAnswer = userChoice[userChoice.Length - 1];
            //what I have to do here is take the sender (which button they press) and just take the text of that button and set it to the user answer!
            TestAnswer(userAnswer, correctButton);
        }

        /// <summary>
        /// simple "next question" button to advance through the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void continueButton_Click(object sender, EventArgs e)
        {
            DisplayQuestions(triviaQuestions);
            Score.Visible = false;
        }

        /// <summary>
        /// simple gameOver function at the end of a game mode to display user's score
        /// </summary>
        private void GameOver()
        {
            bool visible = false;
            SetButtonsVisible(visible);

            difficultyLabel.Text = "Game Over!";
            questionLabel.Visible = true;
            questionLabel.Text = $"You got {points} questions correct out of {count}";
            TryAgain.Visible = true;
            ExitGame.Visible = true;
            continueButton.Visible = false;


        }

        /// <summary>
        /// method to close entire program if user closes second form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// method for the try again button to start the program from the initial form and
        /// select a new difficulty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TryAgain_Click(object sender, EventArgs e)
        {
            //these lines reset the streamreader to the first line of the text file to pull the questions again
            triviaQuestions.DiscardBufferedData();
            triviaQuestions.BaseStream.Seek(0, SeekOrigin.Begin);
                        
            TryAgain.Visible = false;
            ExitGame.Visible = false;

            Trivia Menu = new Trivia();
            this.Hide();
            Menu.Show();
        }

        private void difficultyLabel_Click(object sender, EventArgs e)
        {

        }

        private void answerB_Click(object sender, EventArgs e)
        {

        }

        private void answerA_Click(object sender, EventArgs e)
        {

        }

        private void answerC_Click(object sender, EventArgs e)
        {

        }

        private void answerD_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// method for the quit game button that ends the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
