using System;
using System.Diagnostics;

namespace HssUtility.General
{
    public class HssThreading
    {
        public static Process GetProcess_PID(int pid)
        {
            Process pc = null;
            try { pc = Process.GetProcessById(pid); }
            catch { return null; }
            return pc;
        }
    }

    public interface I_runable
    {
        void Run();
    }
}
