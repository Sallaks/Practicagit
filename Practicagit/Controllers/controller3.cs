using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practicagit.Models;

namespace Practicagit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class controller3 : ControllerBase
    {
        public static List<Contact> FakeContact = new List<Contact>()
        {
            new Contact()
            {   Name = "kaeddkka",
                CelularNumber = 123313131,
                TelephoneNumber= 2132123133123,
                Id = 3

            },

             new Contact()
             {

                Name = "dasdad",
                CelularNumber = 12313312311311,
                TelephoneNumber= 231332123131,
                Id = 4

             },

        };

        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok(FakeContact);
        }
    }
}
//RAMA 3
