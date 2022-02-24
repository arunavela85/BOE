using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dcboe.Components.Widgets.SlideShowWidget;
using CMS.MediaLibrary;
using CMS.DataEngine;
using CMS.SiteProvider;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Diagnostics;
using Kentico.PageBuilder.Web.Mvc;
using CMS.DocumentEngine.Types.CMS;
using dcboe.Components.Widgets.ElectionDayWorkerWidget;
using DCBOEElectionDayWorker;

[assembly: RegisterWidget(ElectionDayWorkerWidgetViewComponent.IDENTIFIER, typeof(ElectionDayWorkerWidgetViewComponent), "Election Day Worker", typeof(ElectionDayWorkerWidgetProperties), Description = "Election Day Worker Listing", IconClass = "icon-badge")]

namespace dcboe.Components.Widgets.ElectionDayWorkerWidget
{

    public class ElectionDayWorkerWidgetViewComponent : ViewComponent
    {


        public const string IDENTIFIER = "dcboe.Components.Widgets.ElectionDayWorkerWidget";

        public ElectionDayWorkerWidgetViewComponent()
        {
        }

        [Obsolete]
        public ViewViewComponentResult Invoke(ElectionDayWorkerWidgetProperties properties)
        {
            var ElectionDayWorkerWidgetViewModel = new ElectionDayWorkerWidgetViewModel
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
              
            };
            return View("~/Components/PageBuilder/Widgets/ElectionDayWorkerWidget/Default.cshtml", ElectionDayWorkerWidgetViewModel);

        }

    }
}