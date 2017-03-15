# Face Detector

This `BlobTrigger` function detects if there are any faces in the images that are uploaded to via the Kinect. 

To do this, we use  [Microsoft Cognitive Services Face API](https://www.microsoft.com/cognitive-services/en-us/face-api).

We then write the output (number of faces) as a message to an [Azure Storage Queue](https://docs.microsoft.com/en-us/azure/storage/storage-dotnet-how-to-use-queues). The SMS Notifier function watches that queue and fires off messages from there. 

