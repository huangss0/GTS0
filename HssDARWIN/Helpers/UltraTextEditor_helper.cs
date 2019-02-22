using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Drawing;

using Infragistics.Win.UltraWinEditors;

namespace HssDARWIN.Helpers
{
    public class UltraTextEditor_helper
    {
        public static Dictionary<string, Image> img_dic = null;
        public const string DefaultImg = "Document";
        public static void Init_imgDic()
        {
            if (UltraTextEditor_helper.img_dic != null) return;

            UltraTextEditor_helper.img_dic = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);
            Assembly asb = Assembly.GetExecutingAssembly();

            Stream sm = asb.GetManifestResourceStream("HssDARWIN.Images.OK.ico");
            if (sm != null) UltraTextEditor_helper.img_dic["OK"] = new Bitmap(sm);
            sm = asb.GetManifestResourceStream("HssDARWIN.Images.Cancel.ico");
            if (sm != null) UltraTextEditor_helper.img_dic["Cancel"] = new Bitmap(sm);
            sm = asb.GetManifestResourceStream("HssDARWIN.Images.Document.ico");
            if (sm != null) UltraTextEditor_helper.img_dic[UltraTextEditor_helper.DefaultImg] = new Bitmap(sm);
            sm = asb.GetManifestResourceStream("HssDARWIN.Images.Restore.ico");
            if (sm != null) UltraTextEditor_helper.img_dic["Restore"] = new Bitmap(sm);
        }

        public static UltraTextEditor CreateTextEditorButtons(UltraTextEditor_setting setting)
        {
            UltraTextEditor ute = new UltraTextEditor();
            if (setting == null) return ute;

            int count = setting.Count;
            for(int i = 0; i< count;++i)
            {
                EditorButton btn = new EditorButton();
                btn.Text = setting.GetButtonName(i);
                btn.Key = setting.GetButtonName(i);
                btn.Appearance.Image = UltraTextEditor_helper.img_dic[setting.GetImageName(i)];
                btn.Appearance.ImageHAlign = Infragistics.Win.HAlign.Left;
                ute.ButtonsLeft.Add(btn);
            }

            return ute;
        }
    }

    public class UltraTextEditor_setting
    {
        private List<string> btnName_list = new List<string>();
        private List<string> imgName_list = new List<string>();

        public UltraTextEditor_setting() { UltraTextEditor_helper.Init_imgDic(); }

        public void AddButton(string button_name, string img_name = UltraTextEditor_helper.DefaultImg)
        {
            if (!UltraTextEditor_helper.img_dic.ContainsKey(img_name)) img_name = UltraTextEditor_helper.DefaultImg;

            this.btnName_list.Add(button_name);
            this.imgName_list.Add(img_name);
        }

        public int Count { get { return this.btnName_list.Count; } }

        public string GetButtonName(int id)
        {
            if (id < 0 || id >= this.btnName_list.Count) return null;
            else return this.btnName_list[id];
        }

        public string GetImageName(int id)
        {
            if (id < 0 || id >= this.imgName_list.Count) return null;
            else return this.imgName_list[id];
        }

        public void Reset()
        {
            this.btnName_list.Clear();
            this.imgName_list.Clear();
        }
    }
}
