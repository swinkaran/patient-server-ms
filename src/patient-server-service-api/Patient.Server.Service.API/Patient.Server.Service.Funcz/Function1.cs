using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Patient.Server.Service.Funcz
{
    public class Function1
    {
        //
        private readonly ILogger<Function1> _logger;
        public class MyData
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public Function1(ILogger<Function1> logger)
        {
            _logger = logger;
        }

        [Function("Function1")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to default patient Rsvp server!");
        }

        [Function("AddUpdatePatients")]
        public static async Task<IActionResult> RunFunctionPost(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = "AddUpdatePatients/")] HttpRequest req,
        ILogger log)
        {
            //log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            MyData data = new MyData { Name = "Teehee", Age = 41 };

            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            string name = data == null ? string.Empty : data.Name;
            return name != null
                ? (ActionResult)new OkObjectResult($"Patient profile booking details updated")
                : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
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
