using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MessageClient.Controllers
{
   //[Authorize]
    public class HomeController : Controller
    {
        //MeddelandeServiceRef.Service1Client messageClient = new MeddelandeServiceRef.Service1Client();
        AnnonsServiceReference.Service1Client adClient = new AnnonsServiceReference.Service1Client();
        public ActionResult Index()
        {
            //IEnumerable<MeddelandeServiceRef.Messageinfo> messageList = messageClient.GetMessages().ToList();
            //ViewBag.Lista = messageList;
            
            ViewBag.annonsClient = adClient.GetAllServiceData();
            return View();
        }
        [HttpPost]
        public ActionResult Index(MeddelandeServiceRef.AddMessage newMessage)
        {
            MeddelandeServiceRef.Service1Client messageClient = new MeddelandeServiceRef.Service1Client();
            messageClient.AddMessage(newMessage);
            IEnumerable<MeddelandeServiceRef.Messageinfo> messagelist = messageClient.GetMessages().ToList();
            //IEnumerable<MeddelandeServiceReference.Messageinfo> messagelist = messageClient.GetMessages().ToList().Where(m => m.SendingUserId == 1);
            ViewBag.Lista = messagelist;
            return View();
        }
    }
}