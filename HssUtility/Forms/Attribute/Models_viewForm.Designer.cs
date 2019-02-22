namespace HssUtility.Forms.Attribute
{
    partial class Models_viewForm
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
            this.main_flowtPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PK_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // main_flowtPanel
            // 
            this.main_flowtPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_flowtPanel.AutoScroll = true;
            this.main_flowtPanel.Location = new System.Drawing.Point(0, 39);
            this.main_flowtPanel.Name = "main_flowtPanel";
            this.main_flowtPanel.Size = new System.Drawing.Size(594, 296);
            this.main_flowtPanel.TabIndex = 0;
            // 
            // PK_label
            // 
            this.PK_label.AutoSize = true;
            this.PK_label.Location = new System.Drawing.Point(13, 13);
            this.PK_label.Name = "PK_label";
            this.PK_label.Size = new System.Drawing.Size(24, 13);
            this.PK_label.TabIndex = 1;
            this.PK_label.Text = "PK:";
            // 
            // save_button
            // 
            this.save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save_button.Location = new System.Drawing.Point(420, 8);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 2;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.Location = new System.Drawing.Point(501, 8);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 2;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Models_viewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 335);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.PK_label);
            this.Controls.Add(this.main_flowtPanel);
            this.Name = "Models_viewForm";
            this.Text = "FlowControl_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel main_flowtPanel;
        private System.Windows.Forms.Label PK_label;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button close_button;
    }
}