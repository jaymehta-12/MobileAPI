using Mobile.Interface;
using Mobile.Model;
using Mobile.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Mobile.DL.Enity;

namespace Mobile.AutoMapper
{
    public class Automapper : Profile
    {

        public Automapper()
        {
            CreateMap<MobileAPI, MobileBL>();
            CreateMap<MobileBL, MobileAPI>();
            CreateMap<MobileBL, MobileItems>();
            CreateMap<MobileItems, MobileBL>();
        }
    }
}
