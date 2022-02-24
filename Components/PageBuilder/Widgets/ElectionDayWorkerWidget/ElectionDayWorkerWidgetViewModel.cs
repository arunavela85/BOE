using DCBOEElectionDayWorker;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dcboe.Components.Widgets.ElectionDayWorkerWidget
{
    public class ElectionDayWorkerWidgetViewModel
    {
        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First name", Prompt = "First Name")]
        public string Firstname { get; set; }

        public string Middlename { get; set; }
        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last name", Prompt = "Last Name")]
        public string Lastname { get; set; }

        public string Suffix { get; set; }
        [Required(ErrorMessage = "Date Of Birth is required.")]
        [Display(Name = "Date Of Birth", Prompt = "ex: 01/01/2022")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:mm/dd/YYYY}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Home Telephone", Prompt = "(xxx) xxx-xxxx")]
        [Phone]
        public string HomeTelephone { get; set; }
        [Display(Name = "Business Number", Prompt = "(xxx) xxx-xxxx")]
        [Phone]
        public string BusinessNumber { get; set; }

        [Required(ErrorMessage = "CellNumber is required.")]
        [StringLength(14, MinimumLength = 10, ErrorMessage = "CellNumber cannot be longer than 10 characters")]
        [Display(Name = "Cell Number", Prompt = "(xxx) xxx-xxxx")]
        
        public string CellNumber { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email", Prompt = "example@example.org")]
        public string EmailAddress { get; set; }
        public string StreetAddress { get; set; }
        public string SecondaryAddress { get; set; }

        [ReadOnly(true)]
        public string City { get; set; }
        [ReadOnly(true)]
        public string State { get; set; }
        public string Zipcode { get; set; }

        [Required(ErrorMessage = "Please choose one option")]     
       public bool ElectionWorkerBefore { get; set; }
    
        [Required(ErrorMessage = "Please choose one option")]
        public bool IsDistrictGovtEmployee { get; set; }
        [Required(ErrorMessage = "Please choose one option")]
        public bool IsWillingToTravel { get; set; }

        public string ModeOfTransportation { get; set; }
        public List<string> ModeOfTransportations = new List<string> { "Walk","Car", "Bus", "Metro" };
    
    public string TransportationOther { get; set; }
        public string Languages { get; set; }
        public List<string> lang = new List<string> { "Chinese", "Spanish", "Other" };

        public string OtherLanguages { get; set; }
        [Required(ErrorMessage = "Please choose one option")]
        public bool UseComputerOnDailyBasis { get; set; }
        [Required(ErrorMessage = "Please choose one option")]
        public bool ComfortableUsingKeyboard { get; set; }
        public string OperatingSystem { get; set; }
        [Required(ErrorMessage = "Please choose one option")]
        public string FrequentlyWalkingOrSitting { get; set; }
        public string[] FrequentlyWalkingOrSittings = new [] { "Walking around", "Sitting", "Either is fine" };
        [Required(ErrorMessage = "Please choose one option")]
        public string ElectionDayWorkerSource { get; set; }
        public string[] ElectionDayWorkerSources = new[] { "Family/Friend", "Social Media (Twitter, Facebook, etc.)", "Outreach Event", "Volunteer Match", "Commercial Ad", "Other" };

        public string ElectionDayWorkerSourceOther { get; set; }

      
    }
}
