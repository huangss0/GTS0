using System;
using HssUtility.Service.JSON;

namespace HssUtility.Service.SampleObj
{
    class Order : I_JSONful
    {
        public int orderID = -1;
        public string buyer = null;
        public DateTime date = DateTime.MinValue;

        public bool Read_from_str(string str)
        {
            if (str == null) return false;
            else this.Reset();

            JSON_obj jsObj = new JSON_obj();
            if (!jsObj.Read_from_str(str)) return false;

            return this.Read_from_JSON(jsObj);
        }

        public bool Read_from_JSON(JSON_obj jsObj)
        {
            if (jsObj == null) return false;
            else this.Reset();

            JSON_obj val_obj = null;
            if ((val_obj = jsObj["orderID"]) != null) this.orderID = (int)val_obj.num_val;
            if ((val_obj = jsObj["buyer"]) != null) this.buyer = val_obj.str_val;
            if ((val_obj = jsObj["date"]) != null)
            {
                DateTime tempDT;
                if (DateTime.TryParse(val_obj.str_val, out tempDT)) this.date = tempDT;
            }

            return true;
        }

        public string Convert_to_str()
        {
            return "Order " + this.Convert_to_JSON().Convert_to_str();
        }

        public JSON_obj Convert_to_JSON()
        {
            JSON_obj jsObj = new JSON_obj();
            jsObj.AddAttr("orderID", this.orderID);
            if (!string.IsNullOrEmpty(this.buyer)) jsObj.AddAttr("buyer", this.buyer);
            if (!this.date.Equals(DateTime.MinValue)) jsObj.AddAttr("date", this.date.ToString());

            return jsObj;
        }

        public void Reset()
        {
            this.orderID = -1;
            this.buyer = null;
            this.date = DateTime.MinValue;
        }
    }
}
