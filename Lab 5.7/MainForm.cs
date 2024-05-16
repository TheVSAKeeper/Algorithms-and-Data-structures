using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lab_5._7
{
    public partial class MainForm : Form
    {
        private const string FilePath = "Test.txt";
        private readonly string _secondFileName;

        public MainForm()
        {
            InitializeComponent();

            _secondFileName = FilePath.Insert(FilePath.LastIndexOf('.'), "Temp");
        }

        private void OnPerformClicked(object sender, EventArgs e)
        {
            if (TryReadFile(FilePath, out string[] readAllLines) == false)
                return;

            List<string> lines = ModifyFile(readAllLines);

            File.WriteAllLines(_secondFileName, lines);

            _listBox.Items.AddRange(File.ReadAllLines(_secondFileName));
        }

        private static bool TryReadFile(string filePath, out string[] readAllLines)
        {
            readAllLines = null;

            if (File.Exists(filePath) == false)
                return false;

            readAllLines = File.ReadAllLines(filePath);
            return true;
        }

        private static List<string> ModifyFile(string[] readAllLines)
        {
            List<string> lines = new List<string>();

            int number = 0;

            foreach (string line in readAllLines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                lines.Add($"[{++number}] ({line.Trim()})");
            }

            return lines;
        }
    }
}