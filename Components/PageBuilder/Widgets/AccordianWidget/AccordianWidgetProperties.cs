using dcboe.Components.FormBuilder.FormComponents.CustomDropDownFormComponent;
using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace dcboe.Components.Widgets.AccordianWidget
{
    public class AccordianWidgetProperties : IWidgetProperties
    {

        //DocSection:CustomPropertyConfiguration
        [EditingComponent(CustomDropDownComponent.IDENTIFIER, Order = 0, Label = "Menu Name")]
        public string menuName { get; set; }
        //EndDocSection:CustomPropertyConfiguration
        [EditingComponent(IntInputComponent.IDENTIFIER, Order = 0, Label = "Submenu Level")]

        public int subMenu { get; set; } = 1;


    }
}
