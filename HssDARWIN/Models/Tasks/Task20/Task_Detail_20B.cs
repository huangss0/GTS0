using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.Tasks.Task20
{
    public class Task_Detail_20B : Task_Detail
    {
        public Task_Detail_20B()
        {
            base.TaskID.Value = Task20_master.TaskID_20;
            base.SourceTable.Value = "FX_Input";
            base.TaskName.Value = "B";
        }
    }
}
