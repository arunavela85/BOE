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
using dcboe.Components.Widgets.NewsWidget;

[assembly: RegisterWidget(NewsWidgetViewComponent.IDENTIFIER, typeof(NewsWidgetViewComponent), "News", typeof(NewsWidgetProperties), Description = "News Listing", IconClass = "icon-badge")]

namespace dcboe.Components.Widgets.NewsWidget
{

    public class NewsWidgetViewComponent : ViewComponent
    {

        private readonly IMediaFileUrlRetriever mediaFileUrlRetriever;

        public const string IDENTIFIER = "dcboe.Components.Widgets.NewsWidget";


        public NewsWidgetViewComponent(IMediaFileUrlRetriever mediaFileUrlRetriever)
        {
            this.mediaFileUrlRetriever = mediaFileUrlRetriever;
        }

        [Obsolete]
        public ViewViewComponentResult Invoke(NewsWidgetProperties properties)
        {
            int totalItems = NewsProvider.GetNews().TotalRecords;
            int pageSize = properties.NewsCount;
            string cpage = HttpContext.Request.Query["page"];
            int currentPage = 1;
            int page = 0;
            if (cpage != null)
            {
                currentPage = int.Parse(cpage);
                page = currentPage - 1;
            }
            
            int maxPages = 10;

            var pager = new Pager(totalItems, currentPage, pageSize, maxPages );

            IEnumerable<News> newsinfo = NewsProvider.GetNews().Page(page, pageSize);


            // Prepares a collection of view models containing required data of the media files
            IEnumerable<NewsWidgetViewModel> model = newsinfo.Select(
                    news => new NewsWidgetViewModel
                    {
                        NewsTitle = news.NewsTitle,
                        EmailToSubscribers = news.EmailToSubscribers,
                        NewsSummary = news.NewsSummary,
                        NewsTeaser = news.NewsTeaser,
                        NewsReleaseDate = news.NewsReleaseDate,
                        currentPage = int.Parse(cpage != null ? cpage : "1"),
                        pagination = pager.Pages
                    }
            ); ;


            return View("~/Components/PageBuilder/Widgets/NewsWidget/Default.cshtml", model);

        }
        
       }
    }


