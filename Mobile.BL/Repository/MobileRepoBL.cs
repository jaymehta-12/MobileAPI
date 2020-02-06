
using AutoMapper;
using Mobile.BL.Interface;
using Mobile.BL.Model;
using Mobile.DL.Enity;
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
        public MobileBL GetMobileItemsIDBL(int id)
        {
            var mobile = _mapper.Map<MobileBL>(_mobileRepoDL.GetMobileIDDL(id));
            return mobile;
        }

        public MobileBL AddMobileBL(MobileBL mobile)
        {
            var m = _mapper.Map<MobileBL>(_mobileRepoDL.AddMobileDL(_mapper.Map<MobileItems>(mobile)));
            return m;

        }

        public MobileBL PutMobileBL(int id,MobileBL mobile)
        {
            var m = _mapper.Map<MobileBL>(_mobileRepoDL.PutMobileDL(id,_mapper.Map<MobileItems>(mobile)));

            return m;
        }
        public MobileBL DeleteMobileBL(int id)
        {
            var delete = _mapper.Map<MobileBL>(_mobileRepoDL.DeleteMobileDL(id));
            return delete;
        }
    }
}
