using Mobile.Interface;
using Mobile.Model;
using Mobile.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Mobile.DL.Enity;
using Mobile.DL.Entity;

namespace Mobile.AutoMapper
{
    public class Automapper : Profile
    {

        public Automapper()
        {
            CreateMap<MobileAPI, MobileBL>().ReverseMap();
            CreateMap<MobileBL, MobileItems>().ReverseMap();
            CreateMap<AccessoryAPI, AccessoryBL>().ReverseMap();
            CreateMap<AccessoryBL, AccessoryItems>().ReverseMap();
        }
    }
}
