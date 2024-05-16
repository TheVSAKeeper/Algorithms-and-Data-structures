using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab_5._8
{
    public partial class MainForm : Form
    {
        private const string DataFilePath = "data.txt";

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnStartClicked(object sender, EventArgs e)
        {
            WriteText();
            ReadAndModify();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            string textToAdd = _textBoxInput.Text;

            if (string.IsNullOrWhiteSpace(textToAdd))
                return;

            _listBox.Items.Add(textToAdd);
            _textBoxInput.Clear();
        }

        private void WriteText()
        {
            List<string> items = new List<string>();

            foreach (object item in _listBox.Items)
                items.Add(item.ToString());

            items.Insert(1, "Привет!");
            File.WriteAllLines(DataFilePath, items);
        }

        private void ReadAndModify()
        {
            if (File.Exists(DataFilePath) == false)
                return;

            List<string> lines = new List<string>(File.ReadAllLines(DataFilePath));

            lines.Sort();

            int index = lines.BinarySearch("Привет!");

            if (index >= 0)
            {
                lines[index] = $"{lines[index].TrimEnd('!')}, Коля!";
                MessageBox.Show(@"Ура, добавили!");
            }

            _listView.Items.Clear();
            _listView.View = View.Details;

            Image[] images = GetImages();

            Random random = new Random();

            foreach (ListViewItem listViewItem in lines.Select(line => new ListViewItem(line)))
            {
                listViewItem.ImageIndex = random.Next(0, images.Length);

                _listView.Items.Add(listViewItem);
            }

            _listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private Image[] GetImages()
        {
            Image[] images = Directory.GetFiles("Images").Select(Image.FromFile).ToArray();

            _listView.SmallImageList = new ImageList();
            _listView.SmallImageList.Images.AddRange(images);
            return images;
        }
    }
}