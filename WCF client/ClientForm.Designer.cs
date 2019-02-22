namespace WCF_client
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
            this.conn_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conn_button
            // 
            this.conn_button.Location = new System.Drawing.Point(26, 34);
            this.conn_button.Name = "conn_button";
            this.conn_button.Size = new System.Drawing.Size(75, 23);
            this.conn_button.TabIndex = 0;
            this.conn_button.Text = "Connect";
            this.conn_button.UseVisualStyleBackColor = true;
            this.conn_button.Click += new System.EventHandler(this.conn_button_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.conn_button);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button conn_button;
    }
}

