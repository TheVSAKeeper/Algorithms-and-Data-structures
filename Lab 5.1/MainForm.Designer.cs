namespace Lab_5._1
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
            this.inputField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buffer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputField
            // 
            this.inputField.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputField.Location = new System.Drawing.Point(12, 12);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(210, 45);
            this.inputField.TabIndex = 0;
            this.inputField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnTextBoxKeyPressed);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("GOST Type BU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnOperationClicked);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("GOST Type BU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(66, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnOperationClicked);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("GOST Type BU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(120, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnOperationClicked);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("GOST Type BU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(174, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OnOperationClicked);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(228, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 45);
            this.button5.TabIndex = 5;
            this.button5.Text = "<-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.OnBackspaceClicked);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("GOST Type BU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(228, 63);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 45);
            this.button6.TabIndex = 6;
            this.button6.Text = "=";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.OnEqualsClicked);
            // 
            // buffer
            // 
            this.buffer.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buffer.Location = new System.Drawing.Point(12, 120);
            this.buffer.Name = "buffer";
            this.buffer.Size = new System.Drawing.Size(289, 37);
            this.buffer.TabIndex = 7;
            this.buffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 166);
            this.Controls.Add(this.buffer);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputField);
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label buffer;

        private System.Windows.Forms.Button button6;

        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox inputField;

        #endregion
    }
}