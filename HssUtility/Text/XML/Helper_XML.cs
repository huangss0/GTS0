using System;
using System.Globalization;

namespace HssUtility.Text.XML
{
    public class Helper_XML
    {
        public static int Get_int(Hss_XML_obj xo, int defaultValue = 0)
        {
            if (xo == null) return defaultValue;

            string strVal = xo.value;
            int val = defaultValue;

            if (int.TryParse(strVal, out val)) return val;
            else return defaultValue;
        }

        public static decimal Get_decimal(Hss_XML_obj xo, decimal defaultValue = 0)
        {
            if (xo == null) return defaultValue;

            string strVal = xo.value;
            decimal val = defaultValue;

            if (decimal.TryParse(strVal, out val)) return val;
            else return defaultValue;
        }

        public static bool Get_bool(Hss_XML_obj xo)
        {
            if (xo == null) return false;

            string strVal = xo.value;
            if (string.IsNullOrEmpty(strVal)) return false;
            else
            {
                strVal = strVal.Trim();
                return strVal.Equals("True", StringComparison.OrdinalIgnoreCase);
            }
        }

        public static DateTime Get_datetime(Hss_XML_obj xo, string format, DateTime defaultValue)
        {
            if (xo == null) return defaultValue;
            string strVal = xo.value;
            DateTime val = DateTime.MinValue;

            if (string.IsNullOrEmpty(format))
            {
                if (DateTime.TryParse(strVal, out val)) return val;
            }
            else
            {
                if (DateTime.TryParseExact(strVal, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out val))
                    return val;                
            }
            
            return defaultValue;
        }
    }

    public enum XML_ParseState
    {
        OutElement,
        InElement,

        ElementStart,
        ElementEnd,

        ElementName,
        ElementValue,

        AttrName,
        AfterAttrName,
        AttrValue,

        CommentValue,
    }

    public enum XML_ElementType
    {
        None,

        Normal,
        Declare,
        Comment,
    }
}
