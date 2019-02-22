using System;
using System.Collections.Generic;

using HssUtility.General.Attributes;
using HssDARWIN.Models.XBRL.DvdXBRL;
using HssDARWIN.Models.Log;

namespace HssDARWIN.Models.Dividends
{
    public partial class Dividend
    {
        public bool IsCompleteEvent_flag
        {
            get
            {
                List<DividendXBRL> dx_list = this.Get_dividendXBRL_list();
                foreach (DividendXBRL dx in dx_list)
                {
                    if (dx.Event_Completeness.IsValueEmpty) continue;
                    if (dx.Event_Completeness.Value.StartsWith("Complete", StringComparison.OrdinalIgnoreCase)) return true;
                }

                return false;
            }
        }

        /*---------------------------------------Insert History and Queue----------------------------------------------------*/
        public List<Audit_History> XBRL_Get_auditHistory()
        {
            this.Create_attrDic();
            List<Audit_History> list = new List<Audit_History>();

            foreach (KeyValuePair<string, I_modelAttr> pair in this.attr_dic)
            {
                if (!pair.Value.ValueChanged) continue;

                Audit_History ah = new Audit_History();
                ah.Type.Value = "U";
                ah.TableName.Value = DividendTable_option.Dividend_Control_Approved.ToString();

                ah.PKName.Value = "DividendIndex";
                ah.FieldName.Value = pair.Key;
                ah.NewValue.Value = pair.Value.GetValue_in_string(0);

                ah.UpdateDate.Value = DateTime.Now;
                ah.UserName.Value = Utility.CurrentUser;
                ah.ParID.Value = 9000;

                string tempTP_str = pair.Value.GetRawValueType().ToString();
                int startIndex = tempTP_str.LastIndexOf('.');
                if (startIndex >= 0) tempTP_str = tempTP_str.Substring(startIndex + 1);
                ah.DataType.Value = tempTP_str;

                list.Add(ah);
            }

            return list;
        }

        public List<Dividend_Control_Queue> XBRL_Get_controlQueue()
        {
            this.Create_attrDic();
            List<Dividend_Control_Queue> list = new List<Dividend_Control_Queue>();

            foreach (KeyValuePair<string, I_modelAttr> pair in this.attr_dic)
            {
                if (!pair.Value.ValueChanged) continue;

                Dividend_Control_Queue dcq = new Dividend_Control_Queue();
                dcq.Init_from_attr(pair.Key, pair.Value);
                list.Add(dcq);
            }

            return list;
        }
    }
}
