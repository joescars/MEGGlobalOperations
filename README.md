#  MEGGlobalOperations

### Authors: Joe Raio, Dave Voyles, David Crook
### Site: [JoeRaio.com](http://joeraio.com/) | [DaveVoyles.com](http://www.davevoyles.com) | [DaCrook.com](http://www.dacrook.com)
### Twitter: [@JoeScars](http://www.twitter.com/JoeScars) | [@DaveVoyles](http://www.Twitter.com/DaveVoyles)  | [@Data4Bots](http://www.twitter.com/data4bots)

Proof of Concept for MGO

--------------------------

## Requirements

- [Visual Studio 2015](https://www.visualstudio.com/downloads/)
- [Kinect 2 sensor](https://www.amazon.com/Microsoft-Kinect-for-Windows-V2/dp/B00KZIVEXO) 
- [Azure subscription](https://azure.microsoft.com/en-us/offers/ms-azr-0044p/)

## Directions

1. Attach Kinect 
2. Restore NuGet packages [*(Microsoft.Kinect)*](https://www.nuget.org/packages/Microsoft.Kinect/)
3. Run in Visual Studio

This application works as follows:

1. Track a user's skeleton
2. Save the video as .jpg frames
3. Zip up the frames
4. Upload to Azure blob storage

Stand back from the Kinect camera, and watch as it tracks your skeleton. You'll know it works when the debug message appears at the 
bottom of the screen, notifying you that it is recording frames and then uploading to blob storage. 


### Azure Requirements

You need to replace your *BlobConnString* in MainWindow.xaml.cs with your own 
[Azure Blob Storage Connection String.](https://docs.microsoft.com/en-us/azure/storage/storage-configure-connection-string)
in order to connect to your Blob Storage account, where the zipped up frames will remain. 

![alt tag](https://github.com/DaveVoyles/kinect-skeletal-blob-upload/blob/master/KinectApp/Images/KinectSkeletalTracker.PNG)
