namespace WatcherForm
{
    partial class FileForm
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
            this.main_ultraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.svFileDia = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // main_ultraGrid
            // 
            this.main_ultraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_ultraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.main_ultraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.main_ultraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.main_ultraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle;
            this.main_ultraGrid.Location = new System.Drawing.Point(0, 39);
            this.main_ultraGrid.Name = "main_ultraGrid";
            this.main_ultraGrid.Size = new System.Drawing.Size(725, 495);
            this.main_ultraGrid.TabIndex = 0;
            this.main_ultraGrid.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.Main_ultraGrid_InitializeLayout);
            this.main_ultraGrid.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.main_ultraGrid_ClickCellButton);
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(12, 12);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(359, 20);
            this.search_textBox.TabIndex = 1;
            this.search_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_textBox_KeyPress);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(377, 10);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // svFileDia
            // 
            this.svFileDia.Filter = "Text | *.txt";
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 534);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.main_ultraGrid);
            this.Name = "FileForm";
            this.Text = "FileForm";
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid main_ultraGrid;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.SaveFileDialog svFileDia;
    }
}