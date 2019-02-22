namespace HssUtility.Forms.Filter
{
    partial class FilterForm
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
            this.main_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.test_button = new System.Windows.Forms.Button();
            this.and_radioButton = new System.Windows.Forms.RadioButton();
            this.or_radioButton = new System.Windows.Forms.RadioButton();
            this.ok_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // main_flowLayoutPanel
            // 
            this.main_flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_flowLayoutPanel.Location = new System.Drawing.Point(0, 46);
            this.main_flowLayoutPanel.Name = "main_flowLayoutPanel";
            this.main_flowLayoutPanel.Size = new System.Drawing.Size(544, 271);
            this.main_flowLayoutPanel.TabIndex = 0;
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(13, 13);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(75, 23);
            this.test_button.TabIndex = 1;
            this.test_button.Text = "Add";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // and_radioButton
            // 
            this.and_radioButton.AutoSize = true;
            this.and_radioButton.Checked = true;
            this.and_radioButton.Location = new System.Drawing.Point(260, 16);
            this.and_radioButton.Name = "and_radioButton";
            this.and_radioButton.Size = new System.Drawing.Size(48, 17);
            this.and_radioButton.TabIndex = 2;
            this.and_radioButton.TabStop = true;
            this.and_radioButton.Text = "AND";
            this.and_radioButton.UseVisualStyleBackColor = true;
            // 
            // or_radioButton
            // 
            this.or_radioButton.AutoSize = true;
            this.or_radioButton.Location = new System.Drawing.Point(314, 16);
            this.or_radioButton.Name = "or_radioButton";
            this.or_radioButton.Size = new System.Drawing.Size(41, 17);
            this.or_radioButton.TabIndex = 2;
            this.or_radioButton.Text = "OR";
            this.or_radioButton.UseVisualStyleBackColor = true;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(457, 13);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 3;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(94, 13);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "Clear All";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 317);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.or_radioButton);
            this.Controls.Add(this.and_radioButton);
            this.Controls.Add(this.test_button);
            this.Controls.Add(this.main_flowLayoutPanel);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel main_flowLayoutPanel;
        private System.Windows.Forms.Button test_button;
        private System.Windows.Forms.RadioButton and_radioButton;
        private System.Windows.Forms.RadioButton or_radioButton;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button clear_button;
    }
}