namespace HssDARWIN.SubProjects.SPR_Report
{
    partial class SPR_report_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reject_radioButton = new System.Windows.Forms.RadioButton();
            this.appr_radioButton = new System.Windows.Forms.RadioButton();
            this.pending_radioButton = new System.Windows.Forms.RadioButton();
            this.main_ultraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.upload_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // reject_radioButton
            // 
            this.reject_radioButton.AutoSize = true;
            this.reject_radioButton.Location = new System.Drawing.Point(194, 11);
            this.reject_radioButton.Name = "reject_radioButton";
            this.reject_radioButton.Size = new System.Drawing.Size(68, 17);
            this.reject_radioButton.TabIndex = 1;
            this.reject_radioButton.Text = "Rejected";
            this.reject_radioButton.UseVisualStyleBackColor = true;
            this.reject_radioButton.CheckedChanged += new System.EventHandler(this.reject_radioButton_CheckedChanged);
            // 
            // appr_radioButton
            // 
            this.appr_radioButton.AutoSize = true;
            this.appr_radioButton.Location = new System.Drawing.Point(98, 11);
            this.appr_radioButton.Name = "appr_radioButton";
            this.appr_radioButton.Size = new System.Drawing.Size(71, 17);
            this.appr_radioButton.TabIndex = 2;
            this.appr_radioButton.Text = "Approved";
            this.appr_radioButton.UseVisualStyleBackColor = true;
            this.appr_radioButton.CheckedChanged += new System.EventHandler(this.appr_radioButton_CheckedChanged);
            // 
            // pending_radioButton
            // 
            this.pending_radioButton.AutoSize = true;
            this.pending_radioButton.Checked = true;
            this.pending_radioButton.Location = new System.Drawing.Point(15, 11);
            this.pending_radioButton.Name = "pending_radioButton";
            this.pending_radioButton.Size = new System.Drawing.Size(64, 17);
            this.pending_radioButton.TabIndex = 3;
            this.pending_radioButton.TabStop = true;
            this.pending_radioButton.Text = "Pending";
            this.pending_radioButton.UseVisualStyleBackColor = true;
            this.pending_radioButton.CheckedChanged += new System.EventHandler(this.pending_radioButton_CheckedChanged);
            // 
            // main_ultraGrid
            // 
            this.main_ultraGrid.Location = new System.Drawing.Point(0, 40);
            this.main_ultraGrid.Name = "main_ultraGrid";
            this.main_ultraGrid.Size = new System.Drawing.Size(931, 482);
            this.main_ultraGrid.TabIndex = 4;
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(573, 8);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(119, 23);
            this.upload_button.TabIndex = 6;
            this.upload_button.Text = "Test Upload File";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Visible = false;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh_button.Location = new System.Drawing.Point(853, 8);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 23);
            this.refresh_button.TabIndex = 7;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // SPR_report_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.upload_button);
            this.Controls.Add(this.main_ultraGrid);
            this.Controls.Add(this.reject_radioButton);
            this.Controls.Add(this.appr_radioButton);
            this.Controls.Add(this.pending_radioButton);
            this.Name = "SPR_report_UserControl";
            this.Size = new System.Drawing.Size(931, 522);
            this.Load += new System.EventHandler(this.SPR_report_UserControl_Load);
            this.Resize += new System.EventHandler(this.SPR_report_UserControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.RadioButton reject_radioButton;
        internal System.Windows.Forms.RadioButton appr_radioButton;
        internal System.Windows.Forms.RadioButton pending_radioButton;
        private Infragistics.Win.UltraWinGrid.UltraGrid main_ultraGrid;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.Button refresh_button;
    }
}
