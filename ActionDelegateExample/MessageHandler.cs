using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegateExample
{
    public class MessageHandler
    {
        // Method that accepts an Action<RequestMessage> callback
        public void ProcessRequest(string messageContent, Action<RequestMessageWithParameter> callback)
        {
            // Create the RequestMessage
            RequestMessageWithParameter requestMessage = new RequestMessageWithParameter { Content = messageContent };

            // Simulate some processing
            Console.WriteLine("Processing the message...");
            System.Threading.Thread.Sleep(10000);
            // After processing, invoke the callback with the request message
            callback?.Invoke(requestMessage);
        }
    }
}
