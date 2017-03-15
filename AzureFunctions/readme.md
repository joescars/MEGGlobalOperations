# Azure Functions

We use two Azure Functions to review images uploaded by the Kinect and Search for faces. 

If faces are found we fire off a text message notifying the user. 

## Tools Used

- [Azure Functions](https://azure.microsoft.com/en-us/services/functions/)
- [Azure Blob Storage](https://docs.microsoft.com/en-us/azure/storage/storage-dotnet-how-to-use-blobs)
- [Azure Queue Storage](https://docs.microsoft.com/en-us/azure/storage/storage-dotnet-how-to-use-queues)
- [Twilio](https://www.twilio.com/)