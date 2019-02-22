namespace HssUtility.Forms.Attribute
{
    partial class BoolAttr_UserControl
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
            this.value_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // value_checkBox
            // 
            this.value_checkBox.AutoSize = true;
            this.value_checkBox.Location = new System.Drawing.Point(3, 22);
            this.value_checkBox.Name = "value_checkBox";
            this.value_checkBox.Size = new System.Drawing.Size(107, 17);
            this.value_checkBox.TabIndex = 1;
            this.value_checkBox.Text = "Boolean Attribute";
            this.value_checkBox.UseVisualStyleBackColor = true;
            this.value_checkBox.CheckedChanged += new System.EventHandler(this.value_checkBox_CheckedChanged);
            // 
            // BoolAttr_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.value_checkBox);
            this.Name = "BoolAttr_UserControl";
            this.Size = new System.Drawing.Size(185, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox value_checkBox;
    }
}
