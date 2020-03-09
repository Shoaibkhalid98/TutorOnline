using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorOnline.web.Controllers
{
    public class ChatMessengerController : Controller
    {
        // GET: ChatMessenger
        public ActionResult ChatMessenger()
        {
            return View();
        }
        /// <summary>
        /// for student
        /// </summary>
        /// <returns></returns>
        public ActionResult ChatMessengerPage()
        {
            return View();
        }
        
        public ActionResult TeacherChatMessengerPage()
        {
            return View();
        }
    }
}