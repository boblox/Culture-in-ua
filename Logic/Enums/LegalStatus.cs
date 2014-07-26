using System.ComponentModel.DataAnnotations;
using Logic.Resources;

namespace Logic.Enums
{
    public enum LegalStatus
    {
        [Display(Name = "LegalStatus_PublicOrganization", ResourceType = typeof(Localization))]
        PublicOrganization,

        [Display(Name = "LegalStatus_NotRegisteredInitiative", ResourceType = typeof(Localization))]
        NotRegisteredInitiative,

        [Display(Name = "LegalStatus_Other", ResourceType = typeof(Localization))]
        Other
    }
}
