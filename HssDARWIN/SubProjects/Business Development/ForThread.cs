using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

using HssDARWIN.Helpers;
using HssUtility.Debug;
using HssUtility.Text;

namespace HssDARWIN.SubProjects.Business_Development
{
    public class ForThread
    {
        public HssThreadInfo_log statusInfo = new HssThreadInfo_log();
        public string exportPath = null;
        public string xlTemplatePath = @"C:\steven\DrwinMain2017\DRWIN_APP\MAIN-Steven\HssUtility\Ref_DLLs\XML Templates\Excel\";

        public void Run()
        {
            if (string.IsNullOrEmpty(this.exportPath))
            {
                Console.WriteLine("ForThread error 0: no export path");
                return;
            }

            DTC_Solicitation dtcSol = new DTC_Solicitation();
            dtcSol.statusInfo = statusInfo;
            DataTable dt = dtcSol.Get_report_DT();

            //ViewDataForm vdf = new ViewDataForm();
            //vdf.Show();
            //vdf.Set_grid_dataSource(dt);

            this.statusInfo.status = "Create_Excel_fromDS";
            HssRawExcel hre = new HssRawExcel();
            hre.hLog = this.statusInfo;

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            dt.TableName = "Business Development";
            hre.Create_Excel_fromDS(ds, this.exportPath);

            this.statusInfo.status = "Finished";
            this.statusInfo.IsActive = false;

            MessageBox.Show("Done");
            Thread th = new Thread(this.ClearMemory);
            th.Start();
        }

        private void ClearMemory()
        {
            Thread.Sleep(1000);
            GC.Collect();
        }
    }
}
