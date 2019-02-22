using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssUtility.DataSource
{
    public class File_info
    {
        public string fileName = null;
        public DateTime mod_time = DateTime.MinValue;
        public long size = -1;

        public File_info(string name)
        {
            this.fileName = name;
        }
    }
}
