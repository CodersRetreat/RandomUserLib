using System;
using System.Linq;
using RandomUserLib.Models;
using RandomUserLib.Services;

namespace TestClient
{
    class MainClass
    {
        public static string FormattedName { get; private set; }

        public static void Main(string[] args)
        {
            Console.WriteLine("Getting Single User");
            var SingleUser = UserGeneratorService.GetSingleUser().results.ElementAtOrDefault(0);
            Console.WriteLine("FOUND: " + SingleUser.name.FormattedName);
            var MultipleUsers = UserGeneratorService.GetMultipleUsers(10).results;
        }
    }
}
