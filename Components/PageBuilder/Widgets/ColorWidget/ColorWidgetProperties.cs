using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

using dcboe.Components.FormBuilder.FormComponents.ColorFormComponent;

namespace dcboe.Components.PageBuilder.Widgets.ColorWidget
{
    public class ColorWidgetProperties : IWidgetProperties
    {
        [EditingComponent(ColorFormComponent.IDENTIFIER, Order = 0, Label = "Color")]
        public string Color { get; set; } = "white";
    }
}