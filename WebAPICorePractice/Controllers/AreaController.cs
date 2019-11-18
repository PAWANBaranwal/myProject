using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
namespace WebAPICorePractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        AreaRepository areaRepository = new AreaRepository();

        [HttpGet]
        [Route("getArea")]
        public IEnumerable<AreaMaster> getArea()
        {
            return areaRepository.GetArea();
        }

        [HttpPost]
        [Route("AddArea")]
        public int AddArea(AreaMaster areaMaster)
        {
            return areaRepository.AddArea(areaMaster);
        }
    }
}