using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dcboe.Components.Widgets.AccordianWidget;
using CMS.MediaLibrary;
using CMS.DataEngine;
using CMS.SiteProvider;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Diagnostics;
using Kentico.PageBuilder.Web.Mvc;
using CMS.DocumentEngine.Types.CMS;
using CMS.DocumentEngine;

[assembly: RegisterWidget(AccordianWidgetViewComponent.IDENTIFIER, typeof(AccordianWidgetViewComponent), "Accordian List", typeof(AccordianWidgetProperties), Description = "Accordian Listing", IconClass = "icon-badge")]

namespace dcboe.Components.Widgets.AccordianWidget
{

    public class AccordianWidgetViewComponent : ViewComponent
    {


        public const string IDENTIFIER = "dcboe.Components.Widgets.AccordianWidget";

        private readonly IPageRetriever pageRetriever;
        private readonly IPageUrlRetriever pageUrlRetriever;

        public AccordianWidgetViewComponent(IPageRetriever pageRetriever, IPageUrlRetriever pageUrlRetriever)
        {
            this.pageRetriever = pageRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
        }

        [Obsolete]
        public ViewViewComponentResult Invoke(AccordianWidgetProperties properties)
        {
            DocumentQuery query = DocumentHelper.GetDocuments("CMS.MenuItem")
                               .Path("/"+ properties.menuName + "/", PathTypeEnum.Children)
                               .OnSite("dcboe")
                               .Culture("en-us")
                               .NestingLevel(properties.subMenu)
                               .LatestVersion();

            var sampleData = query.ToList().Select(x => new {
                Name = x.DocumentName,
                Guid = x.DocumentGUID,
                RelativePath = pageUrlRetriever.Retrieve(x).AbsoluteUrl,

            });
            Debug.WriteLine(sampleData);

            // Prepares a collection of view models containing required data of the media files
            IEnumerable<AccordianWidgetViewModel> model = sampleData.Select(
                    menus => new AccordianWidgetViewModel
                    {
                        MenuName = menus.Name,
                        MenuGuid = menus.Guid,
                        MenuItemRelativeUrl = menus.RelativePath,
                    }
            ); 


            return View("~/Components/PageBuilder/Widgets/AccordianWidget/Default.cshtml", model);

        }
  
    }
    }


