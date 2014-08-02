using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Web.Mvc;
using Logic.DAL;
using Logic.Models;
using Umbraco.Core.Logging;
using Umbraco.Web.Mvc;

namespace Logic.Controllers
{
    public class WorkShopApplicationController : SurfaceController
    {
        #region Actions

        [HttpPost]
        public ActionResult Send(WorkShopApplication model)
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

        public ActionResult GetApplications()
        {
            var result = new StringBuilder();
            var type = typeof(WorkShopApplication);
            var properties = type.GetProperties();
            var headers = new List<KeyValuePair<PropertyInfo, string>>();
            foreach (var property in properties)
            {
                var name = null as string;
                var attributes = property.GetCustomAttributes(false);
                var notMappedAttr = attributes.OfType<NotMappedAttribute>().LastOrDefault();
                if (notMappedAttr == null)
                {
                    var displayAttr = attributes.OfType<DisplayAttribute>().LastOrDefault();
                    if (displayAttr != null)
                    {
                        name = displayAttr.GetName();
                    }
                    headers.Add(new KeyValuePair<PropertyInfo, string>(property, name ?? property.Name));
                }
            }
            result.Append(GetCsvLine(headers.Select(h => h.Value).Cast<object>().ToList()));

            using (var context = new DataContext())
            {
                var applications = context.WorkShopApplications;
                foreach (var application in applications)
                {
                    result.Append(ObjectToCsvData(application, headers.Select(p => p.Key).ToList()));
                }
                context.SaveChanges();
            }

            Response.Clear();
            var contentDisposition = new ContentDisposition
            {
                Inline = false,
                FileName = "Applications.csv",
            };
            Response.AddHeader("Content-Disposition", contentDisposition.ToString());
            var preamble = Encoding.UTF8.GetPreamble();
            return File(preamble.Concat(Encoding.UTF8.GetBytes(result.ToString())).ToArray(), "text/csv");
        }

        [ChildActionOnly]
        public ActionResult Index()
        {
            return PartialView("umbWorkShopApplication", new WorkShopApplication());
        }

        #endregion

        #region Hekpers

        public static string GetCsvLine(IList<object> values)
        {
            var result = new StringBuilder();
            for (var index = 0; index < values.Count; index++)
            {
                var value = values[index] == null ? string.Empty : values[index].ToString();
                value = value.Replace("\"", "\"\"");
                result.Append("\"" + value + "\"");
                result.Append(index < values.Count - 1 ? "," : "\r\n");
            }
            return result.ToString();
        }

        public static string ObjectToCsvData(object obj, IList<PropertyInfo> properties)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj", "Value can not be null or Nothing!");
            }
            var values = properties.Select(p => p.GetValue(obj, null)).ToList();
            return GetCsvLine(values);
        }

        #endregion

    }
}
