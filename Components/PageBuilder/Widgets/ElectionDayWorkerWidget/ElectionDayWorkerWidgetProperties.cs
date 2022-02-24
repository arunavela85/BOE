using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace dcboe.Components.Widgets.ElectionDayWorkerWidget
{
    public class ElectionDayWorkerWidgetProperties : IWidgetProperties
    {

        [Required(ErrorMessage = "First Number is required.")]
        public string Firstname { get; set; }

        public string Middlename { get; set; }

        public string Lastname { get; set; }

        public string Suffix { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string HomeTelephone { get; set; }
        public string BusinessNumber { get; set; }
        [Required]
        public string CellNumber { get; set; }

        [Required]
        public string EmailAddress { get; set; }
        public string StreetAddress { get; set; }
        public string SecondaryAddress { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }

        public bool ElectionWorkerBefore { get; set; }

        public bool IsDistrictGovtEmployee { get; set; }

        public bool IsWillingToTravel { get; set; }
        public string ModeOfTransportation { get; set; }
        public string TransportationOther { get; set; }
        public string Languages { get; set; }
        public string OtherLanguages { get; set; }
        public bool UseComputerOnDailyBasis { get; set; }
        public bool ComfortableUsingKeyboard { get; set; }
        public string OperatingSystem { get; set; }
        public string FrequentlyWalkingOrSitting { get; set; }
        public string ElectionDayWorkerSource { get; set; }
        public string ElectionDayWorkerSourceOther { get; set; }
    }
}
