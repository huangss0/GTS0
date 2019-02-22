using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HssDARWIN.SubProjects.Daily_Jobs;

namespace HssDRWIN_DailyJobs_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Hss");
            InboundData3_SPR id3s = new InboundData3_SPR();
            id3s.Run();
        }
    }
}
