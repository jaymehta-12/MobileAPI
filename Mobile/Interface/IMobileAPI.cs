﻿using Microsoft.AspNetCore.Mvc;
using Mobile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile.Interface
{
    public interface IMobileAPI
    {
        public IEnumerable<MobileAPI> GetMobile();
        public MobileAPI GetMobileID(int id);

        public MobileAPI AddMobile(MobileAPI mobile);

        public MobileAPI PutMobile(int id, MobileAPI mobile);

        public MobileAPI DeleteMobile(int id);

    }
}
