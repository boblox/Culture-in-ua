using System;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Web.Mvc;
using Logic.DAL;
using Logic.Helpers;
using Logic.Models;
using Logic.Resources;
using Umbraco.Core.Logging;
using Umbraco.Web.Mvc;

namespace Logic.Controllers
{
    public class WorkShopFirstDayApplicationController : SurfaceController
    {
        const int MaxApplicationsCount = 55;

        #region Actions

        [HttpPost]
        public ActionResult Send(WorkShopFirstDayApplication model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return CurrentUmbracoPage();
                }
                using (var context = new DataContext())
                {
                    context.WorkShopFirstDayApplications.Add(model);
                    context.SaveChanges();
                    SendEmail(model.Email,
                        Localization.WorkShopFirstDayApplicationEmailSubject,
                        string.Format(Localization.WorkShopFirstDayApplicationEmailBody, model.Id));
                }
                TempData.Add("Application received", true);
                TempData.Add("Applicant number", model.Id);
            }
            catch (Exception e)
            {
                LogHelper.Error(GetType(), e.ToString(), e);
            }
            return RedirectToCurrentUmbracoPage();
        }

        public ActionResult GetApplications()
        {
            //Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(language);
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(language);

            byte[] result;
            using (var context = new DataContext())
            {
                var applications = context.WorkShopFirstDayApplications.ToList();
                result = CsvConverter<WorkShopFirstDayApplication>.Convert(applications);
            }

            Response.Clear();
            var contentDisposition = new ContentDisposition
            {
                Inline = false,
                FileName = "Applications.csv",
            };
            Response.AddHeader("Content-Disposition", contentDisposition.ToString());
            var preamble = Encoding.UTF8.GetPreamble();
            return File(preamble.Concat(result).ToArray(), "text/csv");
        }

        [ChildActionOnly]
        public ActionResult Index()
        {
            using (var context = new DataContext())
            {
                var count = context.WorkShopFirstDayApplications.Count();
                if (count >= MaxApplicationsCount)
                {
                    ViewData["Applications count limit exceeded"] = true;
                    return PartialView("umbWorkShopFirstDayApplication");
                }
            }
            return PartialView("umbWorkShopFirstDayApplication", new WorkShopFirstDayApplication());
        }

        #endregion

        #region Helpers

        public void SendEmail(string mailTo, string subject, string body)
        {
            var message = new MailMessage
            {
                //From = new MailAddress("culturalindustries.a@gmail.com", "Асоціація культурних індустрій"),
                Subject = subject,
                SubjectEncoding = Encoding.UTF8,
                Body = body,
                BodyEncoding = Encoding.UTF8,
                IsBodyHtml = true
            };
            message.To.Add(mailTo);

            var smtpClient = new SmtpClient();
            smtpClient.Send(message);
        }

        #endregion
    }
}
