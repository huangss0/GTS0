using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HssUtility.Forms.Attribute
{
    public partial class Models_viewForm : Form
    {
        public Models_viewForm()
        {
            this.InitializeComponent();
        }

        /*----------------------------------------------------------------------------------------------------------*/
        public Utility.Bool_NoParams_delegate SaveModel_func = Utility.Bool_NoParams_emptyFunc;
        public Utility.Void_NoParams_delegate Refresh_parentUI = Utility.Void_NoParams_emptyFunc;
        public bool CloseOnSave_flag = false;

        private List<Abs_Attr_UserControl> control_list = new List<Abs_Attr_UserControl>();

        public void Add_Control(Abs_Attr_UserControl uc)
        {
            if (uc == null) return;
            this.main_flowtPanel.Controls.Add(uc);
            this.control_list.Add(uc);
        }

        public void Set_pk_label(string s) { this.PK_label.Text = s; }

        public void Refresh_Data()
        {
            foreach (Abs_Attr_UserControl ac in control_list) ac.Refresh_Data();
            this.Refresh_parentUI();
        }

        /*-----------------------------------------------------------------------------------------------------------*/

        public new void Show()
        {
            this.Auto_set_size();
            base.Show();
        }

        public new void ShowDialog()
        {
            this.Auto_set_size();
            base.ShowDialog();
        }

        private void Auto_set_size()
        {
            int height_diff = this.Height - this.main_flowtPanel.Height;

            int rows = this.control_list.Count / 3;
            if (this.control_list.Count % 3 > 0) ++rows;

            int newHeight = height_diff + rows * (Abs_Attr_UserControl.AttrForm_Height + this.main_flowtPanel.Margin.Vertical);
            if (newHeight > this.Height) this.Height = newHeight > Abs_Attr_UserControl.FormMax_height ? Abs_Attr_UserControl.FormMax_height : newHeight;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        private void save_button_Click(object sender, EventArgs e)
        {
            foreach (Abs_Attr_UserControl auc in this.control_list) auc.Commit();

            if (this.SaveModel_func())
            {
                MessageBox.Show("Data Saved");
                this.Refresh_Data();
            }
            else MessageBox.Show("No changes made");

            if (this.CloseOnSave_flag) this.Close();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
