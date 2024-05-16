using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnStartButtonClicked(object sender, EventArgs e)
        {
            const int MaxScore = 7;
            int score = 0;

            score += CheckAnswer(radioButton1, true);

            score += CheckAnswer(checkBox1, true) + CheckAnswer(checkBox3, true) + CheckAnswer(checkBox2, false);

            score += CheckAnswer(radioButton3, true);

            score += CheckAnswer(checkBox4, true) + CheckAnswer(checkBox5, true);

            _scoreLabel.Text = $"{score} из {MaxScore} - {score * 100 / MaxScore}% ({GetGrade(score, MaxScore)})";
        }

        private static int CheckAnswer(RadioButton radioButton, bool correctState)
        {
            if (radioButton.Checked == correctState)
            {
                radioButton.ForeColor = Color.Green;
                return 1;
            }

            radioButton.ForeColor = Color.Red;
            return 0;
        }

        private static int CheckAnswer(CheckBox checkBox, bool correctState)
        {
            if (checkBox.Checked == correctState)
            {
                checkBox.ForeColor = Color.Green;
                return 1;
            }

            checkBox.ForeColor = Color.Red;
            return 0;
        }

        private static string GetGrade(int score, int total)
        {
            double percentage = score * 100.0 / total;

            if (percentage >= 90)
                return "Отлично";

            if (percentage >= 75)
                return "Хорошо";

            if (percentage >= 50)
                return "Удовлетворительно";

            return "Неудовлетворительно";
        }
    }
}