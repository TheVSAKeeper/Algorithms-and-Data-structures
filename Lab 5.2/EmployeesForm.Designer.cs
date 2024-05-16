namespace Lab_5._2
{
    partial class EmployeesForm
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
            this._toolBar = new System.Windows.Forms.MenuStrip();
            this._actionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._addDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._searchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._dataInput = new System.Windows.Forms.GroupBox();
            this._dataInputPanel = new System.Windows.Forms.TableLayoutPanel();
            this._academicDegree = new System.Windows.Forms.CheckedListBox();
            this._post = new System.Windows.Forms.DomainUpDown();
            this._fullNameLabel = new System.Windows.Forms.Label();
            this._fullName = new System.Windows.Forms.TextBox();
            this._postLabel = new System.Windows.Forms.Label();
            this._birthDateLabel = new System.Windows.Forms.Label();
            this._birthDate = new System.Windows.Forms.DateTimePicker();
            this._academicDegreeLabel = new System.Windows.Forms.Label();
            this._workExperienceLabel = new System.Windows.Forms.Label();
            this._addData = new System.Windows.Forms.Button();
            this._workExperience = new System.Windows.Forms.NumericUpDown();
            this._request = new System.Windows.Forms.GroupBox();
            this._requestPanel = new System.Windows.Forms.TableLayoutPanel();
            this._requestContent = new System.Windows.Forms.TextBox();
            this._postRequest = new System.Windows.Forms.RadioButton();
            this._workExperienceRequest = new System.Windows.Forms.RadioButton();
            this._search = new System.Windows.Forms.Button();
            this._data = new System.Windows.Forms.GroupBox();
            this._dataGrid = new System.Windows.Forms.DataGridView();
            this._sample = new System.Windows.Forms.GroupBox();
            this._sampleGrid = new System.Windows.Forms.DataGridView();
            this._dataGridsPanel = new System.Windows.Forms.TableLayoutPanel();
            this._treeView = new System.Windows.Forms.TreeView();
            this._listView = new System.Windows.Forms.ListView();
            this._toolBar.SuspendLayout();
            this._dataInput.SuspendLayout();
            this._dataInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._workExperience)).BeginInit();
            this._request.SuspendLayout();
            this._requestPanel.SuspendLayout();
            this._data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGrid)).BeginInit();
            this._sample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._sampleGrid)).BeginInit();
            this._dataGridsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _toolBar
            // 
            this._toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this._actionsMenu, this._exitMenuItem });
            this._toolBar.Location = new System.Drawing.Point(0, 0);
            this._toolBar.Name = "_toolBar";
            this._toolBar.Size = new System.Drawing.Size(1234, 27);
            this._toolBar.TabIndex = 0;
            this._toolBar.Text = "_toolBar";
            // 
            // _actionsMenu
            // 
            this._actionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this._addDataMenuItem, this._searchMenuItem });
            this._actionsMenu.Name = "_actionsMenu";
            this._actionsMenu.Size = new System.Drawing.Size(80, 23);
            this._actionsMenu.Text = "Действия";
            // 
            // _addDataMenuItem
            // 
            this._addDataMenuItem.Name = "_addDataMenuItem";
            this._addDataMenuItem.Size = new System.Drawing.Size(191, 24);
            this._addDataMenuItem.Text = "Добавить данные";
            this._addDataMenuItem.Click += new System.EventHandler(this.OnAddDataClicked);
            // 
            // _searchMenuItem
            // 
            this._searchMenuItem.Name = "_searchMenuItem";
            this._searchMenuItem.Size = new System.Drawing.Size(191, 24);
            this._searchMenuItem.Text = "Выполнить поиск";
            this._searchMenuItem.Click += new System.EventHandler(this.OnSearchClicked);
            // 
            // _exitMenuItem
            // 
            this._exitMenuItem.Name = "_exitMenuItem";
            this._exitMenuItem.Size = new System.Drawing.Size(61, 23);
            this._exitMenuItem.Text = "Выход";
            this._exitMenuItem.Click += new System.EventHandler(this.OnExitClicked);
            // 
            // _dataInput
            // 
            this._dataInput.Controls.Add(this._dataInputPanel);
            this._dataInput.Location = new System.Drawing.Point(12, 27);
            this._dataInput.Name = "_dataInput";
            this._dataInput.Size = new System.Drawing.Size(140, 411);
            this._dataInput.TabIndex = 1;
            this._dataInput.TabStop = false;
            this._dataInput.Text = "Ввод данных";
            // 
            // _dataInputPanel
            // 
            this._dataInputPanel.ColumnCount = 1;
            this._dataInputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._dataInputPanel.Controls.Add(this._academicDegree, 0, 7);
            this._dataInputPanel.Controls.Add(this._post, 0, 3);
            this._dataInputPanel.Controls.Add(this._fullNameLabel, 0, 0);
            this._dataInputPanel.Controls.Add(this._fullName, 0, 1);
            this._dataInputPanel.Controls.Add(this._postLabel, 0, 2);
            this._dataInputPanel.Controls.Add(this._birthDateLabel, 0, 4);
            this._dataInputPanel.Controls.Add(this._birthDate, 0, 5);
            this._dataInputPanel.Controls.Add(this._academicDegreeLabel, 0, 6);
            this._dataInputPanel.Controls.Add(this._workExperienceLabel, 0, 8);
            this._dataInputPanel.Controls.Add(this._addData, 0, 10);
            this._dataInputPanel.Controls.Add(this._workExperience, 0, 9);
            this._dataInputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataInputPanel.Location = new System.Drawing.Point(3, 16);
            this._dataInputPanel.Name = "_dataInputPanel";
            this._dataInputPanel.RowCount = 11;
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.Size = new System.Drawing.Size(134, 392);
            this._dataInputPanel.TabIndex = 0;
            // 
            // _academicDegree
            // 
            this._academicDegree.Dock = System.Windows.Forms.DockStyle.Fill;
            this._academicDegree.FormattingEnabled = true;
            this._academicDegree.Location = new System.Drawing.Point(3, 200);
            this._academicDegree.Name = "_academicDegree";
            this._academicDegree.Size = new System.Drawing.Size(128, 74);
            this._academicDegree.TabIndex = 9;
            // 
            // _post
            // 
            this._post.Dock = System.Windows.Forms.DockStyle.Fill;
            this._post.Location = new System.Drawing.Point(3, 84);
            this._post.Name = "_post";
            this._post.Size = new System.Drawing.Size(128, 20);
            this._post.TabIndex = 7;
            this._post.Text = "_post";
            // 
            // _fullNameLabel
            // 
            this._fullNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fullNameLabel.Location = new System.Drawing.Point(3, 3);
            this._fullNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this._fullNameLabel.Name = "_fullNameLabel";
            this._fullNameLabel.Size = new System.Drawing.Size(128, 24);
            this._fullNameLabel.TabIndex = 1;
            this._fullNameLabel.Text = "ФИО";
            this._fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _fullName
            // 
            this._fullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fullName.Location = new System.Drawing.Point(3, 33);
            this._fullName.Name = "_fullName";
            this._fullName.Size = new System.Drawing.Size(128, 20);
            this._fullName.TabIndex = 2;
            // 
            // _postLabel
            // 
            this._postLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._postLabel.Location = new System.Drawing.Point(3, 59);
            this._postLabel.Margin = new System.Windows.Forms.Padding(3);
            this._postLabel.Name = "_postLabel";
            this._postLabel.Size = new System.Drawing.Size(128, 19);
            this._postLabel.TabIndex = 3;
            this._postLabel.Text = "Должность";
            this._postLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _birthDateLabel
            // 
            this._birthDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._birthDateLabel.Location = new System.Drawing.Point(3, 124);
            this._birthDateLabel.Margin = new System.Windows.Forms.Padding(3);
            this._birthDateLabel.Name = "_birthDateLabel";
            this._birthDateLabel.Size = new System.Drawing.Size(128, 19);
            this._birthDateLabel.TabIndex = 5;
            this._birthDateLabel.Text = "Дата рождения";
            this._birthDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _birthDate
            // 
            this._birthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this._birthDate.Location = new System.Drawing.Point(3, 149);

            this._birthDate.MaxDate = new System.DateTime(2023,
                3,
                5,
                0,
                0,
                0,
                0);

            this._birthDate.Name = "_birthDate";
            this._birthDate.Size = new System.Drawing.Size(128, 20);
            this._birthDate.TabIndex = 11;

            this._birthDate.Value = new System.DateTime(2023,
                3,
                5,
                0,
                0,
                0,
                0);

            // 
            // _academicDegreeLabel
            // 
            this._academicDegreeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._academicDegreeLabel.Location = new System.Drawing.Point(3, 175);
            this._academicDegreeLabel.Margin = new System.Windows.Forms.Padding(3);
            this._academicDegreeLabel.Name = "_academicDegreeLabel";
            this._academicDegreeLabel.Size = new System.Drawing.Size(128, 19);
            this._academicDegreeLabel.TabIndex = 7;
            this._academicDegreeLabel.Text = "Ученая степень";
            this._academicDegreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _workExperienceLabel
            // 
            this._workExperienceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._workExperienceLabel.Location = new System.Drawing.Point(3, 280);
            this._workExperienceLabel.Margin = new System.Windows.Forms.Padding(3);
            this._workExperienceLabel.Name = "_workExperienceLabel";
            this._workExperienceLabel.Size = new System.Drawing.Size(128, 19);
            this._workExperienceLabel.TabIndex = 9;
            this._workExperienceLabel.Text = "Стаж";
            this._workExperienceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _addData
            // 
            this._addData.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addData.Location = new System.Drawing.Point(5, 333);
            this._addData.Margin = new System.Windows.Forms.Padding(5);
            this._addData.Name = "_addData";
            this._addData.Size = new System.Drawing.Size(124, 54);
            this._addData.TabIndex = 0;
            this._addData.Text = "Добавить";
            this._addData.UseVisualStyleBackColor = true;
            this._addData.Click += new System.EventHandler(this.OnAddDataClicked);
            // 
            // _workExperience
            // 
            this._workExperience.Dock = System.Windows.Forms.DockStyle.Fill;
            this._workExperience.Location = new System.Drawing.Point(3, 305);
            this._workExperience.Name = "_workExperience";
            this._workExperience.Size = new System.Drawing.Size(128, 20);
            this._workExperience.TabIndex = 14;
            // 
            // _request
            // 
            this._request.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._request.Controls.Add(this._requestPanel);
            this._request.Location = new System.Drawing.Point(12, 507);
            this._request.Name = "_request";
            this._request.Size = new System.Drawing.Size(140, 138);
            this._request.TabIndex = 2;
            this._request.TabStop = false;
            this._request.Text = "Запрос";
            // 
            // _requestPanel
            // 
            this._requestPanel.ColumnCount = 1;
            this._requestPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._requestPanel.Controls.Add(this._requestContent, 0, 2);
            this._requestPanel.Controls.Add(this._postRequest, 0, 1);
            this._requestPanel.Controls.Add(this._workExperienceRequest, 0, 0);
            this._requestPanel.Controls.Add(this._search, 0, 3);
            this._requestPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._requestPanel.Location = new System.Drawing.Point(3, 16);
            this._requestPanel.Name = "_requestPanel";
            this._requestPanel.RowCount = 4;
            this._requestPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._requestPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._requestPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._requestPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._requestPanel.Size = new System.Drawing.Size(134, 119);
            this._requestPanel.TabIndex = 0;
            // 
            // _requestContent
            // 
            this._requestContent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._requestContent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this._requestContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._requestContent.Location = new System.Drawing.Point(3, 59);
            this._requestContent.Name = "_requestContent";
            this._requestContent.Size = new System.Drawing.Size(128, 20);
            this._requestContent.TabIndex = 11;
            // 
            // _postRequest
            // 
            this._postRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this._postRequest.Location = new System.Drawing.Point(3, 31);
            this._postRequest.Name = "_postRequest";
            this._postRequest.Size = new System.Drawing.Size(128, 22);
            this._postRequest.TabIndex = 1;
            this._postRequest.Text = "Дожность";
            this._postRequest.UseVisualStyleBackColor = true;
            // 
            // _workExperienceRequest
            // 
            this._workExperienceRequest.Checked = true;
            this._workExperienceRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this._workExperienceRequest.Location = new System.Drawing.Point(3, 3);
            this._workExperienceRequest.Name = "_workExperienceRequest";
            this._workExperienceRequest.Size = new System.Drawing.Size(128, 22);
            this._workExperienceRequest.TabIndex = 0;
            this._workExperienceRequest.TabStop = true;
            this._workExperienceRequest.Text = "Стаж не менее";
            this._workExperienceRequest.UseVisualStyleBackColor = true;
            // 
            // _search
            // 
            this._search.Dock = System.Windows.Forms.DockStyle.Fill;
            this._search.Location = new System.Drawing.Point(5, 87);
            this._search.Margin = new System.Windows.Forms.Padding(5);
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(124, 27);
            this._search.TabIndex = 12;
            this._search.Text = "Найти";
            this._search.UseVisualStyleBackColor = true;
            this._search.Click += new System.EventHandler(this.OnSearchClicked);
            // 
            // _data
            // 
            this._data.Controls.Add(this._dataGrid);
            this._data.Dock = System.Windows.Forms.DockStyle.Fill;
            this._data.Location = new System.Drawing.Point(3, 3);
            this._data.Name = "_data";
            this._data.Size = new System.Drawing.Size(546, 303);
            this._data.TabIndex = 4;
            this._data.TabStop = false;
            this._data.Text = "Данные";
            // 
            // _dataGrid
            // 
            this._dataGrid.AllowUserToAddRows = false;
            this._dataGrid.AllowUserToDeleteRows = false;
            this._dataGrid.AllowUserToResizeColumns = false;
            this._dataGrid.AllowUserToResizeRows = false;
            this._dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGrid.Location = new System.Drawing.Point(3, 16);
            this._dataGrid.Name = "_dataGrid";
            this._dataGrid.ReadOnly = true;
            this._dataGrid.RowHeadersVisible = false;
            this._dataGrid.Size = new System.Drawing.Size(540, 284);
            this._dataGrid.TabIndex = 0;
            // 
            // _sample
            // 
            this._sample.Controls.Add(this._sampleGrid);
            this._sample.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sample.Location = new System.Drawing.Point(3, 312);
            this._sample.Name = "_sample";
            this._sample.Size = new System.Drawing.Size(546, 303);
            this._sample.TabIndex = 5;
            this._sample.TabStop = false;
            this._sample.Text = "Выборка";
            // 
            // _sampleGrid
            // 
            this._sampleGrid.AllowUserToAddRows = false;
            this._sampleGrid.AllowUserToResizeColumns = false;
            this._sampleGrid.AllowUserToResizeRows = false;
            this._sampleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._sampleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._sampleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sampleGrid.Location = new System.Drawing.Point(3, 16);
            this._sampleGrid.Name = "_sampleGrid";
            this._sampleGrid.ReadOnly = true;
            this._sampleGrid.RowHeadersVisible = false;
            this._sampleGrid.Size = new System.Drawing.Size(540, 284);
            this._sampleGrid.TabIndex = 1;
            // 
            // _dataGridsPanel
            // 
            this._dataGridsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this._dataGridsPanel.ColumnCount = 1;
            this._dataGridsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._dataGridsPanel.Controls.Add(this._sample, 0, 1);
            this._dataGridsPanel.Controls.Add(this._data, 0, 0);
            this._dataGridsPanel.Location = new System.Drawing.Point(158, 27);
            this._dataGridsPanel.Name = "_dataGridsPanel";
            this._dataGridsPanel.RowCount = 2;
            this._dataGridsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._dataGridsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._dataGridsPanel.Size = new System.Drawing.Size(552, 618);
            this._dataGridsPanel.TabIndex = 6;
            // 
            // _treeView
            // 
            this._treeView.Location = new System.Drawing.Point(716, 355);
            this._treeView.Name = "_treeView";
            this._treeView.Size = new System.Drawing.Size(506, 290);
            this._treeView.TabIndex = 7;
            // 
            // _listView
            // 
            this._listView.HideSelection = false;
            this._listView.Location = new System.Drawing.Point(716, 46);
            this._listView.Name = "_listView";
            this._listView.Size = new System.Drawing.Size(506, 284);
            this._listView.TabIndex = 8;
            this._listView.UseCompatibleStateImageBehavior = false;
            this._listView.View = System.Windows.Forms.View.Details;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 657);
            this.Controls.Add(this._listView);
            this.Controls.Add(this._treeView);
            this.Controls.Add(this._dataGridsPanel);
            this.Controls.Add(this._request);
            this.Controls.Add(this._dataInput);
            this.Controls.Add(this._toolBar);
            this.MainMenuStrip = this._toolBar;
            this.Name = "EmployeesForm";
            this.Text = "Отдел кадров";
            this.Load += new System.EventHandler(this.OnFormLoaded);
            this._toolBar.ResumeLayout(false);
            this._toolBar.PerformLayout();
            this._dataInput.ResumeLayout(false);
            this._dataInputPanel.ResumeLayout(false);
            this._dataInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._workExperience)).EndInit();
            this._request.ResumeLayout(false);
            this._requestPanel.ResumeLayout(false);
            this._requestPanel.PerformLayout();
            this._data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGrid)).EndInit();
            this._sample.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._sampleGrid)).EndInit();
            this._dataGridsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckedListBox _academicDegree;

        private System.Windows.Forms.TreeView _treeView;
        private System.Windows.Forms.ListView _listView;

        private System.Windows.Forms.DomainUpDown _post;

        private System.Windows.Forms.NumericUpDown _workExperience;
        private System.Windows.Forms.ToolStripMenuItem _searchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _addDataMenuItem;
        private System.Windows.Forms.Button _search;
        private System.Windows.Forms.TextBox _requestContent;
        private System.Windows.Forms.RadioButton _postRequest;
        private System.Windows.Forms.RadioButton _workExperienceRequest;
        private System.Windows.Forms.TableLayoutPanel _requestPanel;
        private System.Windows.Forms.DateTimePicker _birthDate;
        private System.Windows.Forms.Label _postLabel;
        private System.Windows.Forms.Label _birthDateLabel;
        private System.Windows.Forms.Label _academicDegreeLabel;
        private System.Windows.Forms.Label _workExperienceLabel;
        private System.Windows.Forms.TextBox _fullName;
        private System.Windows.Forms.Label _fullNameLabel;
        private System.Windows.Forms.Button _addData;
        private System.Windows.Forms.TableLayoutPanel _dataInputPanel;
        private System.Windows.Forms.ToolStripMenuItem _exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _actionsMenu;
        private System.Windows.Forms.TableLayoutPanel _dataGridsPanel;
        private System.Windows.Forms.DataGridView _sampleGrid;
        private System.Windows.Forms.DataGridView _dataGrid;
        private System.Windows.Forms.GroupBox _data;
        private System.Windows.Forms.GroupBox _sample;
        private System.Windows.Forms.GroupBox _dataInput;
        private System.Windows.Forms.GroupBox _request;
        private System.Windows.Forms.MenuStrip _toolBar;

        #endregion
    }
}