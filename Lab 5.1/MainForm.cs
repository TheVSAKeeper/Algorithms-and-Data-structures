using System;
using System.Globalization;
using System.Windows.Forms;

namespace Lab_5._1
{
    public partial class MainForm : Form
    {
        private double _result;
        private MathOperation _selectedOperation;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnTextBoxKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ',')
                return;

            e.Handled = true;
        }

        private void OnOperationClicked(object sender, EventArgs e)
        {
            char operationText = ((Button)sender).Text[0];
            _selectedOperation = (MathOperation)operationText;

            PerformNewNumber();
        }

        private void OnEqualsClicked(object sender, EventArgs e)
        {
            PerformOperation(_selectedOperation);

            buffer.Text = _result.ToString(CultureInfo.CurrentCulture);

            inputField.ResetText();
        }

        private void OnBackspaceClicked(object sender, EventArgs e)
        {
            inputField.Text = inputField.Text.Remove(inputField.Text.Length - 1);
        }

        private void PerformNewNumber()
        {
            double.TryParse(inputField.Text, out _result);

            buffer.Text = _result.ToString(CultureInfo.CurrentCulture);

            inputField.ResetText();
        }

        private void PerformOperation(MathOperation operation)
        {
            double.TryParse(inputField.Text, out double number);

            switch (operation)
            {
                case MathOperation.Addition:
                    _result += number;
                    break;

                case MathOperation.Subtraction:
                    _result -= number;
                    break;

                case MathOperation.Multiplication:
                    _result *= number;
                    break;

                case MathOperation.Division:
                    _result /= number;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
            }
        }
    }

    internal enum MathOperation
    {
        Addition = '+',
        Subtraction = '-',
        Multiplication = '*',
        Division = '/'
    }
}