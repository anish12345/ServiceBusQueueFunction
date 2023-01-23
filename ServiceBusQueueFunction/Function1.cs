using System;
using System.Text;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ServiceBusQueueFunction
{
    public class Function1
    {
     //   public void Run([ServiceBusTrigger("anishqueue", Connection = "connectionString")] string myQueueItem, ILogger log)
        [FunctionName("Function1")]
        public void Run([ServiceBusTrigger("anishqueue", Connection = "connectionString")]Message queueMessage, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {0} " ,Encoding.UTF8.GetString(queueMessage.Body));
        }
    }
}
