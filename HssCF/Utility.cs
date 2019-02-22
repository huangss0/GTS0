using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssCF
{
    public class Utility
    {
        public const int DefaultBufferSize = 1024;

        public static byte[] GetBlankBuffer(int size = Utility.DefaultBufferSize)
        {
            if (size < 0) size = Utility.DefaultBufferSize;

            byte[] buffer = new byte[size];
            for (int i = 0; i < size; ++i) buffer[i] = 32;
            return buffer;


        }

        public static byte[] GetCommendBuffer(string cmd)
        {
            if (string.IsNullOrEmpty(cmd)) return null;

            byte[] res = Utility.GetBlankBuffer();
            byte[] info_bts = Encoding.UTF8.GetBytes(cmd);
                        if (info_bts.Length > res.Length)
            {
                Console.WriteLine("Utility error 0: buffer size not enough");
                return info_bts;
            }

            for (int i = 0; i < info_bts.Length; ++i) res[i] = info_bts[i];
            return res;
        }
    }
}
