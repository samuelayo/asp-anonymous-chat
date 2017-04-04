using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PusherServer;
using System.Net;

namespace pusherasp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
        [HttpPost]
        public ActionResult Pushermessage(String message)
        {
            var pusher = new Pusher("PUSHER_APP_ID", "PUSHER_APP_KEY", "PUSHER_APP_SECRET");
            var result = pusher.Trigger("asp_channel", "asp_event", new { message = message, name = "Anonymous" });
           
            return new HttpStatusCodeResult((int)HttpStatusCode.OK);

        } 
    }
}