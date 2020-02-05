using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mobile.Model;
namespace Mobile.Model
{
    public class MobileAPI
    {
        public int MobileItemsId { get; set; }

        public string MobileName { get; set; }

        public int MobilePrice { get; set; }

        public string Image { get; set; }

        public List<AccessoryAPI> AccessoryItems { get; set; }
    }
}
