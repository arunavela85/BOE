using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dcboe.Components.Widgets.NewsWidget
{
    public class NewsWidgetViewModel
    {      
        public string NewsTitle { get; set; }
        public string NewsSummary { get; set; }

        public Guid NewsTeaser { get; set; }
        public DateTime NewsReleaseDate { get; set; }
        public bool EmailToSubscribers { get; set; }
        public int currentPage { get; set; }
        public IEnumerable<int> pagination { get; set; }
        public string SearchString { get; set; }


    }
}
