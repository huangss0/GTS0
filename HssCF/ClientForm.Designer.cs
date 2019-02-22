namespace HssCF
{
    partial class ClientForm
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
                if (this.senderSK != null)
                {
                    //this.senderSK.Disconnect(false);
                    this.senderSK.Close();
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
            this.IP_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.port_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msg_toSend_textBox = new System.Windows.Forms.TextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.info_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.port_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // IP_textBox
            // 
            this.IP_textBox.Location = new System.Drawing.Point(43, 12);
            this.IP_textBox.Name = "IP_textBox";
            this.IP_textBox.Size = new System.Drawing.Size(100, 20);
            this.IP_textBox.TabIndex = 0;
            this.IP_textBox.TabStop = false;
            this.IP_textBox.Text = "10.0.7.79";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // port_numericUpDown
            // 
            this.port_numericUpDown.Location = new System.Drawing.Point(208, 13);
            this.port_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port_numericUpDown.Name = "port_numericUpDown";
            this.port_numericUpDown.Size = new System.Drawing.Size(100, 20);
            this.port_numericUpDown.TabIndex = 2;
            this.port_numericUpDown.TabStop = false;
            this.port_numericUpDown.Value = new decimal(new int[] {
            1234,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Message";
            // 
            // msg_toSend_textBox
            // 
            this.msg_toSend_textBox.Location = new System.Drawing.Point(20, 56);
            this.msg_toSend_textBox.Name = "msg_toSend_textBox";
            this.msg_toSend_textBox.Size = new System.Drawing.Size(314, 20);
            this.msg_toSend_textBox.TabIndex = 5;
            this.msg_toSend_textBox.TabStop = false;
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(340, 54);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 2;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(340, 10);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 23);
            this.connect_button.TabIndex = 1;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // info_textBox
            // 
            this.info_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_textBox.Location = new System.Drawing.Point(20, 92);
            this.info_textBox.Multiline = true;
            this.info_textBox.Name = "info_textBox";
            this.info_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.info_textBox.Size = new System.Drawing.Size(525, 270);
            this.info_textBox.TabIndex = 6;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 374);
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.msg_toSend_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.port_numericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IP_textBox);
            this.Name = "ClientForm";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.port_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown port_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox msg_toSend_textBox;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.TextBox info_textBox;
    }
}