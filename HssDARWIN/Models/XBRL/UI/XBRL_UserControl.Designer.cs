namespace HssDARWIN.Models.XBRL.UI
{
    partial class XBRL_UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pending_radioButton = new System.Windows.Forms.RadioButton();
            this.approved_radioButton = new System.Windows.Forms.RadioButton();
            this.rejected_radioButton = new System.Windows.Forms.RadioButton();
            this.main_ultraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.loadAll_button = new System.Windows.Forms.Button();
            this.uploadXBRL_button = new System.Windows.Forms.Button();
            this.filter_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pending_radioButton
            // 
            this.pending_radioButton.AutoSize = true;
            this.pending_radioButton.Checked = true;
            this.pending_radioButton.Location = new System.Drawing.Point(15, 11);
            this.pending_radioButton.Name = "pending_radioButton";
            this.pending_radioButton.Size = new System.Drawing.Size(64, 17);
            this.pending_radioButton.TabIndex = 0;
            this.pending_radioButton.TabStop = true;
            this.pending_radioButton.Text = "Pending";
            this.pending_radioButton.UseVisualStyleBackColor = true;
            this.pending_radioButton.Click += new System.EventHandler(this.pending_radioButton_Click);
            // 
            // approved_radioButton
            // 
            this.approved_radioButton.AutoSize = true;
            this.approved_radioButton.Location = new System.Drawing.Point(98, 11);
            this.approved_radioButton.Name = "approved_radioButton";
            this.approved_radioButton.Size = new System.Drawing.Size(71, 17);
            this.approved_radioButton.TabIndex = 0;
            this.approved_radioButton.Text = "Approved";
            this.approved_radioButton.UseVisualStyleBackColor = true;
            this.approved_radioButton.Click += new System.EventHandler(this.approved_radioButton_Click);
            // 
            // rejected_radioButton
            // 
            this.rejected_radioButton.AutoSize = true;
            this.rejected_radioButton.Location = new System.Drawing.Point(194, 11);
            this.rejected_radioButton.Name = "rejected_radioButton";
            this.rejected_radioButton.Size = new System.Drawing.Size(68, 17);
            this.rejected_radioButton.TabIndex = 0;
            this.rejected_radioButton.Text = "Rejected";
            this.rejected_radioButton.UseVisualStyleBackColor = true;
            this.rejected_radioButton.Click += new System.EventHandler(this.rejected_radioButton_Click);
            // 
            // main_ultraGrid
            // 
            this.main_ultraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_ultraGrid.Location = new System.Drawing.Point(0, 36);
            this.main_ultraGrid.Name = "main_ultraGrid";
            this.main_ultraGrid.Size = new System.Drawing.Size(931, 486);
            this.main_ultraGrid.TabIndex = 1;
            this.main_ultraGrid.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.main_ultraGrid_InitializeLayout);
            this.main_ultraGrid.AfterRowRegionScroll += new Infragistics.Win.UltraWinGrid.RowScrollRegionEventHandler(this.main_ultraGrid_AfterRowRegionScroll);
            this.main_ultraGrid.Leave += new System.EventHandler(this.main_ultraGrid_Leave);
            this.main_ultraGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_ultraGrid_MouseDown);
            // 
            // loadAll_button
            // 
            this.loadAll_button.Location = new System.Drawing.Point(288, 8);
            this.loadAll_button.Name = "loadAll_button";
            this.loadAll_button.Size = new System.Drawing.Size(90, 23);
            this.loadAll_button.TabIndex = 2;
            this.loadAll_button.Text = "Load All Data";
            this.loadAll_button.UseVisualStyleBackColor = true;
            this.loadAll_button.Click += new System.EventHandler(this.loadAll_button_Click);
            // 
            // uploadXBRL_button
            // 
            this.uploadXBRL_button.Location = new System.Drawing.Point(407, 8);
            this.uploadXBRL_button.Name = "uploadXBRL_button";
            this.uploadXBRL_button.Size = new System.Drawing.Size(99, 23);
            this.uploadXBRL_button.TabIndex = 3;
            this.uploadXBRL_button.Text = "Upload XBRL";
            this.uploadXBRL_button.UseVisualStyleBackColor = true;
            this.uploadXBRL_button.Click += new System.EventHandler(this.uploadXBRL_button_Click);
            // 
            // filter_button
            // 
            this.filter_button.Location = new System.Drawing.Point(533, 8);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(75, 23);
            this.filter_button.TabIndex = 4;
            this.filter_button.Text = "Filter";
            this.filter_button.UseVisualStyleBackColor = true;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh_button.Location = new System.Drawing.Point(853, 8);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 23);
            this.refresh_button.TabIndex = 5;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // XBRL_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.filter_button);
            this.Controls.Add(this.uploadXBRL_button);
            this.Controls.Add(this.loadAll_button);
            this.Controls.Add(this.main_ultraGrid);
            this.Controls.Add(this.rejected_radioButton);
            this.Controls.Add(this.approved_radioButton);
            this.Controls.Add(this.pending_radioButton);
            this.Name = "XBRL_UserControl";
            this.Size = new System.Drawing.Size(931, 522);
            this.Load += new System.EventHandler(this.XBRL_UserControl_Load);
            this.Resize += new System.EventHandler(this.XBRL_UserControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton pending_radioButton;
        private System.Windows.Forms.RadioButton approved_radioButton;
        private System.Windows.Forms.RadioButton rejected_radioButton;
        private Infragistics.Win.UltraWinGrid.UltraGrid main_ultraGrid;
        private System.Windows.Forms.Button loadAll_button;
        private System.Windows.Forms.Button uploadXBRL_button;
        private System.Windows.Forms.Button filter_button;
        private System.Windows.Forms.Button refresh_button;
    }
}
