using System.Windows.Forms;

namespace HssUtility.Forms.Attribute
{
    public class Abs_Attr_UserControl : UserControl
    {
        public const int AttrForm_Height = 48, AttrForm_Width = 158, FormMax_height = 1000;

        public virtual void Commit()
        {
            //Need to ba abstract class and method
            //But set as virtual for editable on Designer
        }

        public virtual void Refresh_Data() { }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Abs_Attr_UserControl
            // 
            this.Name = "Abs_Attr_UserControl";
            this.Size = new System.Drawing.Size(185, 48);
            this.ResumeLayout(false);
        }
    }
}
