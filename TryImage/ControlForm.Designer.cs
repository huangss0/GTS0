namespace TryImage
{
    partial class ControlForm
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
            this.run_button = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.red_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.green_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blue_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gaussian_button = new System.Windows.Forms.Button();
            this.gausGray_checkBox = new System.Windows.Forms.CheckBox();
            this.test_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.red_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(13, 13);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(75, 23);
            this.run_button.TabIndex = 0;
            this.run_button.Text = "Gray Scale";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.gray_button_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // red_numericUpDown
            // 
            this.red_numericUpDown.Location = new System.Drawing.Point(137, 14);
            this.red_numericUpDown.Name = "red_numericUpDown";
            this.red_numericUpDown.Size = new System.Drawing.Size(60, 20);
            this.red_numericUpDown.TabIndex = 2;
            this.red_numericUpDown.TabStop = false;
            this.red_numericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // green_numericUpDown
            // 
            this.green_numericUpDown.Location = new System.Drawing.Point(238, 14);
            this.green_numericUpDown.Name = "green_numericUpDown";
            this.green_numericUpDown.Size = new System.Drawing.Size(60, 20);
            this.green_numericUpDown.TabIndex = 2;
            this.green_numericUpDown.TabStop = false;
            this.green_numericUpDown.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // blue_numericUpDown
            // 
            this.blue_numericUpDown.Location = new System.Drawing.Point(340, 14);
            this.blue_numericUpDown.Name = "blue_numericUpDown";
            this.blue_numericUpDown.Size = new System.Drawing.Size(60, 20);
            this.blue_numericUpDown.TabIndex = 2;
            this.blue_numericUpDown.TabStop = false;
            this.blue_numericUpDown.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "R:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "G:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "B:";
            // 
            // gaussian_button
            // 
            this.gaussian_button.Location = new System.Drawing.Point(13, 53);
            this.gaussian_button.Name = "gaussian_button";
            this.gaussian_button.Size = new System.Drawing.Size(75, 23);
            this.gaussian_button.TabIndex = 1;
            this.gaussian_button.Text = "Gaussian Filter";
            this.gaussian_button.UseVisualStyleBackColor = true;
            this.gaussian_button.Click += new System.EventHandler(this.gaussian_button_Click);
            // 
            // gausGray_checkBox
            // 
            this.gausGray_checkBox.AutoSize = true;
            this.gausGray_checkBox.Location = new System.Drawing.Point(94, 57);
            this.gausGray_checkBox.Name = "gausGray_checkBox";
            this.gausGray_checkBox.Size = new System.Drawing.Size(78, 17);
            this.gausGray_checkBox.TabIndex = 4;
            this.gausGray_checkBox.Text = "Gray Scale";
            this.gausGray_checkBox.UseVisualStyleBackColor = true;
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(340, 99);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(75, 23);
            this.test_button.TabIndex = 5;
            this.test_button.Text = "Test";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 134);
            this.Controls.Add(this.test_button);
            this.Controls.Add(this.gausGray_checkBox);
            this.Controls.Add(this.gaussian_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blue_numericUpDown);
            this.Controls.Add(this.green_numericUpDown);
            this.Controls.Add(this.red_numericUpDown);
            this.Controls.Add(this.run_button);
            this.Name = "ControlForm";
            this.Text = "Control Form";
            ((System.ComponentModel.ISupportInitialize)(this.red_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.NumericUpDown red_numericUpDown;
        private System.Windows.Forms.NumericUpDown green_numericUpDown;
        private System.Windows.Forms.NumericUpDown blue_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gaussian_button;
        private System.Windows.Forms.CheckBox gausGray_checkBox;
        private System.Windows.Forms.Button test_button;
    }
}

