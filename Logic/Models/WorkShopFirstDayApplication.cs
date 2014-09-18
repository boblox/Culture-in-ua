using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Logic.Helpers;
using Logic.Resources;

namespace Logic.Models
{
    public class WorkShopFirstDayApplication //: BaseModel
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

        #endregion

        [Display(Name = "ApplicationModelProcessData", ResourceType = typeof(Localization))]
        [NotMapped]
        [RequiredTrue(ErrorMessageResourceName = "ApplicationModelRequiredField",
            ErrorMessageResourceType = typeof(Localization))]
        public bool ProcessData { get; set; }

        public WorkShopFirstDayApplication()

        {

        }
    }
}
