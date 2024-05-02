
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Patient.Server.Service.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Patient.Server.Service.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        // GET: api/<PatientController>
        [HttpGet]
        public IEnumerable<PatientViewModel> Get()
        {
            return [ new PatientViewModel { }, new PatientViewModel { }
            ];
        }

        // GET api/<PatientController>/5
        [Authorize]
        [HttpGet("{id}")]
        public PatientViewModel Get(int id)
        {
            return new PatientViewModel
            {
                Firstname = "Ricky",
                Lastname = "Citizen",
                Address = "1111 Bourke Street",
                AttendeeEmail = "srikaran82@gmail.com",
                City = "Melbourne",
                Country = "",
                Dob = "01/01/1981",
                Gender = "Male",
                Id = "c0b7bb14-edc3-4780-92de-95650ae2f5da",
                Phone = "03 1111 2222",
                PostCode = "3000",
                State = "VIC"
            };
        }

        // GET api/<PatientController>/email
        [HttpGet("{email}, {user}")]
        public PatientViewModel GetByEmail(string email, string user)
        {
            return new PatientViewModel
            {

            };
        }

        // POST api/<PatientController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
