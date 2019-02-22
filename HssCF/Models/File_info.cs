using System;
using HssUtility.Text.XML;

namespace HssCF.Models
{
    public class File_info
    {
        public string name = null;
        public int length = 0;

        public File_info() { }

        public File_info(string name, int len)
        {
            this.name = name;
            this.length = len;
        }

        public string ToXML()
        {
            Hss_XML_obj xo = new Hss_XML_obj("File_info");
            xo.Add_attr("name", this.name);
            xo.Add_attr("length", this.length.ToString());
            return xo.ToXML();
        }

        public void FromXML(string xml)
        {
            Hss_XML_reader reader = new Hss_XML_reader();
            Hss_XML_obj xo = reader.Read(xml);

            if (xo == null) return;
            else xo = xo.Get_obj("File_info");

            if (xo == null) return;

            this.name = xo.Get_attr("name");

            int tempInt = 0;
            string tempStr = xo.Get_attr("length");
            if (int.TryParse(tempStr, out tempInt)) this.length = tempInt;
        }
    }
}
