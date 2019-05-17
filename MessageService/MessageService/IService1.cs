using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MessageService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Messageinfo> GetMessages();
        [OperationContract]
        void AddMessage(AddMessage newMessage);
        [OperationContract]
        string HelloMsg(string aString);
    }


    [DataContract]
    public class Messageinfo
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int SendingUserId { get; set; }
        [DataMember]
        public int RecievingUserId { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public System.DateTime Time { get; set; }
        [DataMember]
        public int ServiceId { get; set; }
        [DataMember]
        public string ServiceTitle { get; set; }
        [DataMember]
        public byte[] UserPicture { get; set; }
    }

    public class AddMessage
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int SendingUserId { get; set; }
        [DataMember]
        public int RecievingUserId { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public System.DateTime Time { get; set; }
        [DataMember]
        public int ServiceId { get; set; }
        [DataMember]
        public string ServiceTitle { get; set; }
        [DataMember]
        public byte[] UserPicture { get; set; }
    }
}
