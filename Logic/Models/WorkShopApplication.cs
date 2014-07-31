using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Logic.Enums;
using Logic.Helpers;
using Logic.Resources;
using Umbraco.Web;

namespace Logic.Models
{
    public class WorkShopApplication //: BaseModel
    {
        [Key]
        public int Id { get; set; }

        #region PersonalData

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelName", ResourceType = typeof(Localization))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelSurname", ResourceType = typeof(Localization))]
        public string Surname { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelBirthDate", ResourceType = typeof(Localization))]
        [DataType("Time")] //TODO: hack, only this DataType prevents client validation
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelCountry", ResourceType = typeof(Localization))]
        public string Country { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelCity", ResourceType = typeof(Localization))]
        public string City { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        //[RegularExpression(
        //    @"^[\w-]+(\.[\w-]+)*@([a-z0-9-]+(\.[a-z0-9-]+)*?\.[a-z]{2,6}|(\d{1,3}\.){3}\d{1,3})(:\d{4})?$",
        //    ErrorMessageResourceName = "ApplicationModelEmailInvalid", ErrorMessageResourceType = typeof(Localization))
        //]
        [EmailAddress(ErrorMessageResourceName = "ApplicationModelEmailInvalid", ErrorMessageResourceType = typeof(Localization), ErrorMessage = null)]
        [Display(Name = "ApplicationModelEmail", ResourceType = typeof(Localization))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelPhone", ResourceType = typeof(Localization))]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelProfession", ResourceType = typeof(Localization))]
        public string Profession { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelEnglishLevel", ResourceType = typeof(Localization))]
        public EnglishLevel EnglishLevel { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelOrganizationName", ResourceType = typeof(Localization))]
        public string OrganizationName { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelLegalStatus", ResourceType = typeof(Localization))]
        public LegalStatus LegalStatus { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelOrganizationInfo", ResourceType = typeof(Localization))]
        [DataType(DataType.MultilineText)]
        public string OrganizationInfo { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelParticipantsNumber", ResourceType = typeof(Localization))]
        public int ParticipantsNumber { get; set; }

        #endregion

        #region Motivation

        [Display(Name = "ApplicationModelMotivation1", ResourceType = typeof(Localization))]
        [DataType(DataType.MultilineText)]
        public string Motivation1 { get; set; }

        [Display(Name = "ApplicationModelMotivation2", ResourceType = typeof(Localization))]
        [DataType(DataType.MultilineText)]
        public string Motivation2 { get; set; }

        [Display(Name = "ApplicationModelMotivation3", ResourceType = typeof(Localization))]
        [DataType(DataType.MultilineText)]
        public string Motivation3 { get; set; }

        [Display(Name = "ApplicationModelMotivation4", ResourceType = typeof(Localization))]
        [DataType(DataType.MultilineText)]
        public string Motivation4 { get; set; }

        [Display(Name = "ApplicationModelMotivation5", ResourceType = typeof(Localization))]
        [DataType(DataType.MultilineText)]
        public string Motivation5 { get; set; }

        [Display(Name = "ApplicationModelMotivation6", ResourceType = typeof(Localization))]
        [DataType(DataType.MultilineText)]
        public string Motivation6 { get; set; }

        #endregion

        [Display(Name = "ApplicationModelProcessData", ResourceType = typeof(Localization))]
        [NotMapped]
        [RequiredTrue(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        public bool ProcessData { get; set; }

        public WorkShopApplication()
            //(UmbracoHelper umbraco)
            //: base(umbraco)
        {
            BirthDate = new DateTime(1980, 1, 1);
            EnglishLevel = EnglishLevel.Elementary;
            LegalStatus = LegalStatus.PublicOrganization;
        }
    }
}
