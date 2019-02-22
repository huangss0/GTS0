namespace HssDARWIN.SubProjects.TaskMgr.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_ultraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.showAll_button = new System.Windows.Forms.Button();
            this.task_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.run_button = new System.Windows.Forms.Button();
            this.add17_button = new System.Windows.Forms.Button();
            this.main_splitContainer = new System.Windows.Forms.SplitContainer();
            this.select_tabControl = new System.Windows.Forms.TabControl();
            this.user_tabPage = new System.Windows.Forms.TabPage();
            this.members_treeView = new System.Windows.Forms.TreeView();
            this.cty_tabPage = new System.Windows.Forms.TabPage();
            this.cty_all_checkBox = new System.Windows.Forms.CheckBox();
            this.cty_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.taskID_tabPage = new System.Windows.Forms.TabPage();
            this.taskID_all_checkBox = new System.Windows.Forms.CheckBox();
            this.taskID_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.main_tabControl = new System.Windows.Forms.TabControl();
            this.myTask_tabPage = new System.Windows.Forms.TabPage();
            this.test_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.filter_button = new System.Windows.Forms.Button();
            this.tskAdmin_tabPage = new System.Windows.Forms.TabPage();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_splitContainer)).BeginInit();
            this.main_splitContainer.Panel1.SuspendLayout();
            this.main_splitContainer.Panel2.SuspendLayout();
            this.main_splitContainer.SuspendLayout();
            this.select_tabControl.SuspendLayout();
            this.user_tabPage.SuspendLayout();
            this.cty_tabPage.SuspendLayout();
            this.taskID_tabPage.SuspendLayout();
            this.main_tabControl.SuspendLayout();
            this.myTask_tabPage.SuspendLayout();
            this.tskAdmin_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_ultraGrid
            // 
            this.main_ultraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle;
            this.main_ultraGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_ultraGrid.Location = new System.Drawing.Point(0, 0);
            this.main_ultraGrid.Name = "main_ultraGrid";
            this.main_ultraGrid.Size = new System.Drawing.Size(1047, 649);
            this.main_ultraGrid.TabIndex = 0;
            this.main_ultraGrid.TabStop = false;
            this.main_ultraGrid.AfterRowRegionScroll += new Infragistics.Win.UltraWinGrid.RowScrollRegionEventHandler(this.main_ultraGrid_AfterRowRegionScroll);
            this.main_ultraGrid.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.main_ultraGrid_ClickCellButton);
            this.main_ultraGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.main_ultraGrid_KeyPress);
            this.main_ultraGrid.Leave += new System.EventHandler(this.main_ultraGrid_Leave);
            this.main_ultraGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_ultraGrid_MouseDown);
            // 
            // showAll_button
            // 
            this.showAll_button.Location = new System.Drawing.Point(155, 4);
            this.showAll_button.Name = "showAll_button";
            this.showAll_button.Size = new System.Drawing.Size(100, 23);
            this.showAll_button.TabIndex = 0;
            this.showAll_button.Text = "Show All Details";
            this.showAll_button.UseVisualStyleBackColor = true;
            this.showAll_button.Click += new System.EventHandler(this.showAll_button_Click);
            // 
            // task_comboBox
            // 
            this.task_comboBox.FormattingEnabled = true;
            this.task_comboBox.Items.AddRange(new object[] {
            "All",
            "Uncompleted",
            "Completed"});
            this.task_comboBox.Location = new System.Drawing.Point(51, 6);
            this.task_comboBox.Name = "task_comboBox";
            this.task_comboBox.Size = new System.Drawing.Size(98, 21);
            this.task_comboBox.TabIndex = 3;
            this.task_comboBox.TabStop = false;
            this.task_comboBox.Text = "Uncompleted";
            this.task_comboBox.SelectedIndexChanged += new System.EventHandler(this.task_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status:";
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(102, 6);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(88, 23);
            this.run_button.TabIndex = 2;
            this.run_button.Text = "Run Task 20";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run20_button_Click);
            // 
            // add17_button
            // 
            this.add17_button.Location = new System.Drawing.Point(8, 6);
            this.add17_button.Name = "add17_button";
            this.add17_button.Size = new System.Drawing.Size(88, 23);
            this.add17_button.TabIndex = 1;
            this.add17_button.Text = "Add Task 17";
            this.add17_button.UseVisualStyleBackColor = true;
            this.add17_button.Click += new System.EventHandler(this.add17_button_Click);
            // 
            // main_splitContainer
            // 
            this.main_splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.main_splitContainer.Location = new System.Drawing.Point(3, 33);
            this.main_splitContainer.Name = "main_splitContainer";
            // 
            // main_splitContainer.Panel1
            // 
            this.main_splitContainer.Panel1.Controls.Add(this.select_tabControl);
            // 
            // main_splitContainer.Panel2
            // 
            this.main_splitContainer.Panel2.Controls.Add(this.main_ultraGrid);
            this.main_splitContainer.Size = new System.Drawing.Size(1270, 649);
            this.main_splitContainer.SplitterDistance = 219;
            this.main_splitContainer.TabIndex = 7;
            // 
            // select_tabControl
            // 
            this.select_tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.select_tabControl.Controls.Add(this.user_tabPage);
            this.select_tabControl.Controls.Add(this.cty_tabPage);
            this.select_tabControl.Controls.Add(this.taskID_tabPage);
            this.select_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.select_tabControl.Location = new System.Drawing.Point(0, 0);
            this.select_tabControl.Name = "select_tabControl";
            this.select_tabControl.SelectedIndex = 0;
            this.select_tabControl.Size = new System.Drawing.Size(219, 649);
            this.select_tabControl.TabIndex = 8;
            // 
            // user_tabPage
            // 
            this.user_tabPage.Controls.Add(this.members_treeView);
            this.user_tabPage.Location = new System.Drawing.Point(4, 4);
            this.user_tabPage.Name = "user_tabPage";
            this.user_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.user_tabPage.Size = new System.Drawing.Size(211, 623);
            this.user_tabPage.TabIndex = 0;
            this.user_tabPage.Text = "User";
            this.user_tabPage.UseVisualStyleBackColor = true;
            // 
            // members_treeView
            // 
            this.members_treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.members_treeView.Location = new System.Drawing.Point(3, 3);
            this.members_treeView.Name = "members_treeView";
            this.members_treeView.Size = new System.Drawing.Size(205, 617);
            this.members_treeView.TabIndex = 7;
            this.members_treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.members_treeView_AfterSelect);
            // 
            // cty_tabPage
            // 
            this.cty_tabPage.Controls.Add(this.cty_all_checkBox);
            this.cty_tabPage.Controls.Add(this.cty_checkedListBox);
            this.cty_tabPage.Location = new System.Drawing.Point(4, 4);
            this.cty_tabPage.Name = "cty_tabPage";
            this.cty_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cty_tabPage.Size = new System.Drawing.Size(211, 623);
            this.cty_tabPage.TabIndex = 1;
            this.cty_tabPage.Text = "Country";
            this.cty_tabPage.UseVisualStyleBackColor = true;
            // 
            // cty_all_checkBox
            // 
            this.cty_all_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cty_all_checkBox.AutoSize = true;
            this.cty_all_checkBox.Location = new System.Drawing.Point(166, 599);
            this.cty_all_checkBox.Name = "cty_all_checkBox";
            this.cty_all_checkBox.Size = new System.Drawing.Size(45, 17);
            this.cty_all_checkBox.TabIndex = 2;
            this.cty_all_checkBox.Text = "ALL";
            this.cty_all_checkBox.UseVisualStyleBackColor = true;
            this.cty_all_checkBox.CheckedChanged += new System.EventHandler(this.cty_all_checkBox_CheckedChanged);
            // 
            // cty_checkedListBox
            // 
            this.cty_checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cty_checkedListBox.CheckOnClick = true;
            this.cty_checkedListBox.FormattingEnabled = true;
            this.cty_checkedListBox.Location = new System.Drawing.Point(3, 3);
            this.cty_checkedListBox.Name = "cty_checkedListBox";
            this.cty_checkedListBox.Size = new System.Drawing.Size(205, 589);
            this.cty_checkedListBox.TabIndex = 0;
            // 
            // taskID_tabPage
            // 
            this.taskID_tabPage.Controls.Add(this.taskID_all_checkBox);
            this.taskID_tabPage.Controls.Add(this.taskID_checkedListBox);
            this.taskID_tabPage.Location = new System.Drawing.Point(4, 4);
            this.taskID_tabPage.Name = "taskID_tabPage";
            this.taskID_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.taskID_tabPage.Size = new System.Drawing.Size(211, 623);
            this.taskID_tabPage.TabIndex = 2;
            this.taskID_tabPage.Text = "TaskID";
            this.taskID_tabPage.UseVisualStyleBackColor = true;
            // 
            // taskID_all_checkBox
            // 
            this.taskID_all_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.taskID_all_checkBox.AutoSize = true;
            this.taskID_all_checkBox.Location = new System.Drawing.Point(166, 599);
            this.taskID_all_checkBox.Name = "taskID_all_checkBox";
            this.taskID_all_checkBox.Size = new System.Drawing.Size(45, 17);
            this.taskID_all_checkBox.TabIndex = 1;
            this.taskID_all_checkBox.Text = "ALL";
            this.taskID_all_checkBox.UseVisualStyleBackColor = true;
            this.taskID_all_checkBox.CheckedChanged += new System.EventHandler(this.taskID_all_checkBox_CheckedChanged);
            // 
            // taskID_checkedListBox
            // 
            this.taskID_checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskID_checkedListBox.CheckOnClick = true;
            this.taskID_checkedListBox.FormattingEnabled = true;
            this.taskID_checkedListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.taskID_checkedListBox.Location = new System.Drawing.Point(3, 3);
            this.taskID_checkedListBox.MultiColumn = true;
            this.taskID_checkedListBox.Name = "taskID_checkedListBox";
            this.taskID_checkedListBox.Size = new System.Drawing.Size(205, 589);
            this.taskID_checkedListBox.TabIndex = 0;
            // 
            // main_tabControl
            // 
            this.main_tabControl.Controls.Add(this.myTask_tabPage);
            this.main_tabControl.Controls.Add(this.tskAdmin_tabPage);
            this.main_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_tabControl.Location = new System.Drawing.Point(0, 0);
            this.main_tabControl.Name = "main_tabControl";
            this.main_tabControl.SelectedIndex = 0;
            this.main_tabControl.Size = new System.Drawing.Size(1284, 711);
            this.main_tabControl.TabIndex = 8;
            // 
            // myTask_tabPage
            // 
            this.myTask_tabPage.Controls.Add(this.test_button);
            this.myTask_tabPage.Controls.Add(this.refresh_button);
            this.myTask_tabPage.Controls.Add(this.filter_button);
            this.myTask_tabPage.Controls.Add(this.main_splitContainer);
            this.myTask_tabPage.Controls.Add(this.showAll_button);
            this.myTask_tabPage.Controls.Add(this.label1);
            this.myTask_tabPage.Controls.Add(this.task_comboBox);
            this.myTask_tabPage.Location = new System.Drawing.Point(4, 22);
            this.myTask_tabPage.Name = "myTask_tabPage";
            this.myTask_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.myTask_tabPage.Size = new System.Drawing.Size(1276, 685);
            this.myTask_tabPage.TabIndex = 0;
            this.myTask_tabPage.Text = "My Task";
            this.myTask_tabPage.UseVisualStyleBackColor = true;
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(1067, 4);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(75, 23);
            this.test_button.TabIndex = 10;
            this.test_button.Text = "Test";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(342, 4);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 23);
            this.refresh_button.TabIndex = 9;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // filter_button
            // 
            this.filter_button.Location = new System.Drawing.Point(261, 4);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(75, 23);
            this.filter_button.TabIndex = 8;
            this.filter_button.Text = "Filter";
            this.filter_button.UseVisualStyleBackColor = true;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // tskAdmin_tabPage
            // 
            this.tskAdmin_tabPage.Controls.Add(this.delete_button);
            this.tskAdmin_tabPage.Controls.Add(this.run_button);
            this.tskAdmin_tabPage.Controls.Add(this.add17_button);
            this.tskAdmin_tabPage.Location = new System.Drawing.Point(4, 22);
            this.tskAdmin_tabPage.Name = "tskAdmin_tabPage";
            this.tskAdmin_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tskAdmin_tabPage.Size = new System.Drawing.Size(1276, 685);
            this.tskAdmin_tabPage.TabIndex = 1;
            this.tskAdmin_tabPage.Text = "Task Admin";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(269, 6);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 7;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.main_tabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager Testing (by Steven Huang)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).EndInit();
            this.main_splitContainer.Panel1.ResumeLayout(false);
            this.main_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_splitContainer)).EndInit();
            this.main_splitContainer.ResumeLayout(false);
            this.select_tabControl.ResumeLayout(false);
            this.user_tabPage.ResumeLayout(false);
            this.cty_tabPage.ResumeLayout(false);
            this.cty_tabPage.PerformLayout();
            this.taskID_tabPage.ResumeLayout(false);
            this.taskID_tabPage.PerformLayout();
            this.main_tabControl.ResumeLayout(false);
            this.myTask_tabPage.ResumeLayout(false);
            this.myTask_tabPage.PerformLayout();
            this.tskAdmin_tabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid main_ultraGrid;
        private System.Windows.Forms.Button showAll_button;
        private System.Windows.Forms.ComboBox task_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.Button add17_button;
        private System.Windows.Forms.SplitContainer main_splitContainer;
        private System.Windows.Forms.TreeView members_treeView;
        private System.Windows.Forms.TabControl main_tabControl;
        private System.Windows.Forms.TabPage myTask_tabPage;
        private System.Windows.Forms.TabPage tskAdmin_tabPage;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TabControl select_tabControl;
        private System.Windows.Forms.TabPage user_tabPage;
        private System.Windows.Forms.TabPage cty_tabPage;
        private System.Windows.Forms.TabPage taskID_tabPage;
        private System.Windows.Forms.CheckedListBox taskID_checkedListBox;
        private System.Windows.Forms.CheckedListBox cty_checkedListBox;
        private System.Windows.Forms.CheckBox cty_all_checkBox;
        private System.Windows.Forms.CheckBox taskID_all_checkBox;
        private System.Windows.Forms.Button filter_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button test_button;
    }
}