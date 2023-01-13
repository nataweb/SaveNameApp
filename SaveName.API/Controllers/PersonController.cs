using Microsoft.AspNetCore.Mvc;
using SaveName.API.Models.Domain;
using SaveName.API.Repositories;
using SaveName.API.Repository;

namespace SaveName.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
           _personRepository = personRepository;
        }
        [HttpGet]  
        public IActionResult GetAll()
        {
           var personData = _personRepository.GetAll();

            return Ok(personData);
        }
        
    }
}
