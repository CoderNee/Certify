using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Certify.Instance
{
    public class Transaction : ISerializable
    {
        public string hash { get; set; }

        public string timeStamp { get; set; }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
           
        }
    }
}
