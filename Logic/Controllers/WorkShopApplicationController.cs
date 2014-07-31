using System;
using System.Web.Mvc;
using Logic.DAL;
using Logic.Models;
using Umbraco.Core.Logging;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace Logic.Controllers
{
    public class WorkShopApplicationController : SurfaceController
    {
        [HttpPost]
        public ActionResult SendApplication(WorkShopApplication model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return CurrentUmbracoPage();
                }
                using (var context = new DataContext())
                {
                    context.WorkShopApplications.Add(model);
                    context.SaveChanges();
                }
                TempData.Add("Application received", true);
            }
            catch (Exception e)
            {
                LogHelper.Error(GetType(), e.ToString(), e);
            }
            return RedirectToCurrentUmbracoPage();
        }

        [ChildActionOnly]
        public ActionResult Index()
        {
            return PartialView("umbWorkShopApplication", new WorkShopApplication());
        }
    }
}
