using System.IO;
using Microsoft.Azure.WebJobs;
using WebJob1.Implementations;

namespace WebJob1
{
    public class Functions
    {
        private readonly IStringGenerator _stringGenerator;

        public Functions(IStringGenerator strGenerator)
        {
            // The Job Activator will inject the Concrete type (defined in the container) into this class
            _stringGenerator = strGenerator;
        }

        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        public void ProcessQueueMessage([QueueTrigger("queue")] string message, TextWriter log)
        {
            log.WriteLine(message);

            // This will print out "Hello" to our Azure WebJob log
            log.WriteLine(_stringGenerator.GetWord());
        }
    }
}
