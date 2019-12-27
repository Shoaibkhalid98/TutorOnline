using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorOnline.web.Controllers
{
    public class VideoCallController : Controller
    {
        // GET: VideoCall
        public ActionResult VideoCall()
        {
            return View();
        }

        public ActionResult AllUserListVideoCallPage()
        {
            return View();
        }

        public ActionResult CallerPage()
        {
            return View();
        }
        
        public ActionResult AllStudentsOfATeacherListVideoCallPage()
        {
            return View();
        }
    }
}