using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjectEulerReader
{
    public partial class QuestionForm : Form
    {
        // Regex
        private const string titleString = "<h2>(.*)<\\/h2>";
        private const string infoString = "Solved by (\\d+).*Difficulty rating: (.*)%";

        public QuestionForm()
        {
            InitializeComponent();
            // Goto first question
            updateInformation(ProjectEuler.getCurrentQuestion());
        }

        private void QuestionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close this application
            Application.ExitThread();
        }

        private void broswerBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://projecteuler.net/problem=" + ProjectEuler.curQuestion);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            hideAllControl();
            ProjectEuler.curQuestion--;
            string text = ProjectEuler.getCurrentQuestion();
            if (text == "")
            {
                MessageBox.Show("There is no previous question.");
            }
            else
            {
                hideAllControl();
                updateInformation(text);
            }
            showAllControl();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            hideAllControl();
            ProjectEuler.curQuestion++;
            string text = ProjectEuler.getCurrentQuestion();
            if (text == "")
            {
                MessageBox.Show("There is no next question.");
            }
            else
            {
                hideAllControl();
                updateInformation(text);
            }
            showAllControl();
        }

        private void jumpBtn_Click(object sender, EventArgs e)
        {
            hideAllControl();
            InputBox box = new InputBox();
            box.ShowDialog();

            string text = ProjectEuler.getCurrentQuestion();
            if (text == "")
            {
                MessageBox.Show("There is no such question.");
            }
            else
            {
               
                updateInformation(text);
            }
            showAllControl();
        }

        private void updateInformation(string text)
        {
            questionLabel.Text = text;
            numberLabel.Text = @"Problem " + ProjectEuler.curQuestion;

            // Get other information
            Regex infoRegex = new Regex(infoString);
            var infoMatch = infoRegex.Match(ProjectEuler.information);
            infoLabel.Text = "Solved by " + infoMatch.Groups[1].ToString() + " Rating: " + infoMatch.Groups[2].ToString() + "%";

            Regex titleRegex = new Regex(titleString);
            var titleMatch = titleRegex.Match(ProjectEuler.information);
            this.Text = titleMatch.Groups[1].Value;
        }

        private void hideAllControl()
        {
            foreach (Control eachControl in Controls)
            {
                eachControl.Visible = false;
            }
            this.Text = "Loading...";
        }

        private void showAllControl()
        {
            foreach (Control eachControl in Controls)
            {
                eachControl.Visible = true;
            }
        }
    }
}
