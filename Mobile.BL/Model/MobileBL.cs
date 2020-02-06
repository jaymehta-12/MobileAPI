using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.BL.Model
{
    public class MobileBL
    {
        public int MobileItemsId { get; set; }

        public string MobileName { get; set; }

        public int MobilePrice { get; set; }
        public string Image { get; set; }
        public List<AccessoryBL> AccessoryItems { get; set; }
    }
}
