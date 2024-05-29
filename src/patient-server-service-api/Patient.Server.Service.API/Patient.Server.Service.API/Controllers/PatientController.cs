
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Patient.Server.Service.API.Models;
using Patient.Server.Service.API.RequestModels;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Patient.Server.Service.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        // GET api/<PatientController>/5
        [Authorize]
        [HttpGet("{id}")]
        public IEnumerable<PatientViewModel> Get(int id)
        {
            var patients = new List<PatientViewModel> {
            new() {
                Firstname = "Ricky",
                Lastname = "Citizen",
                Address = "1111 Bourke Street",
                AttendeeEmail = "srikaran82@gmail.com",
                Suburb = "Melbourne",
                Country = "",
                Dob = "01/01/1981",
                Gender = "Male",
                Id = "c0b7bb14-edc3-4780-92de-95650ae2f5da",
                Phone = "03 1111 2222",
                PostCode = "3000",
                State = "VIC",
                MedicareNumber = "",
                IRN = ""
            }
            };
            return patients;
        }

        // GET api/<PatientController>/email
        [HttpPost]
        [Route("GetAttendeeForInvoice")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public PatientViewModelForInvoice GetAttendeeForInvoice(int bookingId, int attendeeId)
        {
            return new PatientViewModelForInvoice
            {
                Firstname = "Ricky",
                Lastname = "Citizen",
                Address = "1111 Bourke Street",
                Suburb = "Melbourne",
                Country = "",
                PostCode = "3000",
                State = "VIC",
            };
        }

        // POST api/<PatientController>
        [HttpPost]
        [Route("addOrUpdateAttendee")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> AddOrUpdateAttendee([FromBody] IEnumerable<BookedAttendeesRequestModel> request, CancellationToken ct = default)
        {
            var result = new StockOnHandUpdatedResponse
            {
                IsErrored = false,
                ErrorMessage = string.Empty
            };
            return Ok(result);
        }
    }
}
