using Microsoft.AspNetCore.Mvc;

using CMS.DocumentEngine;

using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;

using dcboe.Models.PageBuilder;
using dcboe.Controllers;

// Registers a route for handling requests that target pages of the 'LearningKit.PageBuilderAdvanced' type
[assembly: RegisterPageRoute("dcboe.PageBuilderAdvanced", typeof(PageBuilderController))]

namespace dcboe.Controllers
{
    public class PageBuilderController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;

        public PageBuilderController(IPageDataContextRetriever pageDataContextRetriever)
        {
            this.pageDataContextRetriever = pageDataContextRetriever;
        }

        public IActionResult Index()
        {
            TreeNode page = pageDataContextRetriever.Retrieve<TreeNode>().Page;
            var model = new PageBuilderModel()
            {
                HeadingText = page.DocumentName
            };

            return View("PageBuilder", model);
        }
    }
}
