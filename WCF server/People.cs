using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WCF_test
{
    [DataContract]
    public class People
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime DOB { get; set; }
    }
}
