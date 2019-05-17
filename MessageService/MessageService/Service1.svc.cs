using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MessageService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private MessagesDBEntities db = new MessagesDBEntities();

        public string HelloMsg(string aString)
        {
            string hellomsg = "Hello my friend";
            return hellomsg;
        }

        void IService1.AddMessage(AddMessage newMessage)
        {

            using (db)
            {
                
                db.Message.Add(new Message
                {
                    SendingUserId = newMessage.SendingUserId,
                    RecievingUserId = newMessage.RecievingUserId,
                    Message1 = newMessage.Message,
                    ServiceId = newMessage.ServiceId,
                    ServiceTitle = newMessage.ServiceTitle,
                    Time = DateTime.Now //ovveride time i db, lägger in klientens tid i db
                    

                });
                db.SaveChanges();
            }
        }

        List<Messageinfo> IService1.GetMessages()
        {
            using (db)
            {
                var message = from m in db.Message select m;
                List<Messageinfo> allmessages = new List<Messageinfo>();

                foreach (var rad in message)
                {
                    allmessages.Add(new Messageinfo
                    {
                        Id = rad.Id,
                        SendingUserId = rad.SendingUserId,
                        RecievingUserId = rad.RecievingUserId,
                        Message = rad.Message1,
                        ServiceId = rad.ServiceId,
                        ServiceTitle = rad.ServiceTitle,
                        Time = rad.Time
                    });

                }
                return allmessages;
            }
        }
    }
}
