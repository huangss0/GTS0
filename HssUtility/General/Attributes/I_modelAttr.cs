using System;

namespace HssUtility.General.Attributes
{
    public interface I_modelAttr
    {
        bool ValueChanged { get; }
        void SyncWithDB();
        bool IsNull_flag { get; set; }

        /// <summary>
        /// Get the value of attr in string
        /// </summary>
        /// <param name="option">0 as default</param>
        string GetValue_in_string(int option);

        Type GetRawValueType();
    }
}
