using System;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HssDARWIN.SubProjects.UserProfile
{
    public class UserConfigMaster
    {
        public const string DefaultName = "$Default$";

        private static Hss_UserConfig userConfig = null;
        private static HashSet<Control> control_hs = new HashSet<Control>();
        public static bool DRWIN_MDI_closing_flag = false;

        public static HssGridConfig Get_GridConfig(string tabName, string gridName, bool createNew_flag = false)
        {
            if (!Utility.Is_DWRIN_admin()) return null; //Turn off Column Customization for now

            UserConfigMaster.Init_userConfig_fromDB();

            if (string.IsNullOrEmpty(tabName)) tabName = "$Default$";
            if (string.IsNullOrEmpty(gridName)) gridName = "$Default$";

            if (UserConfigMaster.userConfig.Contains_TabConfig(tabName))
            {
                HssTabConfig htc = UserConfigMaster.userConfig.Get_TabConfig(tabName);
                if (htc.Contains_GridConfig(gridName)) return htc.Get_GridConfig(gridName);
                else
                {
                    if (createNew_flag)
                    {
                        HssGridConfig hgc = new HssGridConfig(gridName);
                        htc.Set_GridConfig(gridName, hgc);
                        return hgc;
                    }
                    else return null;
                }
            }
            else
            {
                if (createNew_flag)
                {
                    HssTabConfig htc = new HssTabConfig(tabName);
                    UserConfigMaster.userConfig.Set_TabConfig(tabName, htc);

                    HssGridConfig hgc = new HssGridConfig(gridName);
                    htc.Set_GridConfig(gridName, hgc);
                    return hgc;
                }
                else return null;
            }
        }

        /// <summary>
        /// Save all config info to DataBase
        /// </summary>
        /// <returns>Changes saved or not</returns>
        public static bool SaveConfig_to_DB()
        {
            if (UserConfigMaster.userConfig == null) return false;

            bool flag = false;

            try { flag = UserConfigMaster.userConfig.Save_to_DB(); }
            catch
            {
                if (Utility.Is_DWRIN_admin())
                    MessageBox.Show("UserConfigMaster error 0: Saving failed");
            }

            return flag;
        }

        public static void ClearAllConfigs()
        {
            UserConfigMaster.Init_userConfig_fromDB();
            UserConfigMaster.userConfig.ClearConfig();
        }

        /********************************************************************************************************/
        private static void Init_userConfig_fromDB()
        {
            if (UserConfigMaster.userConfig == null)
            {
                UserConfigMaster.userConfig = new Hss_UserConfig(Utility.CurrentUser);
                UserConfigMaster.userConfig.Init_from_DB();
                UserConfigMaster.userConfig.Init_from_ConfigXML();
            }
        }

        /// <summary>
        /// Save all config to DB when DRWIN is closed
        /// </summary>
        private static void FinalSaveAll()
        {
            if (UserConfigMaster.control_hs.Count < 1) return;

            int secondsWait = 10 * 60;
            while (secondsWait > 0)
            {
                Thread.Sleep(100);
                if (UserConfigMaster.AllControl_disposed())
                {
                    UserConfigMaster.SaveConfig_to_DB();
                    UserConfigMaster.ClearAllControls();
                    break;
                }
                else
                {
                    if (secondsWait % 10 == 0 && Utility.Is_DWRIN_admin()) Console.WriteLine("--> Wait to save config " + secondsWait);
                    --secondsWait;
                }
            }
        }

        /// <summary>
        /// (Async function) Save all config to DB when DRWIN is closed
        /// </summary>
        public static void FinalSaveAll_async()
        {
            Thread th = new Thread(UserConfigMaster.FinalSaveAll);
            th.Start();
        }

        /*-------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Check if all controls with config is disposed already
        /// </summary>
        private static bool AllControl_disposed()
        {
            foreach (Control ctl in UserConfigMaster.control_hs)
                if (!ctl.IsDisposed) return false;

            return true;
        }

        private static void ClearAllControls()
        {
            UserConfigMaster.control_hs.Clear();
        }

        public static void AddControl(Control ctl)
        {
            if (ctl == null) return;
            UserConfigMaster.control_hs.Add(ctl);
        }
    }
}
