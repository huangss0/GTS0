using System;
using System.Collections.Generic;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.IO;
using System.Data;

namespace WCF_test
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITestService" in both code and config file together.
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        [WebGet]
        string GetHello(string name);

        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml)]
        DataTable GetDT(int count);

        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<People> GetPeople();

        [OperationContract]
        [WebGet]
        Stream GetStream();
    }
}
