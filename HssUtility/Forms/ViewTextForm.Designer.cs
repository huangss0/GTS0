namespace HssUtility.Forms
{
    partial class ViewTextForm
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
            this.main_tabControl = new System.Windows.Forms.TabControl();
            this.notepad_tabPage = new System.Windows.Forms.TabPage();
            this.find_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.commit_button = new System.Windows.Forms.Button();
            this.main_richTextBox = new System.Windows.Forms.RichTextBox();
            this.grid_tabPage = new System.Windows.Forms.TabPage();
            this.main_ultraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.saveAs_button = new System.Windows.Forms.Button();
            this.main_tabControl.SuspendLayout();
            this.notepad_tabPage.SuspendLayout();
            this.grid_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // main_tabControl
            // 
            this.main_tabControl.Controls.Add(this.notepad_tabPage);
            this.main_tabControl.Controls.Add(this.grid_tabPage);
            this.main_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_tabControl.Location = new System.Drawing.Point(0, 0);
            this.main_tabControl.Name = "main_tabControl";
            this.main_tabControl.SelectedIndex = 0;
            this.main_tabControl.Size = new System.Drawing.Size(820, 586);
            this.main_tabControl.TabIndex = 1;
            // 
            // notepad_tabPage
            // 
            this.notepad_tabPage.Controls.Add(this.saveAs_button);
            this.notepad_tabPage.Controls.Add(this.find_textBox);
            this.notepad_tabPage.Controls.Add(this.label1);
            this.notepad_tabPage.Controls.Add(this.commit_button);
            this.notepad_tabPage.Controls.Add(this.main_richTextBox);
            this.notepad_tabPage.Location = new System.Drawing.Point(4, 22);
            this.notepad_tabPage.Name = "notepad_tabPage";
            this.notepad_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.notepad_tabPage.Size = new System.Drawing.Size(812, 560);
            this.notepad_tabPage.TabIndex = 1;
            this.notepad_tabPage.Text = "Note Pad";
            this.notepad_tabPage.UseVisualStyleBackColor = true;
            // 
            // find_textBox
            // 
            this.find_textBox.Location = new System.Drawing.Point(613, 9);
            this.find_textBox.Name = "find_textBox";
            this.find_textBox.Size = new System.Drawing.Size(191, 20);
            this.find_textBox.TabIndex = 3;
            this.find_textBox.TextChanged += new System.EventHandler(this.find_textBox_TextChanged);
            this.find_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.find_textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find:";
            // 
            // commit_button
            // 
            this.commit_button.Location = new System.Drawing.Point(9, 7);
            this.commit_button.Name = "commit_button";
            this.commit_button.Size = new System.Drawing.Size(75, 23);
            this.commit_button.TabIndex = 1;
            this.commit_button.Text = "Commit";
            this.commit_button.UseVisualStyleBackColor = true;
            this.commit_button.Click += new System.EventHandler(this.commit_button_Click);
            // 
            // main_richTextBox
            // 
            this.main_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_richTextBox.DetectUrls = false;
            this.main_richTextBox.HideSelection = false;
            this.main_richTextBox.Location = new System.Drawing.Point(3, 36);
            this.main_richTextBox.Name = "main_richTextBox";
            this.main_richTextBox.Size = new System.Drawing.Size(806, 521);
            this.main_richTextBox.TabIndex = 0;
            this.main_richTextBox.Text = "";
            this.main_richTextBox.WordWrap = false;
            // 
            // grid_tabPage
            // 
            this.grid_tabPage.Controls.Add(this.main_ultraGrid);
            this.grid_tabPage.Location = new System.Drawing.Point(4, 22);
            this.grid_tabPage.Name = "grid_tabPage";
            this.grid_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.grid_tabPage.Size = new System.Drawing.Size(812, 560);
            this.grid_tabPage.TabIndex = 2;
            this.grid_tabPage.Text = "GridView";
            this.grid_tabPage.UseVisualStyleBackColor = true;
            // 
            // main_ultraGrid
            // 
            this.main_ultraGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_ultraGrid.Location = new System.Drawing.Point(3, 3);
            this.main_ultraGrid.Name = "main_ultraGrid";
            this.main_ultraGrid.Size = new System.Drawing.Size(806, 554);
            this.main_ultraGrid.TabIndex = 1;
            // 
            // saveAs_button
            // 
            this.saveAs_button.Location = new System.Drawing.Point(90, 7);
            this.saveAs_button.Name = "saveAs_button";
            this.saveAs_button.Size = new System.Drawing.Size(75, 23);
            this.saveAs_button.TabIndex = 4;
            this.saveAs_button.Text = "Save As";
            this.saveAs_button.UseVisualStyleBackColor = true;
            this.saveAs_button.Click += new System.EventHandler(this.saveAs_button_Click);
            // 
            // ViewTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 586);
            this.Controls.Add(this.main_tabControl);
            this.Name = "ViewTextForm";
            this.Text = "ViewTextForm";
            this.main_tabControl.ResumeLayout(false);
            this.notepad_tabPage.ResumeLayout(false);
            this.notepad_tabPage.PerformLayout();
            this.grid_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl main_tabControl;
        private System.Windows.Forms.TabPage notepad_tabPage;
        private System.Windows.Forms.TextBox find_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button commit_button;
        private System.Windows.Forms.RichTextBox main_richTextBox;
        private System.Windows.Forms.TabPage grid_tabPage;
        private Infragistics.Win.UltraWinGrid.UltraGrid main_ultraGrid;
        private System.Windows.Forms.Button saveAs_button;
    }
}