using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace HssUtility.Service.HssCF
{
    public class HssCF_helper
    {
        public const int Default_bufferSize = 1024;
        public const int Max_bufferSize = 64000;

        public static string Read_str_from_socket(Socket rmSocket, int strLen = HssCF_helper.Default_bufferSize)
        {
            if (rmSocket == null || !rmSocket.Connected) return null;

            if (strLen < 0) strLen = HssCF_helper.Default_bufferSize;
            int recLen = 0;

            if (strLen <= HssCF_helper.Max_bufferSize)
            {
                byte[] buffer = new byte[strLen];

                try { recLen = rmSocket.Receive(buffer); }
                catch { return null; }

                string str = Encoding.UTF8.GetString(buffer, 0, recLen);
                return str;
            }
            else
            {
                byte[] resBytes = new byte[strLen], tempArr = new byte[HssCF_helper.Max_bufferSize];

                try
                {
                    do
                    {
                        int tempCT = rmSocket.Receive(tempArr);
                        for (int i = 0; i < tempCT; ++i) resBytes[recLen + i] = tempArr[i];
                        recLen += tempCT;

                    } while (recLen < strLen);
                }
                catch { return null; }

                string str = Encoding.UTF8.GetString(resBytes, 0, strLen);
                //Console.WriteLine("HssCF_helper output 0: " + str);
                return str;
            }
        }

        public static HssCF_cmd Read_next_hCmd(Socket rmSocket)
        {
            HssCF_cmd recv_hCmd = new HssCF_cmd();
            recv_hCmd.Read_from_str(HssCF_helper.Read_str_from_socket(rmSocket));

            return recv_hCmd;
        }

        public static int Send_str_to_rmSocket(Socket rmSocket, string str)
        {
            if (rmSocket == null || !rmSocket.Connected) return -1;
            if (str == null) return -2;

            return rmSocket.Send(Encoding.UTF8.GetBytes(str));
        }

        public static int Send_obj_to_rmSocket(Socket rmSocket, I_RESTful obj)
        {
            if (obj == null) return -2;
            string str = obj.Convert_to_str();

            return HssCF_helper.Send_str_to_rmSocket(rmSocket, str);
        }
    }
}
