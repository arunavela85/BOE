﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dcboe.Components.Widgets.HierarchicalWidget
{
    public class HierarchicalWidgetViewModel
    {      
        public string MenuName { get; set; }

        public Guid MenuGuid { get; set; }

        public string MenuItemRelativeUrl { get; set; }
        public int  MenuId { get; set; }



    }
}
