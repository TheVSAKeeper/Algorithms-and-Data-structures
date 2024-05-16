using System;
using System.Windows.Forms;

namespace Lab_5._6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            string fieldText = _inputField.Text;
            _inputField.ResetText();

            string[] lines = fieldText.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            _listBox.Items.AddRange(lines);
        }
    }
}