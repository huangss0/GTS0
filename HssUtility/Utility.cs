using System;

using HssUtility.SQLserver;

namespace HssUtility
{
    public class Utility
    {
        public static readonly DateTime MinDate = new DateTime(1800, 1, 1);

        public delegate void Void_NoParams_delegate();
        public static void Void_NoParams_emptyFunc() { /*Empty function for default delegate*/ }

        public delegate bool Bool_NoParams_delegate();
        public static bool Bool_NoParams_emptyFunc() { return false; }

        public delegate void Void_IntParams_delegate(int val);
        public static void Void_IntParams_emptyFunc(int val) { /*Empty function for default delegate*/ }

        public delegate bool Bool_hdbParams_delegate(hssDB hDB);
        public static bool Bool_hdbParams_emptyFunc(hssDB hdb) { return false; }
    }
}
