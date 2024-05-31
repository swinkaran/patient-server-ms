using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Patient.Server.Service.Funcz
{
    public class RsvpPatient
    {
        private readonly ILogger<RsvpPatient> _logger;

        public RsvpPatient(ILogger<RsvpPatient> logger)
        {
            _logger = logger;
        }

        [Function("AddUpdatePatients")]
        public static async Task<IActionResult> RunFunctionPost(
       [HttpTrigger(AuthorizationLevel.Function, "post", Route = "AddUpdatePatients/")] HttpRequest req,
       ILogger log)
        {
            //log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            return (ActionResult)new OkObjectResult($"Patient profile booking details updated");
        }

        [Function("GetPatientsByUser")]
        public static async Task<IActionResult> GetPatientsByUser(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = "GetPatientsByUser/")] HttpRequest req,
        ILogger log)
        {
            //log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var patients = new List<PatientRequest> {
            new() {
                Firstname = "Ricky",
                Lastname = "Citizen",
                PatientProfileId="",
                BookingId ="",
                AttendeeId="",
                Address = "1111 Bourke Street",
                AttendeeEmail = "srikaran82@gmail.com",
                Suburb = "Melbourne",
                Country = "",
                Dob = "01/01/1981",
                Gender = "Male",
                Phone = "03 1111 2222",
                PostCode = "3000",
                State = "VIC",
                MedicareNumber = "",
                IRN = ""
            }
            };
            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            return (ActionResult)new OkObjectResult(patients);
        }

        [Function("GetPatientsByBooking")]
        public static async Task<IActionResult> GetPatientByBooking(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = "GetPatientsByBooking/")] HttpRequest req,
        ILogger log)
        {
            //log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var patients = new List<PatientRequest> {
            new() {
                Firstname = "Ricky",
                Lastname = "Citizen",
                PatientProfileId="",
                BookingId ="",
                AttendeeId="",
                Address = "1111 Bourke Street",
                AttendeeEmail = "srikaran82@gmail.com",
                Suburb = "Melbourne",
                Country = "",
                Dob = "01/01/1981",
                Gender = "Male",
                Phone = "03 1111 2222",
                PostCode = "3000",
                State = "VIC",
                MedicareNumber = "",
                IRN = ""
            }
            };
            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            return (ActionResult)new OkObjectResult(patients);
        }

        [Function("GetPatientsAddresses")]
        public static async Task<IActionResult> GetPatientsAddresses(
       [HttpTrigger(AuthorizationLevel.Function, "post", Route = "GetPatientsAddresses/")] HttpRequest req,
       ILogger log)
        {
            //log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var patientAddress = new List<PatientRequest> {
                new() {
                    Firstname = "Ricky",
                    Lastname = "Citizen",
                    Address = "1111 Bourke Street",
                    Suburb = "Melbourne",
                    Country = "",
                    PostCode = "3000",
                    State = "VIC",
                } };
            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            return (ActionResult)new OkObjectResult(patientAddress);
        }
    }
}
