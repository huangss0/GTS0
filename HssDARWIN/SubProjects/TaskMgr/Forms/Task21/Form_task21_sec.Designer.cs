namespace HssDARWIN.SubProjects.TaskMgr.Forms.Task21
{
    partial class Form_task21_sec
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
            this.close_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.secNum_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // main_ultraGrid
            // 
            this.main_ultraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_ultraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            this.main_ultraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.main_ultraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.main_ultraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.main_ultraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle;
            this.main_ultraGrid.Location = new System.Drawing.Point(12, 27);
            this.main_ultraGrid.Name = "main_ultraGrid";
            this.main_ultraGrid.Size = new System.Drawing.Size(527, 186);
            this.main_ultraGrid.TabIndex = 10;
            this.main_ultraGrid.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.main_ultraGrid_InitializeLayout);
            this.main_ultraGrid.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.main_ultraGrid_ClickCellButton);
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.Location = new System.Drawing.Point(464, 219);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 9;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_button.Location = new System.Drawing.Point(355, 219);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(103, 23);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Add New Event";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // secNum_label
            // 
            this.secNum_label.AutoSize = true;
            this.secNum_label.Location = new System.Drawing.Point(12, 11);
            this.secNum_label.Name = "secNum_label";
            this.secNum_label.Size = new System.Drawing.Size(58, 13);
            this.secNum_label.TabIndex = 7;
            this.secNum_label.Text = "Security #:";
            // 
            // SecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 252);
            this.Controls.Add(this.main_ultraGrid);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.secNum_label);
            this.Name = "SecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecForm";
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Infragistics.Win.UltraWinGrid.UltraGrid main_ultraGrid;
        internal System.Windows.Forms.Button close_button;
        internal System.Windows.Forms.Button add_button;
        internal System.Windows.Forms.Label secNum_label;
    }
}