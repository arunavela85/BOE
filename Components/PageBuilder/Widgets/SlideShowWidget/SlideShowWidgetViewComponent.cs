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



[assembly: RegisterWidget(SlideShowWidgetViewComponent.IDENTIFIER, typeof(SlideShowWidgetViewComponent), "Slide Show", typeof(SlideShowWidgetProperties), Description = "Displays an image", IconClass = "icon-badge")]

namespace dcboe.Components.Widgets.SlideShowWidget
{

    public class SlideShowWidgetViewComponent : ViewComponent
        {

        private readonly IMediaFileUrlRetriever mediaFileUrlRetriever;

        public const string IDENTIFIER = "dcboe.Components.Widgets.SlideShowWidget";


        public SlideShowWidgetViewComponent(IMediaFileUrlRetriever mediaFileUrlRetriever)
        {
            this.mediaFileUrlRetriever = mediaFileUrlRetriever;
        }

        [Obsolete]
        public ViewViewComponentResult Invoke(SlideShowWidgetProperties properties)
            {
            MediaLibraryInfo mediaLibrary = MediaLibraryInfoProvider.GetMediaLibraryInfo("HomeSlideshow", SiteContext.CurrentSiteName);

            // Gets a collection of media files with the .jpg extension from the media library
            IEnumerable<MediaFileInfo> mediaLibraryFiles = MediaFileInfoProvider.GetMediaFiles()
                .WhereEquals("FileLibraryID", mediaLibrary.LibraryID)
                .WhereEquals("FileExtension", ".jpg");

            // Prepares a collection of view models containing required data of the media files
            IEnumerable<SlideShowWidgetViewModel> model = mediaLibraryFiles.Select(
                    mediaFile => new SlideShowWidgetViewModel
                    {
                        FileTitle = mediaFile.FileTitle,
                        DirectUrl = MediaLibraryHelper.GetDirectUrl(mediaFile),
                        PermanentUrl = MediaLibraryHelper.GetPermanentUrl(mediaFile)
                    }
            );


            return View("~/Components/PageBuilder/Widgets/SlideShowWidget/Default.cshtml", model);
            
            }

        
    }
    }


