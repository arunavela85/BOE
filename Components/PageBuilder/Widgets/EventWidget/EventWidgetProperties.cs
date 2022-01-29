using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace dcboe.Components.Widgets.EventWidget
{
    public class EventWidgetProperties : IWidgetProperties
    {


        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 0, Label = "Show More Button")]
        public bool ShowButton { get; set; } = false;

    }
}
