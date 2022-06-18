using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

using CMS.Core;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Routing;

using Kentico.Content.Web.Mvc;

using dcboe.Models;
using System.Diagnostics;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.CMS;

namespace dcboe.ViewComponents
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private readonly IPageRetriever pageRetriever;
        private readonly IPageUrlRetriever pageUrlRetriever;

        public NavigationMenuViewComponent(IPageRetriever pageRetriever, IPageUrlRetriever pageUrlRetriever)
        {
            // Initializes instances of required services using dependency injection
            this.pageRetriever = pageRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
        }

        public  IViewComponentResult Invoke(string menuType)
        {
            Debug.WriteLine(menuType);
            IEnumerable<TreeNode> menuItems = new MultiDocumentQuery()                                 
                                  .WithCoupledColumns()
                                  .OrderBy("NodeLevel, NodeOrder, NodeName")
                                  .LatestVersion();
            Debug.WriteLine(menuItems);
            // Retrieves a collection of page objects with data for the menu (pages of all page types)
           
            // Creates a collection of view models based on the menu item data
            IEnumerable<MenuItemViewModel> model = menuItems.Select(item => new MenuItemViewModel()
            {
                MenuItemID = item.GetValue("MenuItemID", 0),
                MenuItemGroup = item.GetValue("MenuItemGroup", ""),
                IsMegamenu = item.GetValue("IsMegamenu", false),
                MenuItemParentID = item.GetValue("MenuItemParentID", 0),
                MenuItemText = item.DocumentName,
                MenuItemRelativeUrl = pageUrlRetriever.Retrieve(item).RelativePath,
                isHeading = item.GetValue("isHeading", false),
                hasChild = item.GetValue("hasChild", false),

                menuType = menuType

            });

            return View(model);
        }
    }
}
