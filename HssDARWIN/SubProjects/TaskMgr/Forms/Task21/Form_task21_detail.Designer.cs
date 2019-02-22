namespace HssDARWIN.SubProjects.TaskMgr.Forms.Task21
{
    partial class Form_task21_detail
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
            this.secID_label = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.status_comboBox = new System.Windows.Forms.ComboBox();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.taskName_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // secID_label
            // 
            this.secID_label.AutoSize = true;
            this.secID_label.Location = new System.Drawing.Point(12, 9);
            this.secID_label.Name = "secID_label";
            this.secID_label.Size = new System.Drawing.Size(58, 13);
            this.secID_label.TabIndex = 25;
            this.secID_label.Text = "Security #:";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(154, 129);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 23;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(59, 129);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 24;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(37, 13);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Status";
            // 
            // status_comboBox
            // 
            this.status_comboBox.FormattingEnabled = true;
            this.status_comboBox.Items.AddRange(new object[] {
            "Normal",
            "Suspend",
            "None"});
            this.status_comboBox.Location = new System.Drawing.Point(52, 93);
            this.status_comboBox.Name = "status_comboBox";
            this.status_comboBox.Size = new System.Drawing.Size(121, 21);
            this.status_comboBox.TabIndex = 19;
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(164, 65);
            this.NumericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumericUpDown1.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(110, 20);
            this.NumericUpDown1.TabIndex = 18;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(149, 13);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Days from ADR Receive Date";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(62, 13);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Task Name";
            // 
            // taskName_textBox
            // 
            this.taskName_textBox.Location = new System.Drawing.Point(77, 35);
            this.taskName_textBox.Name = "taskName_textBox";
            this.taskName_textBox.Size = new System.Drawing.Size(197, 20);
            this.taskName_textBox.TabIndex = 17;
            // 
            // Form_task21_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 165);
            this.Controls.Add(this.secID_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.status_comboBox);
            this.Controls.Add(this.NumericUpDown1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.taskName_textBox);
            this.Name = "Form_task21_detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label secID_label;
        internal System.Windows.Forms.Button cancel_button;
        internal System.Windows.Forms.Button save_button;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox status_comboBox;
        internal System.Windows.Forms.NumericUpDown NumericUpDown1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox taskName_textBox;
    }
}