// Default URL for triggering event grid function in the local environment.
// http://localhost:7071/runtime/webhooks/EventGrid?functionName={functionname}

using System;
using Azure.Messaging;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Patient.Server.Service.Funcz
{
    public class KeyVault
    {
        private readonly ILogger<KeyVault> _logger;

        public KeyVault(ILogger<KeyVault> logger)
        {
            _logger = logger;
        }

        [Function(nameof(KeyVault))]
        public void Run([EventGridTrigger] CloudEvent cloudEvent)
        {
            _logger.LogInformation("Event type: {type}, Event subject: {subject}", cloudEvent.Type, cloudEvent.Subject);
        }
    }
}
