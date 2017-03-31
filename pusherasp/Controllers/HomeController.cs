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
            var pusher = new Pusher("295876", "4b34c484eeb9fe4f4142", "6b17e2a894fc39296783");
            var result = pusher.Trigger("asp_channel", "asp_event", new { message = message, name = "Anonymous" });
           
            return new HttpStatusCodeResult((int)HttpStatusCode.OK);

        } 
    }
}