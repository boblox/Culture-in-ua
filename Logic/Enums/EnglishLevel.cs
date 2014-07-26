using System.ComponentModel.DataAnnotations;
using Logic.Resources;

namespace Logic.Enums
{
    public enum EnglishLevel
    {
        [Display(Name = "EnglishLevel_Elementary", ResourceType = typeof(Localization))]
        Elementary,

        [Display(Name = "EnglishLevel_PreIntermediate", ResourceType = typeof(Localization))]
        PreIntermediate,

        [Display(Name = "EnglishLevel_Intermediate", ResourceType = typeof(Localization))]
        Intermediate,

        [Display(Name = "EnglishLevel_UpperIntermediate", ResourceType = typeof(Localization))]
        UpperIntermediate,

        [Display(Name = "EnglishLevel_Advanced", ResourceType = typeof(Localization))]
        Advanced
    }
}
