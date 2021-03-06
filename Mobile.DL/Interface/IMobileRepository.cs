﻿using Mobile.DL.Enity;
using Mobile.DL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.DL.Interface
{
    public interface IMobileRepository
    {

        IEnumerable<MobileItems> GetMobileDL();
        MobileItems GetMobileIDDL(int id);

        MobileItems AddMobileDL(MobileItems mobile);

        MobileItems PutMobileDL(int id,MobileItems mobile);

        MobileItems DeleteMobileDL(int id);

        
    }
}
