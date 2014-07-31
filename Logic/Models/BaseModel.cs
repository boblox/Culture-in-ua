using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Logic.Enums;
using Logic.Helpers;
using Logic.Resources;
using Umbraco.Web;

namespace Logic.Models
{
    public class BaseModel
    {
        public UmbracoHelper Umbraco { get; set; }

        public string GetDictionaryValue(string key)
        {
            return Umbraco.GetDictionaryValue(key);
        }

        public BaseModel(UmbracoHelper umbraco)
        {
            Umbraco = umbraco;
        }
    }
}
