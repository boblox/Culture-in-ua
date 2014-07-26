using System.Web.Mvc;
using Logic.Models;
using Umbraco.Web.Mvc;

namespace Logic.Controllers
{
    public class WorkShopApplicationController : SurfaceController
    {
        [HttpPost]
        public ActionResult SendApplication(WorkShopApplicationModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }
            TempData.Add("Application received", true);
            return RedirectToCurrentUmbracoPage();
        }

        [HttpGet]
        public string Index()
        {
            return "bob";
        }
    }
}
