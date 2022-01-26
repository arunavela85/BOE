using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dcboe.Models
{
    public class MenuItemViewModel
    {
        public int MenuItemID { get; set; }
        public string MenuItemText { get; set; }
        public string MenuItemRelativeUrl { get; set; }
        public string MenuItemGroup { get; set; }
        public bool IsMegamenu { get; set; }
        public int MenuItemParentID { get; set; }
        public bool isHeading { get; set; }
        public bool hasChild { get; set; }
        public string menuType { get; set; }


    }
}
