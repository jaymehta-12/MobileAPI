
using AutoMapper;
using Mobile.BL.Interface;
using Mobile.BL.Model;
using Mobile.DL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.BL.Repository
{
   public class MobileRepoBL:IMobileBL
    {
        private IMapper _mapper;
        private IMobileRepository  _mobileRepoDL;

        public MobileRepoBL(IMapper mapper,IMobileRepository mobileRepository)
        {
            _mapper = mapper;

            _mobileRepoDL = mobileRepository;
        }

        public IEnumerable<MobileBL> GetMobileItemsBL()
        {
            var mobile = _mapper.Map<IEnumerable<MobileBL>>(_mobileRepoDL.GetMobileDL());
            return mobile;
        }

    }
}
