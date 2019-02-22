using System.Data.SqlClient;

namespace HssUtility.SQLserver
{
    public interface I_DBcmd
    {
        SqlCommand GetSQL_cmd();
        void SetDBname(string name);
    }
}
