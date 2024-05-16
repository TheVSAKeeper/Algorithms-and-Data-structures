using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lab_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnStartButtonClicked(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            decimal X = _variableX.Value;
            decimal Y = _variableY.Value;
            decimal Z = _variableZ.Value;

            if (X != Y && Y != Z && X != Z)
            {
                if (X + Y + Z < 1)
                {
                    X = (Y + Z) / 2;
                }
                else
                {
                    if (X < Y)
                        X = Y - Z;
                    else
                        Y = X - Z;
                }
            }

            _variableX.Value = X;
            _variableY.Value = Y;

            stopwatch.Stop();

            _stopwatchLabel.Text = $"Elapsed Ticks:\n{stopwatch.ElapsedTicks}";
        }
    }
}