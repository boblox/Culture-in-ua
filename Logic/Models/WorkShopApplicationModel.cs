using System;
using System.ComponentModel.DataAnnotations;
using Logic.Enums;
using Logic.Resources;

namespace Logic.Models
{
    public class WorkShopApplicationModel
    {
        /*Personal data======================================================================*/
        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField", ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelName", ResourceType = typeof(Localization))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField", ErrorMessageResourceType = typeof(Localization))]
        public string Surname { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField", ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelBirthDate", ResourceType = typeof(Localization))]
        [DataType("Time")] //hack
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField", ErrorMessageResourceType = typeof(Localization))]
        public string Country { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField", ErrorMessageResourceType = typeof(Localization))]
        public string City { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField", ErrorMessageResourceType = typeof(Localization))]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@([a-z0-9-]+(\.[a-z0-9-]+)*?\.[a-z]{2,6}|(\d{1,3}\.){3}\d{1,3})(:\d{4})?$",
            ErrorMessageResourceName = "ApplicationModelEmailInvalid", ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelEmail", ResourceType = typeof(Localization))]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField", ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelPhone", ResourceType = typeof(Localization))]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField", ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelProfession", ResourceType = typeof(Localization))]
        public string Profession { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField", ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelEnglishLevel", ResourceType = typeof(Localization))]
        public EnglishLevel EnglishLevel { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField", ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelOrganizationName", ResourceType = typeof(Localization))]
        public string OrganizationName { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField", ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelLegalStatus", ResourceType = typeof(Localization))]
        public LegalStatus LegalStatus { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField", ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelOrganizationInfo", ResourceType = typeof(Localization))]
        [DataType(DataType.MultilineText)]
        public string OrganizationInfo { get; set; }

        [Required(ErrorMessageResourceName = "ApplicationModelRequiredField", ErrorMessageResourceType = typeof(Localization))]
        [Display(Name = "ApplicationModelParticipantsNumber", ResourceType = typeof(Localization))]
        public int ParticipantsNumber { get; set; }

        [Display(Name = "ApplicationModelProcessData", ResourceType = typeof(Localization))]
        public bool ProcessData { get; set; }

        /*Motivation======================================================================*/
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

        public WorkShopApplicationModel()
        {
            BirthDate = DateTime.Now;
            EnglishLevel = EnglishLevel.Elementary;
            LegalStatus = LegalStatus.PublicOrganization;
        }
    }
}
