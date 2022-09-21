using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practicagit.Models;

namespace Practicagit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class controller : ControllerBase
    {
        public static List<Contact> FakeContact = new List<Contact>()
        {
            new Contact()
            {   Name = "kakka",
                CelularNumber = 12313131,
                TelephoneNumber= 213123133123,
                Id = 3

            },

             new Contact()
             {

                Name = "bababa",
                CelularNumber = 12312311311,
                TelephoneNumber= 2313123131,
                Id = 4

             },

        };

        [HttpGet]

        public IActionResult GetAll()
        {
            var contact = new Contact()
            {

                Name = "bababa",
                CelularNumber = 12312311311,
                TelephoneNumber = 2313123131,
                Id = 4

            };

            FakeContact.Add(contact);

            return Ok(FakeContact);
        }

    }
}
  

//hola soy la rama 2