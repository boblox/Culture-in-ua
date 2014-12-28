using System;
using System.Data.Entity;
using System.Web.Mvc;
using Logic.DAL;

namespace Logic.Helpers
{
    /// <summary>
    /// Summary description for Global
    /// </summary>
    public class Global : Umbraco.Web.UmbracoApplication
    {
        protected override void OnApplicationStarted(object sender, EventArgs e)
        {
            ModelBinders.Binders.Add(typeof(DateTime), new MyDateTimeModelBinder());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Migrations.Configuration>()); 
            base.OnApplicationStarted(sender, e);
        }
    }

}
