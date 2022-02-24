using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using DCBOEElectionDayWorker;
using System.Diagnostics;

namespace dcboe.Components.Widgets.ElectionDayWorkerWidget
{

    public class ElectionDayWorkerWidgetController : Controller
    {

        [HttpPost]
        [Route("ElectionDayWorkerWidgetController/SaveEDW")]
        [ValidateAntiForgeryToken]

        public ActionResult SaveEDW(ElectionDayWorkerWidgetViewModel properties)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Components/PageBuilder/Widgets/ElectionDayWorkerWidget/Default.cshtml", properties);
            }
            ElectiondayworkerInfo newInfo = new ElectiondayworkerInfo()
            {

                Firstname = properties.Firstname,
                Middlename = properties.Middlename,
                Lastname = properties.Lastname,
                Suffix = properties.Suffix,
                HomeTelephone = properties.HomeTelephone,
                BusinessNumber = properties.BusinessNumber,
                CellNumber = properties.CellNumber,
                EmailAddress = properties.EmailAddress,
                DateOfBirth = properties.DateOfBirth,
                StreetAddress = properties.StreetAddress,
                SecondaryAddress = properties.SecondaryAddress,
                City = properties.City,
                State = properties.State,
                Zipcode = properties.Zipcode,
                ElectionWorkerBefore = properties.ElectionWorkerBefore,
                IsDistrictGovtEmployee = properties.IsDistrictGovtEmployee,
                IsWillingToTravel = properties.IsWillingToTravel,
                ModeOfTransportation = properties.ModeOfTransportation,
                TransportationOther = properties.TransportationOther,
                Languages = properties.Languages,
                OtherLanguages = properties.OtherLanguages,
                UseComputerOnDailyBasis = properties.UseComputerOnDailyBasis,
                ComfortableUsingKeyboard = properties.ComfortableUsingKeyboard,
                OperatingSystem = properties.OperatingSystem,
                FrequentlyWalkingOrSitting = properties.FrequentlyWalkingOrSitting,
                ElectionDayWorkerSource = properties.ElectionDayWorkerSource,
                ElectionDayWorkerSourceOther = properties.ElectionDayWorkerSourceOther,
                ApprovedStatus = "N",
            };

            // Saves the child forum to the database
            ElectiondayworkerInfoProvider.ProviderObject.Set(newInfo);
            return Content("Success");
        }



    }
}