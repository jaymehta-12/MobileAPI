﻿using AutoMapper;
using Mobile.BL.Interface;
using Mobile.Interface;
using Mobile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile.MobileRepoAPI
{
    public class Class1:IMobileAPI
    {
        private IMapper _mapper;
        private IMobileBL _mobileRepoBL;

        public Class1()
        {
        }

        public Class1(IMapper mapper, IMobileBL mobileRepoBL)
        {
            _mapper = mapper;
            _mobileRepoBL = mobileRepoBL;
        }
        public IEnumerable<MobileAPI> GetMobile()
        {
            var mobile = _mapper.Map<IEnumerable<MobileAPI>>(_mobileRepoBL.GetMobileItemsBL());
            return mobile;

        }
    }
}