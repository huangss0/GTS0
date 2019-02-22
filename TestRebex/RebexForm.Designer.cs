namespace TestRebex
{
    partial class RebexForm
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("", -1);
            this.show_button = new System.Windows.Forms.Button();
            this.server_textBox = new System.Windows.Forms.TextBox();
            this.user_textBox = new System.Windows.Forms.TextBox();
            this.pwd_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.main_ultraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.upload_button = new System.Windows.Forms.Button();
            this.conn_button = new System.Windows.Forms.Button();
            this.info_textBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(343, 37);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(108, 23);
            this.show_button.TabIndex = 10;
            this.show_button.Text = "Show Files";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // server_textBox
            // 
            this.server_textBox.Location = new System.Drawing.Point(64, 12);
            this.server_textBox.Name = "server_textBox";
            this.server_textBox.Size = new System.Drawing.Size(202, 20);
            this.server_textBox.TabIndex = 1;
            this.server_textBox.Text = "127.0.0.1";
            // 
            // user_textBox
            // 
            this.user_textBox.Location = new System.Drawing.Point(64, 39);
            this.user_textBox.Name = "user_textBox";
            this.user_textBox.Size = new System.Drawing.Size(202, 20);
            this.user_textBox.TabIndex = 2;
            this.user_textBox.Text = "SHuang";
            // 
            // pwd_textBox
            // 
            this.pwd_textBox.Location = new System.Drawing.Point(64, 66);
            this.pwd_textBox.Name = "pwd_textBox";
            this.pwd_textBox.Size = new System.Drawing.Size(202, 20);
            this.pwd_textBox.TabIndex = 3;
            this.pwd_textBox.Text = "Gts.143%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User";
            // 
            // main_ultraGrid
            // 
            this.main_ultraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            ultraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.main_ultraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.main_ultraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.main_ultraGrid.Location = new System.Drawing.Point(12, 92);
            this.main_ultraGrid.Name = "main_ultraGrid";
            this.main_ultraGrid.Size = new System.Drawing.Size(470, 295);
            this.main_ultraGrid.TabIndex = 5;
            this.main_ultraGrid.Text = "Info";
            this.main_ultraGrid.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.main_ultraGrid_InitializeLayout);
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(343, 64);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(108, 23);
            this.upload_button.TabIndex = 6;
            this.upload_button.Text = "Upload File";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // conn_button
            // 
            this.conn_button.Location = new System.Drawing.Point(343, 10);
            this.conn_button.Name = "conn_button";
            this.conn_button.Size = new System.Drawing.Size(108, 23);
            this.conn_button.TabIndex = 0;
            this.conn_button.Text = "Connect";
            this.conn_button.UseVisualStyleBackColor = true;
            this.conn_button.Click += new System.EventHandler(this.conn_button_Click);
            // 
            // info_textBox
            // 
            this.info_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_textBox.Location = new System.Drawing.Point(12, 393);
            this.info_textBox.Multiline = true;
            this.info_textBox.Name = "info_textBox";
            this.info_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.info_textBox.Size = new System.Drawing.Size(470, 226);
            this.info_textBox.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 631);
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.conn_button);
            this.Controls.Add(this.upload_button);
            this.Controls.Add(this.main_ultraGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwd_textBox);
            this.Controls.Add(this.user_textBox);
            this.Controls.Add(this.server_textBox);
            this.Controls.Add(this.show_button);
            this.Name = "MainForm";
            this.Text = "Rebex Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.TextBox server_textBox;
        private System.Windows.Forms.TextBox user_textBox;
        private System.Windows.Forms.TextBox pwd_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Infragistics.Win.UltraWinGrid.UltraGrid main_ultraGrid;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.Button conn_button;
        private System.Windows.Forms.TextBox info_textBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

