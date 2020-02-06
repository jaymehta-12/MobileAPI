using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Mobile.BL.Interface;
using Mobile.BL.Model;
using Mobile.Interface;
using Mobile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile.MobileRepoAPI
{
    public class Class : IMobileAPI
    {
        private IMapper _mapper;
        private IMobileBL _mobileRepoBL;

        public Class(IMapper mapper,IMobileBL mobileRepoBL)
        {
            _mapper = mapper;
            _mobileRepoBL = mobileRepoBL;
        }
        public IEnumerable<MobileAPI> GetMobile()
        {
            var mobile = _mapper.Map <IEnumerable < MobileAPI >> (_mobileRepoBL.GetMobileItemsBL());
            return mobile;

        }

        public MobileAPI GetMobileID(int id)
        {
            var mobile = _mapper.Map<MobileAPI>(_mobileRepoBL.GetMobileItemsIDBL(id));
            return mobile;

        }

        public MobileAPI AddMobile(MobileAPI mobile)
        {
            var m = _mapper.Map < MobileAPI > (_mobileRepoBL.AddMobileBL(_mapper.Map<MobileBL>(mobile)));
            return m;
        }

        public MobileAPI PutMobile(int id, MobileAPI mobile)
        {
            var put = _mapper.Map<MobileAPI>(_mobileRepoBL.PutMobileBL(id,_mapper.Map<MobileBL>(mobile)));
            return put;
        }

        public MobileAPI DeleteMobile(int id)
        {
            var delete = _mapper.Map<MobileAPI>(_mobileRepoBL.DeleteMobileBL(id));
            return delete;
        }
    }
}
