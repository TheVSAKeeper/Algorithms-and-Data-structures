namespace Lab_5._8
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._listBox = new System.Windows.Forms.ListBox();
            this._listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this._textBoxInput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _listBox
            // 
            this._listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._listBox.FormattingEnabled = true;
            this._listBox.ItemHeight = 20;
            this._listBox.Location = new System.Drawing.Point(12, 11);
            this._listBox.Name = "_listBox";
            this._listBox.Size = new System.Drawing.Size(193, 224);
            this._listBox.TabIndex = 0;
            // 
            // _listView
            // 
            this._listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.columnHeader1 });
            this._listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._listView.HideSelection = false;
            this._listView.Location = new System.Drawing.Point(212, 11);
            this._listView.Name = "_listView";
            this._listView.Size = new System.Drawing.Size(193, 224);
            this._listView.TabIndex = 1;
            this._listView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Строки";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(212, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Заполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnStartClicked);
            // 
            // _textBoxInput
            // 
            this._textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxInput.Location = new System.Drawing.Point(12, 249);
            this._textBoxInput.Name = "_textBoxInput";
            this._textBoxInput.Size = new System.Drawing.Size(194, 26);
            this._textBoxInput.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnAddButtonClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 327);
            this.Controls.Add(this.button2);
            this.Controls.Add(this._textBoxInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._listView);
            this.Controls.Add(this._listBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ColumnHeader columnHeader1;

        private System.Windows.Forms.TextBox _textBoxInput;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ListBox _listBox;
        private System.Windows.Forms.ListView _listView;

        #endregion
    }
}