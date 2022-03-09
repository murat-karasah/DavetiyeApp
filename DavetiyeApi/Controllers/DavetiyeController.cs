using DavetiyeBusiness.Abstract;
using DavetiyeEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavetiyeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DavetiyeController : ControllerBase
    {
        private IDavetiyeService davetiyeService;
        public DavetiyeController(IDavetiyeService _davetiyeService)
        {
            davetiyeService = _davetiyeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var davetiyes = davetiyeService.GetAll();
            return Ok(davetiyes);
        }
        [HttpGet]
        [Route("action")]
        public IActionResult GetAllFiltre(bool v)
        {
            var davetiyes = davetiyeService.GetAllFiltre(v);
            return Ok(davetiyes);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var davetiye = davetiyeService.GetById(id);
            if (davetiye!=null)
            {
                return Ok(davetiye);
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult Create(Davetiye davetiye)
        {
            if (ModelState.IsValid)
            {
                davetiyeService.CreateD(davetiye);
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (davetiyeService.GetById(id)!=null)
            {
                davetiyeService.DeleteDavetiye(id);
                return Ok();
            }
            return BadRequest(ModelState);

        }
    }
}


//List<Davetiye> GetAll();
//Davetiye GetById(int id);
//Davetiye Create(Davetiye davetiye);
//void DeleteDavetiye(int id);