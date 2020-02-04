using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobile.Interface;
using Mobile.MobileRepoAPI;
using Mobile.Model;

namespace Mobile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        private readonly IMobileAPI _mobileRepository;

        public MobileController(IEnumerable<IMobileAPI>  mobileRepository)
        {
            _mobileRepository = mobileRepository.FirstOrDefault(x => x.GetType() == typeof(Class));
        }
        [HttpGet]
        public  IEnumerable<MobileAPI> GetMobile()
        {
           
             var data=_mobileRepository.GetMobile();
            return data;
        }
    }
}