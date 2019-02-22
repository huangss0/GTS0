namespace HssDARWIN.SubProjects.Business_Development
{
    partial class ThreadStatusForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recordNum_label = new System.Windows.Forms.Label();
            this.info_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(52, 9);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(23, 13);
            this.status_label.TabIndex = 2;
            this.status_label.Text = "idle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Records:";
            // 
            // recordNum_label
            // 
            this.recordNum_label.AutoSize = true;
            this.recordNum_label.Location = new System.Drawing.Point(62, 35);
            this.recordNum_label.Name = "recordNum_label";
            this.recordNum_label.Size = new System.Drawing.Size(13, 13);
            this.recordNum_label.TabIndex = 4;
            this.recordNum_label.Text = "0";
            // 
            // info_textBox
            // 
            this.info_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_textBox.Location = new System.Drawing.Point(0, 61);
            this.info_textBox.Multiline = true;
            this.info_textBox.Name = "info_textBox";
            this.info_textBox.Size = new System.Drawing.Size(390, 176);
            this.info_textBox.TabIndex = 5;
            // 
            // ThreadStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 237);
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.recordNum_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.label1);
            this.Name = "ThreadStatusForm";
            this.Text = "ThreadStatusForm";
            this.Load += new System.EventHandler(this.ThreadStatusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label recordNum_label;
        private System.Windows.Forms.TextBox info_textBox;
    }
}