using System;
using System.Configuration;
using Twilio;

public static void Run(string myQueueItem, TraceWriter log)
{
    log.Info($"C# Queue trigger function processed: {myQueueItem}");

    string msg = myQueueItem;

    // Setup Twilio
    string AccountSid = ConfigurationManager.AppSettings["TwilioAccountSID"];
    string AuthToken = ConfigurationManager.AppSettings["TwilioAuthToken"];
    var twilio = new TwilioRestClient(AccountSid, AuthToken);

    // Send to Twilio
    log.Info("Attempting to Send Message");
    var message = twilio.SendMessage(
        ConfigurationManager.AppSettings["TwilioFrom"],
        ConfigurationManager.AppSettings["TwilioTo"],
        msg
    );

    log.Info("Message sent with ID: " + message.Sid);
}