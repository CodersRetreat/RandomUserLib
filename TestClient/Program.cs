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
            var Users = UserGeneratorService.GetSingleUser() as InfoResponce;
            var SingleUser = Users.results.ElementAtOrDefault(0);
            Console.WriteLine(Users.results.Count + " User Found.");
            Console.WriteLine("FOUND:" + SingleUser.name.FormattedName);
        }
    }
}
