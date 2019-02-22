namespace HssDARWIN.SubProjects.Daily_Jobs
{
    partial class DailyJobs_form
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
            this.main_ultraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // main_ultraGrid
            // 
            this.main_ultraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle;
            this.main_ultraGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_ultraGrid.Location = new System.Drawing.Point(0, 0);
            this.main_ultraGrid.Name = "main_ultraGrid";
            this.main_ultraGrid.Size = new System.Drawing.Size(1021, 274);
            this.main_ultraGrid.TabIndex = 1;
            this.main_ultraGrid.TabStop = false;
            this.main_ultraGrid.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.main_ultraGrid_ClickCellButton);
            // 
            // DailyJobs_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 274);
            this.Controls.Add(this.main_ultraGrid);
            this.Name = "DailyJobs_form";
            this.Text = "DailyJobs_form";
            this.Load += new System.EventHandler(this.DailyJobs_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main_ultraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid main_ultraGrid;
    }
}