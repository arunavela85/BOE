﻿using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;


public class TextSectionProperties : ISectionProperties
{
    // Defines a property and sets its default value
    // Assigns the default Xperience text input component, which allows users to enter
    // a string value for the property in the section's configuration dialog
    [EditingComponent(TextInputComponent.IDENTIFIER, Order = 0, Label = "Heading")]
    public string Heading { get; set; } = "Default";
}