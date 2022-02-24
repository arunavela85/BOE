

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
using dcboe.Components.Widgets.EventWidget;

[assembly: RegisterWidget(EventWidgetViewComponent.IDENTIFIER, typeof(EventWidgetViewComponent), "Events", typeof(EventWidgetProperties), Description = "Event Listing", IconClass = "icon-badge")]

namespace dcboe.Components.Widgets.EventWidget
{

    public class EventWidgetViewComponent : ViewComponent
    {


        public const string IDENTIFIER = "dcboe.Components.Widgets.EventWidget";


        public EventWidgetViewComponent()
        {
        }

        [Obsolete]
        public ViewViewComponentResult Invoke(EventWidgetProperties properties)
        {
            IEnumerable<Event> eventsinfo = EventProvider.GetEvents();
            if (properties.ShowButton)
            {
                eventsinfo = EventProvider.GetEvents().Page(0, 5);

            }

            // Prepares a collection of view models containing required data of the media files
            IEnumerable<EventWidgetViewModel> model = eventsinfo.Select(
                    events => new EventWidgetViewModel
                    {
                        title = events.EventName,
                        url = events.EventLink,
                        start = events.EventDate,
                        showButton = properties.ShowButton

                    }
            );


            return View("~/Components/PageBuilder/Widgets/EventWidget/Default.cshtml", model);

        }

    }
}



