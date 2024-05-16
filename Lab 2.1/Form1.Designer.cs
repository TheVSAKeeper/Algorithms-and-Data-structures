namespace Lab_2._1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this._variableY = new System.Windows.Forms.NumericUpDown();
            this._variableX = new System.Windows.Forms.NumericUpDown();
            this._variableZ = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._stopwatchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._variableY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._variableX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._variableZ)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(11, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnStartButtonClicked);
            // 
            // _variableY
            // 
            this._variableY.DecimalPlaces = 2;
            this._variableY.Location = new System.Drawing.Point(51, 56);
            this._variableY.Margin = new System.Windows.Forms.Padding(2);
            this._variableY.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
            this._variableY.Name = "_variableY";
            this._variableY.Size = new System.Drawing.Size(89, 20);
            this._variableY.TabIndex = 1;
            // 
            // _variableX
            // 
            this._variableX.DecimalPlaces = 2;
            this._variableX.Location = new System.Drawing.Point(51, 24);
            this._variableX.Margin = new System.Windows.Forms.Padding(2);
            this._variableX.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
            this._variableX.Name = "_variableX";
            this._variableX.Size = new System.Drawing.Size(89, 20);
            this._variableX.TabIndex = 2;
            // 
            // _variableZ
            // 
            this._variableZ.DecimalPlaces = 2;
            this._variableZ.Location = new System.Drawing.Point(51, 89);
            this._variableZ.Margin = new System.Windows.Forms.Padding(2);
            this._variableZ.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
            this._variableZ.Name = "_variableZ";
            this._variableZ.Size = new System.Drawing.Size(89, 20);
            this._variableZ.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Z";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _stopwatchLabel
            // 
            this._stopwatchLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._stopwatchLabel.Location = new System.Drawing.Point(12, 207);
            this._stopwatchLabel.Name = "_stopwatchLabel";
            this._stopwatchLabel.Size = new System.Drawing.Size(159, 41);
            this._stopwatchLabel.TabIndex = 7;
            this._stopwatchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 253);
            this.Controls.Add(this._stopwatchLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._variableZ);
            this.Controls.Add(this._variableX);
            this.Controls.Add(this._variableY);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Lab 2.1";
            ((System.ComponentModel.ISupportInitialize)(this._variableY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._variableX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._variableZ)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label _stopwatchLabel;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.NumericUpDown _variableY;
        private System.Windows.Forms.NumericUpDown _variableX;
        private System.Windows.Forms.NumericUpDown _variableZ;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}