using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace dcboe.Components.Widgets.SlideShowWidget
{
    public class SlideShowWidgetProperties : IWidgetProperties
    {
        public const string MEDIA_LIBRARY_NAME = "HomeSlideshow";


       
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Label = "Background image", Order = 1)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.LibraryName), MEDIA_LIBRARY_NAME)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.png;.jpg;.jpeg")]
        [Required]
        public IEnumerable<MediaFilesSelectorItem> Image { get; set; } = new List<MediaFilesSelectorItem>();

    }
}
