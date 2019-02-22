using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssUtility.DataSource.FTP.Native
{
    public class FTP_response
    {
        public readonly int statusCode = 0;
        public readonly string message = null;

        public FTP_response(string msg)
        {
            if (string.IsNullOrEmpty(msg)) return;

            Stack<int> st = new Stack<int>();

            for (int i = 0; i < msg.Length; ++i)
            {
                char c = msg[i];
                if (c >= '0' && c <= '9') st.Push(c - '0');                
                else if (st.Count > 0) break;
            }

            int temp = 0, base10 = 1;
            while (st.Count > 0)
            {
                temp += base10 * st.Pop();
                base10 *= 10;
            }

            this.statusCode = temp;
            this.message = msg;
        }
    }
}