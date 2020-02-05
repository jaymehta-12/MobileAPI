using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.BL.Model
{
    class AccessoryBL
    {
        public int AccessoryItemsId { get; set; }
        public string AccessoryName { get; set; }

        public int AccessoryPrice { get; set; }

        public int MobileItemsId { get; set; }
        public List<AccessoryBL> AccessoryItems { get; set; }
    }
}
