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
    public partial class Form2 : Form
    {
        string[] questions = new string[0];
        string[] answersArray = new string[4];
        string correctButton;
        //string modeChoice;
        //StreamReader triviaQuestions = new StreamReader(@"E:\Fall 2017\CIT 110\CapstoneProjectTRIVIA\TriviaQuestionsEasy.txt");
        StreamReader triviaQuestions;
        string modeChoice = "";
        public Form2(string modeChoice)
        {
            //bool modeSet = false;
            InitializeComponent();           
            SetDifficulty(modeChoice);           
        }

        private void SetDifficulty(string modeChoice)
        {
            string dataPath = "";
            switch (modeChoice)
            {
                case "easy":
                    dataPath = @"E:\Fall 2017\CIT 110\CapstoneProjectTRIVIA\TriviaQuestionsEasy.txt";
                    difficultyLabel.Text = "Easy Mode";
                    modeChoice = "easy";
                    break;
                case "medium":
                    dataPath = @"E:\Fall 2017\CIT 110\CapstoneProjectTRIVIA\TriviaQuestionsMedium.txt";
                    difficultyLabel.Text = "Medium Mode";
                    modeChoice = "medium";
                    break;
                case "hard":
                    dataPath = @"E:\Fall 2017\CIT 110\CapstoneProjectTRIVIA\TriviaQuestionsHard.txt";
                    difficultyLabel.Text = "Hard Mode";
                    modeChoice = "hard";
                    break;
                default:
                    break;
            }


            //StreamReader triviaQuestions = new StreamReader(dataPath);
            triviaQuestions = new StreamReader(dataPath);
               DisplayQuestions(triviaQuestions);
           
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            beginButton.Visible = false;
            SetDifficulty(modeChoice);
            //DisplayQuestions(triviaQuestions);

        }

        private void SetButtonsVisible(bool buttonsOn)
        {
            if (buttonsOn)
            {
                easyQuestion.Visible = true;
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
                easyQuestion.Visible = false;
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

        private void DisplayQuestions(StreamReader triviaQuestions)
        {
            string line = triviaQuestions.ReadLine();
           
            bool visible = true;
            SetButtonsVisible(visible);
            continueButton.Visible = false;

            easyQuestion.Text = line;
            string answer = triviaQuestions.ReadLine();
            answersArray = answer.Split(',');
            string correctAnswer = answersArray[0];
            SetButtonAnswers(answersArray);

            correctButton = SetCorrectButton(answersArray, correctAnswer);

        }

        private void TestAnswer(char userAnswer, string correctButton)
        {
            bool correct = false;
            //Systems.Windows.Forms.Button, Text: A"
            char[] correctButtonChar = correctButton.ToCharArray();
            char correctLetter = correctButtonChar[0];
            int points, count;


            if (userAnswer == correctLetter)
            {
                correct = true;
                Score.Visible = true;
                //points = points + 1;
                //count++;
                Score.Text = "Correct!"; //Score: {points}/{count}"
            }
            else
            {
                correct = false;
                Score.Visible = true;
                //count++;
                Score.Text = "Incorrect!"; //Score: {points}/{count}"
            }

            continueButton.Visible = true;
            bool visible = false;
            SetButtonsVisible(visible);                                 
        }

        private void SetButtonAnswers(string[] answersArray)
        {
            Random rnd = new Random();
            answersArray = answersArray.OrderBy(x => rnd.Next()).ToArray();

            answerA.Text = answersArray[0];
            answerB.Text = answersArray[1];
            answerC.Text = answersArray[2];
            answerD.Text = answersArray[3];
        }

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

        private void GetUserAnswer(object sender, EventArgs e)
        {
            string userChoice = sender.ToString();
            char userAnswer = userChoice[userChoice.Length - 1];
            //what I have to do here is take the sender (which button they press) and just take the text of that button and set it to the user answer!
            TestAnswer(userAnswer, correctButton);
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            DisplayQuestions(triviaQuestions);           
            Score.Visible = false;
        }
    }
}
