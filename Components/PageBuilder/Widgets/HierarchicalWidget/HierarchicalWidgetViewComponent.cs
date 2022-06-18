using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dcboe.Components.Widgets.HierarchicalWidget;
using CMS.MediaLibrary;
using CMS.DataEngine;
using CMS.SiteProvider;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Diagnostics;
using Kentico.PageBuilder.Web.Mvc;
using CMS.DocumentEngine.Types.CMS;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Routing;

[assembly: RegisterWidget(HierarchicalWidgetViewComponent.IDENTIFIER, typeof(HierarchicalWidgetViewComponent), "Hierarchical Menu", typeof(HierarchicalWidgetProperties), Description = "Hierarchical Listing", IconClass = "icon-badge")]

namespace dcboe.Components.Widgets.HierarchicalWidget
{

    public class HierarchicalWidgetViewComponent : ViewComponent
    {
        public const string IDENTIFIER = "dcboe.Components.Widgets.HierarchicalWidget";
        private readonly IPageRetriever pageRetriever;
        private readonly IPageUrlRetriever pageUrlRetriever;

        public HierarchicalWidgetViewComponent(IPageRetriever pageRetriever, IPageUrlRetriever pageUrlRetriever)
        {
            this.pageRetriever = pageRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
        }

        [Obsolete]
        public async Task<ViewViewComponentResult> InvokeAsync(HierarchicalWidgetProperties properties)
        {



            Debug.WriteLine(properties.menuName);
           
            /*DocumentQuery query = DocumentHelper.GetDocuments("CMS.MenuItem")
                                .WithPageUrlPaths()
                               .OnSite("dcboe")
                               .Culture("en-us")
                               .NestingLevel(properties.subMenu)
                               .LatestVersion(); */

            IEnumerable<TreeNode> menuItems = await pageRetriever.RetrieveAsync<TreeNode>(query => query
                                                   .MenuItems()
                                                   .NestingLevel(properties.subMenu)
                                                   .Columns("DocumentName", "DocumentGUID","NodeID", "NodeSiteID")
                                                   .WithPageUrlPaths()
                                                   .OnSite(SiteContext.CurrentSiteName)
                                                    .Path(properties.menuName, PathTypeEnum.Children)
                                                   .OrderByAscending("NodeOrder"));

            var sampleData = menuItems.Select(x => new {
                Name = x.DocumentName,
                Guid = x.DocumentGUID,
                RelativePath = pageUrlRetriever.Retrieve(x).AbsoluteUrl,

            });
            Debug.WriteLine(sampleData);

            // Prepares a collection of view models containing required data of the media files
            IEnumerable<HierarchicalWidgetViewModel> model = sampleData.Select(
                    menus => new HierarchicalWidgetViewModel
                    {
                        MenuName = menus.Name,
                        MenuGuid = menus.Guid,
                        MenuItemRelativeUrl = menus.RelativePath,
                    }
            ); 


            return View("~/Components/PageBuilder/Widgets/HierarchicalWidget/Default.cshtml", model);

        }
  
    }
    }


