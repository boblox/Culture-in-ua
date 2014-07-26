using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Logic.Resources;

namespace Logic.Helpers
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString EnumDropDownListFor<TModel, TEnum>(this HtmlHelper<TModel> html, Expression<Func<TModel, TEnum>> expression)
        {
            var metadata = ModelMetadata.FromLambdaExpression(expression, html.ViewData);

            var enumType = Nullable.GetUnderlyingType(metadata.ModelType) ?? metadata.ModelType;

            var enumValues = Enum.GetValues(enumType).Cast<object>();

            var items = from enumValue in enumValues
                        select new SelectListItem
                        {
                            Text = GetResourceValueForEnumValue(enumValue),
                            Value = ((int)enumValue).ToString(),
                            Selected = enumValue.Equals(metadata.Model)
                        };

            return html.DropDownListFor(expression, items, null, null);
        }

        private static string GetResourceValueForEnumValue<TEnum>(TEnum enumValue)
        {
            var result = null as string;
            var displayAttr = enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttributes(false)
                .OfType<DisplayAttribute>()
                .LastOrDefault();
            if (displayAttr != null)
            {
                result = displayAttr.GetName();
            }
            return result ?? enumValue.ToString();

            //var key = string.Format("{0}_{1}", enumValue.GetType().Name, enumValue);

            //return Localization.ResourceManager.GetString(key) ?? enumValue.ToString();
        }
    }
}
