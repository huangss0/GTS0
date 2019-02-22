using System;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.ServiceModel.Channels;
using System.IO;

namespace WCF_test
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TestService" in both code and config file together.
    public class TestService : ITestService
    {
        public TestService()
        {
            byte[] data = new byte[28];
            for (int i = 0; i < 26; i++) data[i] = (byte)(i + 'a');
            data[26] = 13; data[27] = 10;

            for (int i = 0; i < 130; i++) this.ms.Write(data, 0, 28);
        }

        DataTable ITestService.GetDT(int count)
        {
            DataTable dt = new DataTable("Table" + count);
            dt.Columns.Add("ID");

            for (int i = 0; i < count; i++)
            {
                DataRow row = dt.Rows.Add();
                row["ID"] = i;
            }

            return dt;
        }

        string ITestService.GetHello(string name)
        {
            OperationContext context = OperationContext.Current;
            MessageProperties prop = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpoint = prop[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            int port = endpoint.Port;

            return "Hello " + name + " Port:" + port;
        }

        List<People> ITestService.GetPeople()
        {
            List<People> pList = new List<People>();
            pList.Add(new People { Name = "Yihuan", DOB = new DateTime(1989, 10, 24) });
            pList.Add(new People { Name = "Huang", DOB = DateTime.Now });
            pList.Add(new People { Name = "Hss", DOB = new DateTime(1989, 1, 16) });

            return pList;
        }

        Stream ITestService.GetStream()
        {
            WebOperationContext.Current.OutgoingResponse.Headers.Add("Content-disposition", "filename=hi.txt");
            this.ms.Seek(0, SeekOrigin.Begin);
            return this.ms;
        }

        private MemoryStream ms = new MemoryStream();
    }
}
