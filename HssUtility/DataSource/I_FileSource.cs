using System.Collections.Generic;
using System.IO;
using HssUtility.Debug;

namespace HssUtility.DataSource
{
    public interface I_FileSource
    {
        bool Login(string serverAddr, string userID, string pwd);

        /// <summary>
        /// Get a list of file info in current directory from server
        /// </summary>
        /// <param name="dir">directory name, Null or empty for current dir</param>
        List<File_info> GetFilesList(string dir);

        long DownloadFile(string remoteFileName, Stream fs_for_save);
        long UploadFile(string remoteFileName, Stream fs_to_upload);
        bool Delete(string remotePath);

        void SetErrorLog(I_hssLog eLog);
    }

    public enum FileSource_transferType
    {
        Default = 0,
        Ascii = 1,
        Binary = 2,
    }
}
