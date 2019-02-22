using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.Tasks.Task20
{
    public class Task_Detail_20D : Task_Detail
    {
        public const int Overdue_days = 30;
        public Task_Detail_20D()
        {
            base.TaskID.Value = Task20_master.TaskID_20;
            base.SourceTable.Value = "FX_Input";
            base.TaskName.Value = "D";
        }
    }
}
