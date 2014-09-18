using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Logic.Enums;
using Logic.Helpers;
using Logic.Resources;

namespace Logic.Models
{
    public class WorkShopVolunteerApplication //: BaseModel
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
        [EmailAddress(ErrorMessageResourceName = "ApplicationModelEmailInvalid", ErrorMessageResourceType = typeof(Localization), ErrorMessage = null)]
        [Display(Name = "ApplicationModelEmail", ResourceType = typeof(Localization))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        [Url(ErrorMessageResourceName = "ApplicationModelUrlInvalid", ErrorMessageResourceType = typeof(Localization), ErrorMessage = null)]
        [Display(Name = "ApplicationModelSocialNetworkUrl", ResourceType = typeof(Localization))]
        [DataType(DataType.Url)]
        public string SocialNetworkUrl { get; set; }

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
        [Display(Name = "ApplicationModelWorkTimeRange", ResourceType = typeof(Localization))]
        [DataType(DataType.MultilineText)]
        public string WorkTimeRange { get; set; }

        #endregion

        #region Motivation

        [Display(Name = "ApplicationModelVolunteeringMotivation", ResourceType = typeof(Localization))]
        [DataType(DataType.MultilineText)]
        public string VolunteeringMotivation { get; set; }

        #endregion

        [Display(Name = "ApplicationModelProcessData", ResourceType = typeof(Localization))]
        [NotMapped]
        [RequiredTrue(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        public bool ProcessData { get; set; }

        public WorkShopVolunteerApplication()
        //(UmbracoHelper umbraco)
        //: base(umbraco)
        {
            BirthDate = new DateTime(1980, 1, 1);
            EnglishLevel = EnglishLevel.Elementary;
        }
    }
}
