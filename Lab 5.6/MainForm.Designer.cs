namespace Lab_5._6
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
            this._inputField = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _listBox
            // 
            this._listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._listBox.FormattingEnabled = true;
            this._listBox.ItemHeight = 24;
            this._listBox.Location = new System.Drawing.Point(12, 12);
            this._listBox.Name = "_listBox";
            this._listBox.Size = new System.Drawing.Size(388, 196);
            this._listBox.TabIndex = 0;
            // 
            // _inputField
            // 
            this._inputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._inputField.Location = new System.Drawing.Point(12, 247);
            this._inputField.Name = "_inputField";
            this._inputField.Size = new System.Drawing.Size(388, 191);
            this._inputField.TabIndex = 1;
            this._inputField.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(388, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnAddClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._inputField);
            this.Controls.Add(this._listBox);
            this.Name = "MainForm";
            this.Text = "Lab 5.6";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.RichTextBox _inputField;

        private System.Windows.Forms.ListBox _listBox;

        #endregion
    }
}