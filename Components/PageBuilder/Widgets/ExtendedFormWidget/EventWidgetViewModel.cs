using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dcboe.Components.Widgets.EventWidget
{
    public class EventWidgetViewModel
    {      
        public string title { get; set; }

        public string url { get; set; }

        public DateTime start { get; set; }
        public bool showButton { get; set; }


    }
}
