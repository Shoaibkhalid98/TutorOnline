using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorOnline.web.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Payment()
        {
            return View();
        }

        public ActionResult SendPaymentForm()
        {
            return View();
        }

        public ActionResult ReceivedPayments()
        {
            return View();
        }
    }
}