using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneConnectionConfig;

namespace LOTRAutomation;

internal class AndroidCommands
{
    public static void Startup()
    {
        ADBClient myClient = new ADBClient();
        myClient.AdbPath = @"C:\Users\andrewpalmer\Documents\CloudRepos\packages\platform-tools\adb.exe";

        TakeScreenShotTest(myClient);

        string dir = Directory.GetCurrentDirectory();
        string path = dir + @"\..\..\..\data";

        var device = myClient.Devices()[0];

        Console.ReadKey();
    }

    public static void TakeScreenShotTest(ADBClient myClient)
    {
        string dir = Directory.GetCurrentDirectory();
        string path = dir + @"\..\..\..\data";

        var device = myClient.Devices()[0];

        Console.WriteLine($"{device}");

        myClient.ScreenCap(path);

        myClient.Execute("input touchscreen swipe 500 500 500 1000 2000", false);

        myClient.Execute(@"screencap /sdcard/Pictures/Screenshots/Screenshot_manual.png", false);

        myClient.Pull(@"/sdcard/Pictures/Screenshots/Screenshot_manual.png", @"C:\users\andrewpalmer\documents");
    }

    public static void SwipeUp(ADBClient myClient)
    {
        myClient.Execute("input touchscreen swipe 500 500 500 1000 2000", false);
    }
}
