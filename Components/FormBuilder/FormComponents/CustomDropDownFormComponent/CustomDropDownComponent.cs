using System.Linq;
using System.Collections.Generic;

using CMS.DocumentEngine;

using Kentico.Forms.Web.Mvc;
using Kentico.Web.Mvc;

using dcboe.Components.FormBuilder.FormComponents.CustomDropDownFormComponent;


[assembly: RegisterFormComponent(CustomDropDownComponent.IDENTIFIER,
                                 typeof(CustomDropDownComponent),
                                 "Drop-down with custom data",
                                 IconClass = "icon-menu",
                                 ViewName = "~/Components/FormBuilder/FormComponents/CustomDropDownFormComponent/_CustomDropDownComponent.cshtml")]

namespace dcboe.Components.FormBuilder.FormComponents.CustomDropDownFormComponent
{
    public class CustomDropDownComponent : SelectorFormComponent<CustomDropDownComponentProperties>
    {
        public const string IDENTIFIER = "CustomDropDownComponent";


        // Retrieves data to be displayed in the selector
        protected override IEnumerable<HtmlOptionItem> GetHtmlOptions()
        {
            // Perform data retrieval operations here
            // The following example retrieves all pages of the 'DancingGoatMvc.Article' page type 
            // located under the 'Articles' section of the Dancing Goat sample website
            DocumentQuery query = DocumentHelper.GetDocuments("CMS.MenuItem")
                                .Columns("DocumentName", "DocumentGUID","DocumentID")
                                .OnSite("dcboe")
                                .Culture("en-us")
                                .LatestVersion();
                                

            var sampleData = query.ToList().Select(x => new { Name = x.DocumentName,
                                                                 Id = x.DocumentID.ToString() });

            // Iterates over retrieved data and transforms it into SelectListItems
            foreach (var item in sampleData)
            {
                var listItem = new HtmlOptionItem()
                {
                    Value = item.Id,
                    Text = item.Name
                };

                yield return listItem;
            }


        }
    }
}