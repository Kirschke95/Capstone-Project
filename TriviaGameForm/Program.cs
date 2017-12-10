using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaGameForm
{
    //**********************************************************************************
    //**********************************************************************************
    //Title: Trivia Game Form
    //Application Type: Windows Form
    //Description: A simple trivia game that lets the user select a difficulty level and
    //play a multiple choice game
    //Author: Tyler Kirschke
    //Date Created: 11/29/2017
    //Last Modified: 12/10/2017
    //**********************************************************************************
    //**********************************************************************************

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Trivia());
        }
    }
}
