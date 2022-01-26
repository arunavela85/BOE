using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

using dcboe.Components.PageBuilder.Widgets.ColorWidget;
using dcboe.Components.PageBuilder.Widgets.NumberWidget;
using dcboe.Components.FormBuilder.FormSections.TitledSection;

// ================================= Form builder registrations ====================================

[assembly: RegisterFormSection("dcboe.FormSections.CustomSection", 
                               "Custom section",
                               customViewName: "~/Components/FormBuilder/FormSections/CustomFormSection.cshtml")]

[assembly: RegisterFormSection("dcboe.FormSections.TitledSection", 
                               "Titled section",
                               customViewName: "~/Components/FormBuilder/FormSections/TitledSection/TitledSection.cshtml",
                               PropertiesType = typeof(TitledSectionProperties))]

// ================================= Page builder registrations ====================================

//DocSection:ExampleSection
[assembly: RegisterSection("dcboe.Sections.CustomSection",
                          "Custom section",
                          typeof(CustomSectionProperties),
                          customViewName: "~/Components/PageBuilder/Sections/CustomSection/_CustomSection.cshtml",
                          IconClass = "icon-square")]
//EndDocSection:ExampleSection
//DocSection:ExampleSection
[assembly: RegisterSection("dcboe.Sections.TextSection",
                          "Text section",
                          typeof(TextSectionProperties),
                          customViewName: "~/Components/PageBuilder/Sections/TextSection/_TextSection.cshtml",
                          IconClass = "icon-square")]
//DocSection:ExampleWidget
[assembly: RegisterWidget("dcboe.Widgets.NumberWidget",
                         "Number selector",
                         typeof(NumberWidgetProperties),
                         customViewName: "~/Components/PageBuilder/Widgets/NumberWidget/_NumberWidget.cshtml")]
//EndDocSection:ExampleWidget

[assembly: RegisterWidget("dcboe.Widgets.ColorWidget",
                            "Colored widget", 
                            typeof(ColorWidgetProperties), 
                            customViewName: "~/Components/PageBuilder/Widgets/ColorWidget/_ColorWidget.cshtml", 
                            IconClass = "icon-palette")]

// Registers the default page builder section used by the LearningKit project
[assembly: RegisterSection("dcboe.Sections.DefaultSection",
                           "Default section", 
                           customViewName: "~/Components/PageBuilder/Sections/_DefaultSection.cshtml", 
                           IconClass = "icon-square")]
// Registers a two-column section that splits the page down the middle
[assembly: RegisterSection("dcboe.Sections.Col2",
                           "2 Columns", 
                           customViewName: "~/Components/PageBuilder/Sections/_Col2.cshtml")]
// Registers a three-column section that splits the page down the middle

[assembly: RegisterSection("dcboe.Sections.Col3",
                           "3 Columns",
                           customViewName: "~/Components/PageBuilder/Sections/_Col3.cshtml")]
// Registers the 'Extended form' widget
[assembly: RegisterWidget("dcboe.Widgets.ExtendedFormWidget",
                          "Extended form",
                          typeof(ExtendedFormWidgetProperties),
                          customViewName: "~/Components/PageBuilder/Widgets/ExtendedFormWidget/_ExtendedFormWidget.cshtml",
                          IconClass = "icon-form")]
