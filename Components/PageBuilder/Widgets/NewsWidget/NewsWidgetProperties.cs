using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace dcboe.Components.Widgets.NewsWidget
{
    public class NewsWidgetProperties : IWidgetProperties
    {


        [EditingComponent(IntInputComponent.IDENTIFIER, Order = 0, Label = "No of News to be displayed")]
        public int NewsCount { get; set; } = 5;

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 0, Label = "Heading")]
        public string NewsHeading { get; set; } = "News";

        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 0, Label = "Show Pagination")]
        public bool ShowPagination { get; set; } = true;

        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 0, Label = "Show Search")]
        public bool ShowSearch { get; set; } = true;

        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 0, Label = "Show More Button")]
        public bool ShowButton { get; set; } = true;



    }
}
