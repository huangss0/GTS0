using System;
using System.Windows.Forms;

namespace HssDARWIN.Helpers
{
    public class WinControl_helper
    {
        public static void SetItemsChecked(CheckedListBox listBox, bool isChecked)
        {
            if (listBox == null) return;
            for (int i = 0; i < listBox.Items.Count; ++i) listBox.SetItemChecked(i, isChecked);
        }
    }
}
