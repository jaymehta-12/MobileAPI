using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mobile.BL.Model;
namespace Mobile.BL.Interface
{
   public interface IMobileBL
    {
        IEnumerable<MobileBL> GetMobileItemsBL();

       MobileBL GetMobileItemsIDBL(int id);

        MobileBL AddMobileBL(MobileBL mobile);

        MobileBL PutMobileBL(int id, MobileBL mobile);

        MobileBL DeleteMobileBL(int id);

    }
}
