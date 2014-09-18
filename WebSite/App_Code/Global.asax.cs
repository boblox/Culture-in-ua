using System;
using System.Data.Entity;
using System.Web.Mvc;
using Logic.DAL;
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
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Logic.Migrations.Configuration>()); 
            base.OnApplicationStarted(sender, e);
        }
    }

}
