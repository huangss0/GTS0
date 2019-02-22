using System;
using System.Text;
using HssUtility.General;

namespace HssDARWIN.SubProjects.ElectionFile
{
    public class Election_item
    {
        public int Election_Option_Number = -1;
        public string Election_Option_Type = "CASH";
        public decimal WithholdingTaxRate = 0;
        public decimal ADRQuantity = 0, ORDQuantity = 0;

        public Election_item() { }
        public Election_item(int optNum, decimal WHRate, string eleName)
        {
            this.Election_Option_Number = optNum;
            this.WithholdingTaxRate = WHRate;
            this.elementName = eleName;
        }

        public string GetXML()
        {
            StringBuilder sb = new StringBuilder("<" + this.elementName + ">").Append(HssStr.WinNextLine);

            sb.Append("<Election_Option_Number>").Append(this.Election_Option_Number).Append("</Election_Option_Number>").Append(HssStr.WinNextLine);
            sb.Append("<Election_Option_Type>").Append(this.Election_Option_Type).Append("</Election_Option_Type>").Append(HssStr.WinNextLine);
            sb.Append("<WithholdingTaxRate>").Append(this.WithholdingTaxRate).Append("</WithholdingTaxRate>").Append(HssStr.WinNextLine);
            sb.Append("<ADRQuantity>").Append((int)this.ADRQuantity).Append("</ADRQuantity>").Append(HssStr.WinNextLine);
            sb.Append("<ORDQuantity>").Append((int)this.ORDQuantity).Append("</ORDQuantity>").Append(HssStr.WinNextLine);

            sb.Append("</" + this.elementName + ">").Append(HssStr.WinNextLine);

            return sb.ToString();
        }

        public string elementName = "eleName";
    }
}
