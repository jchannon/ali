using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp4
{
    class Program
    {
        public static AppSettings appSettings;
        
        static void Main(string[] args)
        {
            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");

            var config = configBuilder.Build();

            appSettings = new AppSettings();
            config.Bind(appSettings);
            
            Console.WriteLine(appSettings.Foo);

        }
    }

    public  class AppSettings
    {
        public string Foo { get; set; }
    }
}