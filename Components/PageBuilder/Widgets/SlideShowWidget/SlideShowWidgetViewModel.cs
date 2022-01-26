using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dcboe.Components.Widgets.SlideShowWidget
{
    public class SlideShowWidgetViewModel
    {      
        public string FileTitle { get; set; }
        public string DirectUrl { get; set; }

        public string PermanentUrl { get; set; }


    }
}
