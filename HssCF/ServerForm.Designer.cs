namespace HssCF
{
    partial class ServerForm
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
            if (disposing)
            {
                if (this.serverSK != null)
                {
                    this.serverSK.Close();
                }
            }

            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.start_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.port_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.info_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filePath_textBox = new System.Windows.Forms.TextBox();
            this.open_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.port_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(197, 13);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 4;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port:";
            // 
            // port_numericUpDown
            // 
            this.port_numericUpDown.Location = new System.Drawing.Point(43, 13);
            this.port_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port_numericUpDown.Name = "port_numericUpDown";
            this.port_numericUpDown.Size = new System.Drawing.Size(100, 20);
            this.port_numericUpDown.TabIndex = 5;
            this.port_numericUpDown.TabStop = false;
            this.port_numericUpDown.Value = new decimal(new int[] {
            1234,
            0,
            0,
            0});
            // 
            // info_textBox
            // 
            this.info_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_textBox.Location = new System.Drawing.Point(12, 65);
            this.info_textBox.Multiline = true;
            this.info_textBox.Name = "info_textBox";
            this.info_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.info_textBox.Size = new System.Drawing.Size(406, 221);
            this.info_textBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Info:";
            // 
            // filePath_textBox
            // 
            this.filePath_textBox.Location = new System.Drawing.Point(15, 302);
            this.filePath_textBox.Name = "filePath_textBox";
            this.filePath_textBox.Size = new System.Drawing.Size(322, 20);
            this.filePath_textBox.TabIndex = 9;
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(343, 299);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(75, 23);
            this.open_button.TabIndex = 10;
            this.open_button.Text = "Open";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 334);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.filePath_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.port_numericUpDown);
            this.Name = "ServerForm";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.port_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown port_numericUpDown;
        private System.Windows.Forms.TextBox info_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePath_textBox;
        private System.Windows.Forms.Button open_button;
    }
}