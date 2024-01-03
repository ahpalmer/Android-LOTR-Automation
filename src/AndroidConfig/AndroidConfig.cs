using PhoneConnectionConfig;
using LOTRAutomation;

namespace LOTRAutomation.AndroidConfiguration;

public class AndroidConfig : IAndroidConfig
{
    public void Connect()
    {
        ADBClient myClient = new ADBClient();
        myClient.AdbPath = @"C:\Users\andrewpalmer\Documents\CloudRepos\packages\platform-tools\adb.exe";

        AndroidCommands.TakeScreenShotTest(myClient);

        string dir = Directory.GetCurrentDirectory();
        string path = dir + @"\..\..\..\data";

        var device = myClient.Devices()[0];

        Console.ReadKey();
    }
}
