using System.Collections.Generic;
using System.Text;
using HssUtility.Service.JSON;

namespace HssUtility.Service.SampleObj
{
    class People : I_JSONful
    {
        public int age = -1;
        public string name = null;
        public List<Order> orderList = new List<Order>();

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
            if ((val_obj = jsObj["age"]) != null) this.age = (int)val_obj.num_val;
            if ((val_obj = jsObj["name"]) != null) this.name = val_obj.str_val;
            if ((val_obj = jsObj["orderList"]) != null)
            {
                foreach (JSON_obj jo in val_obj.obj_list)
                {
                    Order od = new Order();
                    od.Read_from_JSON(jo);
                    this.orderList.Add(od);
                }
            }

            return true;
        }

        public string Convert_to_str()
        {
            return "People " + this.Convert_to_JSON().Convert_to_str();
        }

        public JSON_obj Convert_to_JSON()
        {
            JSON_obj jsObj = new JSON_obj();
            jsObj.AddAttr("age", this.age);
            if (!string.IsNullOrEmpty(this.name)) jsObj.AddAttr("name", this.name);

            List<JSON_obj> oList = new List<JSON_obj>();
            foreach (Order od in this.orderList) oList.Add(od.Convert_to_JSON());
            jsObj.AddAttr("orderList", oList);

            return jsObj;
        }

        public void Reset()
        {
            this.age = -1;
            this.name = null;
            this.orderList.Clear();
        }
    }
}
