using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstherQuizgame2
{
    public partial class Form1 : Form
    {

        // quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 4;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.codelog;

                    lblQuestion.Text = "Which one of this is a software development folder?";

                    button1.Text = "Bluetooth";
                    button2.Text = "computer";
                    button3.Text = "Source Codes";
                    button4.Text = "Desktop";

                    correctAnswer = 3;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.google;

                    lblQuestion.Text = "Which one of this is an application?";

                    button1.Text = "Google";
                    button2.Text = "Mouse";
                    button3.Text = "Keyboard";
                    button4.Text = "Buttens";

                    correctAnswer = 1;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.compu;

                    lblQuestion.Text = "Which one of this is a part of a computer?";

                    button1.Text = "Wifi";
                    button2.Text = "Data";
                    button3.Text = "application";
                    button4.Text = "Mouse";

                    correctAnswer = 4;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Boot;

                    lblQuestion.Text = "What is a Network  Bandwith?";

                    button1.Text = "The rate of data transmission over a network";
                    button2.Text = "A network connection";
                    button3.Text = "Local network";
                    button4.Text = "A network used in big companies";

                    correctAnswer = 1;

                    break;





            }



        }

    }
}

