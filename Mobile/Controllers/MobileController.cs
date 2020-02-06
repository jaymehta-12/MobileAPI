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

        public MobileController(IMobileAPI mobileRepository)
        {
            _mobileRepository = mobileRepository;
        }

        [HttpGet]
        public IEnumerable<MobileAPI> GetMobile()
        {

            var data = _mobileRepository.GetMobile();
            return data;
        }
        [HttpGet("{id}")]
        public IActionResult GetMobileID(int id)
        {
            var dataID = _mobileRepository.GetMobileID(id);
            return Ok(dataID);
        }


        [HttpPost]

        public IActionResult AddMobile([FromBody] MobileAPI mobile)
        {

            var abc = _mobileRepository.AddMobile(mobile);
            return Ok(abc);
        }

        [HttpPut("{id}")]

        public IActionResult PutMobile(int id, [FromBody] MobileAPI mobile)
        {
            var put = _mobileRepository.PutMobile(id, mobile);
            return Ok(put);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMobile(int id)
        {
            var delete = _mobileRepository.DeleteMobile(id);
            return Ok(delete);
        }
        
    }
}