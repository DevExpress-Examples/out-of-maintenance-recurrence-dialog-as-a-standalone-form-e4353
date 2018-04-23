using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.XtraScheduler;
using DevExpress.Web.Mvc;

namespace AppointmentRecurrenceFormExample.Controllers
{
    public class HomeController: Controller {
        public ActionResult Index() {
            RecurrenceInfo recurrenceInfo = new RecurrenceInfo() {
                Start = DateTime.Today,
                End = DateTime.Today.Add(TimeSpan.FromDays(1)),
                Type = RecurrenceType.Weekly,
                AllDay = true
            };
            return View("Index", recurrenceInfo);
        }
        public ActionResult RecurrenceFormInfo() {
            Appointment pattern = new Appointment(AppointmentType.Pattern, 
                new DateTime(2012, 10, 20, 3, 0, 0), new DateTime(2012, 10, 20, 4, 0, 0));
            RecurrenceInfo recurrenceInfo = AppointmentRecurrenceFormExtension.GetValue("RecurrenceControl", pattern);
            return View("RecurrenceFormInfo", (object)recurrenceInfo.ToXml());
        }
    }
}
