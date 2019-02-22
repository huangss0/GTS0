namespace HssDARWIN.SubProjects.TaskMgr.Forms.Task17
{
    partial class Form_task17
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
            this.save_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taskName_textBox = new System.Windows.Forms.TextBox();
            this.notes_textBox = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.complete_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(49, 97);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 0;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notes:";
            // 
            // taskName_textBox
            // 
            this.taskName_textBox.Location = new System.Drawing.Point(85, 12);
            this.taskName_textBox.Name = "taskName_textBox";
            this.taskName_textBox.Size = new System.Drawing.Size(187, 20);
            this.taskName_textBox.TabIndex = 3;
            // 
            // notes_textBox
            // 
            this.notes_textBox.Location = new System.Drawing.Point(85, 38);
            this.notes_textBox.Name = "notes_textBox";
            this.notes_textBox.Size = new System.Drawing.Size(187, 20);
            this.notes_textBox.TabIndex = 3;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(152, 97);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 0;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // complete_checkBox
            // 
            this.complete_checkBox.AutoSize = true;
            this.complete_checkBox.Location = new System.Drawing.Point(85, 67);
            this.complete_checkBox.Name = "complete_checkBox";
            this.complete_checkBox.Size = new System.Drawing.Size(76, 17);
            this.complete_checkBox.TabIndex = 5;
            this.complete_checkBox.Text = "Completed";
            this.complete_checkBox.UseVisualStyleBackColor = true;
            // 
            // Form_task17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 137);
            this.Controls.Add(this.complete_checkBox);
            this.Controls.Add(this.notes_textBox);
            this.Controls.Add(this.taskName_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Name = "Form_task17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_task17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taskName_textBox;
        private System.Windows.Forms.TextBox notes_textBox;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.CheckBox complete_checkBox;
    }
}