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

        [Function("UpdateStock")]
        public static async Task<IActionResult> RunFunctionPost(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = "stock/")] HttpRequest req,
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
                ? (ActionResult)new OkObjectResult($"Hello, {name}")
                : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }
}
