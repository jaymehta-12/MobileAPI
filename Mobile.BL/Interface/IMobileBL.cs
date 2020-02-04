using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Mobile.BL.Model;
namespace Mobile.BL.Interface
{
   public interface IMobileBL
    {
        IEnumerable<MobileBL> GetMobileItemsBL();
    }
}
