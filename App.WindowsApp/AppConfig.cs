using System.Configuration;
using App.Core.Services;

namespace App.WindowsApp
{
    internal static class AppConfig
    {
        public static string ConnectionString =>
            ConfigurationManager
            .ConnectionStrings["CricketDB"]
            .ConnectionString;

        public static DbPerformanceService DbPerformanceService { get; set; }
    }
}