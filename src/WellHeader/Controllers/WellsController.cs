using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using WellHeader.Repositories;
using WellHeader.Interfaces;

namespace WellHeader.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WellsController : ControllerBase
    {
        private readonly ILogger<WellsController> _logger;
        //private readonly IWellRepository _repo;
        private IWellService _wellservice;

        public WellsController(ILogger<WellsController> logger, IWellService wellService)//IWellRepository repository
        {
            _logger = logger;
            //_repo = repository; 
            _wellservice = wellService; 
        }
      
        [HttpGet]
        public IActionResult Get() 
             
        {
            return Ok(_wellservice.ListWells());
                //_repo.GetAll());  
            
        }

        [HttpGet]
        [Route("[controller]/{wellid}")]
        public IActionResult Get(int wellid)
        {
            return Ok(_wellservice.GetWellByID(wellid));   
        }
    }
}