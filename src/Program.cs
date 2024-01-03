using System.Security.Authentication.ExtendedProtection;
using LOTRAutomation.AndroidConfiguration;
using Microsoft.Extensions.DependencyInjection;

namespace LOTRAutomation;

public class Program
{
    public static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IAndroidConfig, AndroidConfig>()
            .AddSingleton<IAutomationStart, AutomationStart>()
            .BuildServiceProvider();

        var connection = serviceProvider.GetService<IAndroidConfig>();
        var service = serviceProvider.GetService<IAutomationStart>();
        connection.Connect();
        service.Start();
    }
}