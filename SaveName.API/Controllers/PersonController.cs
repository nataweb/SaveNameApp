using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using SaveName.API.Models.Domain;
using SaveName.API.Repositories;
using SaveName.API.Repository;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace SaveName.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonRepository _personRepository;
        private readonly IDataProtector _dataProtector;
        PersonsData personsData = new PersonsData();

        public PersonController(IPersonRepository personRepository, IDataProtectionProvider dataProvider)
        {
            _personRepository = personRepository;
            _dataProtector = dataProvider.CreateProtector("So this is my secret key to encrypt and decrypt data");
        }
        [HttpGet]
        public IActionResult GetAll()
        {
          //  var personData = _personRepository.GetAll();
         //return Ok(personData);
         string  personData = "Hello Youtube";
         string encryptText = _dataProtector.Protect(personData);
        //string decryptText = _dataProtector.Unprotect(encryptText);
            return Ok(new {personData,encryptText} );

         
        }
         
        
   }
}
