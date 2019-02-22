namespace HssUtility.Forms.Attribute
{
    partial class StrAttr_UserControl
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
            this.name_label = new System.Windows.Forms.Label();
            this.value_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(4, 4);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(38, 13);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name:";
            // 
            // value_textBox
            // 
            this.value_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.value_textBox.Location = new System.Drawing.Point(4, 21);
            this.value_textBox.Name = "value_textBox";
            this.value_textBox.Size = new System.Drawing.Size(178, 20);
            this.value_textBox.TabIndex = 1;
            this.value_textBox.TabStop = false;
            this.value_textBox.TextChanged += new System.EventHandler(this.value_textBox_TextChanged);
            this.value_textBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.value_textBox_MouseDoubleClick);
            // 
            // StrAttr_UserControl
            // 
            this.Controls.Add(this.value_textBox);
            this.Controls.Add(this.name_label);
            this.Name = "StrAttr_UserControl";
            this.Size = new System.Drawing.Size(185, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox value_textBox;
    }
}
