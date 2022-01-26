using System.ComponentModel.DataAnnotations;

namespace dcboe.Components.PageBuilder.PersonalizationConditions.HasGivenConsent
{
    public class HasGivenConsentViewModel
    {
        [Required]
        [Display(Name = "Consent code name")]
        public string ConsentCodeName { get; set; }
    }
}