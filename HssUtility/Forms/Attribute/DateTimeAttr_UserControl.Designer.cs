namespace HssUtility.Forms.Attribute
{
    partial class DateTimeAttr_UserControl
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
            this.value_dateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            // value_dateTimePicker
            // 
            this.value_dateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.value_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.value_dateTimePicker.Location = new System.Drawing.Point(7, 21);
            this.value_dateTimePicker.Name = "value_dateTimePicker";
            this.value_dateTimePicker.Size = new System.Drawing.Size(175, 20);
            this.value_dateTimePicker.TabIndex = 1;
            this.value_dateTimePicker.Value = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.value_dateTimePicker.ValueChanged += new System.EventHandler(this.value_dateTimePicker_ValueChanged);
            // 
            // DateTimeAttr_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.value_dateTimePicker);
            this.Controls.Add(this.name_label);
            this.Name = "DateTimeAttr_UserControl";
            this.Size = new System.Drawing.Size(185, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.DateTimePicker value_dateTimePicker;
    }
}
