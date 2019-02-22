namespace HssUtility.Forms.Filter
{
    partial class Filter_UserControl
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
            this.col_comboBox = new System.Windows.Forms.ComboBox();
            this.opt_comboBox = new System.Windows.Forms.ComboBox();
            this.value_textBox = new System.Windows.Forms.TextBox();
            this.value_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // col_comboBox
            // 
            this.col_comboBox.FormattingEnabled = true;
            this.col_comboBox.Location = new System.Drawing.Point(3, 3);
            this.col_comboBox.Name = "col_comboBox";
            this.col_comboBox.Size = new System.Drawing.Size(170, 21);
            this.col_comboBox.TabIndex = 0;
            this.col_comboBox.SelectedIndexChanged += new System.EventHandler(this.col_comboBox_SelectedIndexChanged);
            // 
            // opt_comboBox
            // 
            this.opt_comboBox.FormattingEnabled = true;
            this.opt_comboBox.Items.AddRange(new object[] {
            "=",
            "!=",
            ">=",
            "<=",
            ">",
            "<"});
            this.opt_comboBox.Location = new System.Drawing.Point(179, 3);
            this.opt_comboBox.Name = "opt_comboBox";
            this.opt_comboBox.Size = new System.Drawing.Size(64, 21);
            this.opt_comboBox.TabIndex = 1;
            this.opt_comboBox.Text = "=";
            // 
            // value_textBox
            // 
            this.value_textBox.Location = new System.Drawing.Point(250, 3);
            this.value_textBox.Name = "value_textBox";
            this.value_textBox.Size = new System.Drawing.Size(268, 20);
            this.value_textBox.TabIndex = 2;
            this.value_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.value_textBox_KeyPress);
            this.value_textBox.Leave += new System.EventHandler(this.value_textBox_Leave);
            // 
            // value_dateTimePicker
            // 
            this.value_dateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.value_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.value_dateTimePicker.Location = new System.Drawing.Point(249, 29);
            this.value_dateTimePicker.Name = "value_dateTimePicker";
            this.value_dateTimePicker.Size = new System.Drawing.Size(268, 20);
            this.value_dateTimePicker.TabIndex = 3;
            this.value_dateTimePicker.Visible = false;
            // 
            // Filter_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.value_dateTimePicker);
            this.Controls.Add(this.value_textBox);
            this.Controls.Add(this.opt_comboBox);
            this.Controls.Add(this.col_comboBox);
            this.Name = "Filter_UserControl";
            this.Size = new System.Drawing.Size(520, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox col_comboBox;
        private System.Windows.Forms.ComboBox opt_comboBox;
        private System.Windows.Forms.TextBox value_textBox;
        private System.Windows.Forms.DateTimePicker value_dateTimePicker;
    }
}
