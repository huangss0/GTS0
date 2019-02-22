using System;
using System.Collections.Generic;
using System.Text;
using HssUtility.Service.JSON;

namespace HssUtility.Service.HssCF
{
    public class HssCF_cmd : I_JSONful
    {
        public const int version = 1;
        public bool showVersion = false;

        public string funcName = null;
        
        public Obj_dest objState = Obj_dest.None;
        public CmdStatus status = CmdStatus.None;
        
        public int objLen = -1;

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
            if ((val_obj = jsObj["funcName"]) != null) this.funcName = val_obj.str_val;
            if ((val_obj = jsObj["objLen"]) != null) this.objLen = (int)val_obj.num_val;
            if ((val_obj = jsObj["objState"]) != null)
            {
                if (val_obj.str_val.Equals("ToServer", StringComparison.OrdinalIgnoreCase)) this.objState = Obj_dest.ToServer;
                else if (val_obj.str_val.Equals("ToClient", StringComparison.OrdinalIgnoreCase)) this.objState = Obj_dest.ToClient;
            }
            if ((val_obj = jsObj["status"]) != null)
            {
                if (val_obj.str_val.Equals("OK", StringComparison.OrdinalIgnoreCase)) this.status = CmdStatus.OK;
                else if (val_obj.str_val.Equals("Received", StringComparison.OrdinalIgnoreCase)) this.status = CmdStatus.Received;
                else if (val_obj.str_val.Equals("Reject", StringComparison.OrdinalIgnoreCase)) this.status = CmdStatus.Reject;
            }

            return true;
        }

        public string Convert_to_str()
        {
            return "HssCF_cmd " + this.Convert_to_JSON().Convert_to_str();
        }

        public JSON_obj Convert_to_JSON()
        {
            JSON_obj jsObj = new JSON_obj();
            if (this.showVersion) jsObj.AddAttr("version", HssCF_cmd.version);

            if (!string.IsNullOrEmpty(this.funcName)) jsObj.AddAttr("funcName", this.funcName);
            
            if (this.objState != Obj_dest.None) jsObj.AddAttr("objState", this.objState.ToString());
            if (this.status != CmdStatus.None) jsObj.AddAttr("status", this.status.ToString());

            if (this.objLen > 0) jsObj.AddAttr("objLen", this.objLen);

            return jsObj;
        }

        public void Reset()
        {
            this.showVersion = false;
            this.funcName = null;
            this.objLen = 0;
            this.objState = Obj_dest.None;
            this.status = CmdStatus.None;
        }
    }

    /// <summary>
    /// Destination of the object to be sent
    /// </summary>
    public enum Obj_dest
    {
        None = 0,

        ToServer = 1,
        ToClient = 2,
    }

    public enum CmdStatus
    {
        None = 0,

        OK = 1,
        Received = 2,
        Reject = 3,
    }
}
