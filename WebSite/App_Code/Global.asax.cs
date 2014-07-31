using System;
using System.Web.Mvc;
using Logic.Helpers;
namespace WebSite
{
    /// <summary>
    /// Summary description for Gloval
    /// </summary>
    public class Global : Umbraco.Web.UmbracoApplication
    {
        protected override void OnApplicationStarted(object sender, EventArgs e)
        {
            ModelBinders.Binders.Add(typeof(DateTime), new MyDateTimeModelBinder());
            base.OnApplicationStarted(sender, e);
        }
    }

}
