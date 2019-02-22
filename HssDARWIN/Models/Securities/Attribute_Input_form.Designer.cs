namespace HssDARWIN.Models.Securities
{
    partial class Attribute_Input_form
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
            this.info_label = new System.Windows.Forms.Label();
            this.values_comboBox = new System.Windows.Forms.ComboBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.sec_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(13, 12);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(180, 13);
            this.info_label.TabIndex = 0;
            this.info_label.Text = "Please input Attribute for this security";
            // 
            // values_comboBox
            // 
            this.values_comboBox.FormattingEnabled = true;
            this.values_comboBox.Location = new System.Drawing.Point(16, 54);
            this.values_comboBox.Name = "values_comboBox";
            this.values_comboBox.Size = new System.Drawing.Size(196, 21);
            this.values_comboBox.TabIndex = 1;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(16, 90);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button.Location = new System.Drawing.Point(311, 90);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // sec_label
            // 
            this.sec_label.AutoSize = true;
            this.sec_label.Location = new System.Drawing.Point(13, 30);
            this.sec_label.Name = "sec_label";
            this.sec_label.Size = new System.Drawing.Size(120, 13);
            this.sec_label.TabIndex = 4;
            this.sec_label.Text = "Security Name: (CUSIP)";
            // 
            // Attribute_Input_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 124);
            this.Controls.Add(this.sec_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.values_comboBox);
            this.Controls.Add(this.info_label);
            this.Name = "Attribute_Input_form";
            this.Text = "TickerInput_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.ComboBox values_comboBox;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label sec_label;
    }
}