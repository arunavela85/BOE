using System;

namespace dcboe.Components.PageBuilder.Widgets.SelectorsWidget
{
    public class HeadingWidgetViewModel
    {
        public string MediaFileUrl { get; set; }

        public string DocumentPath { get; set; }

        public Guid? DocumentGuid { get; set; }

        public string AttachmentUrl { get; set; }
    }
}