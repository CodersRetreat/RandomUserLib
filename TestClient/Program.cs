using System;
using System.Collections.Generic;
using System.Linq;
using RandomUserLib.Enumerations;
using RandomUserLib.Models;
using RandomUserLib.Services;

namespace TestClient
{
    class MainClass
    {
        public static string FormattedName { get; private set; }

        public static void Main(string[] args)
        {
            Console.WriteLine("Test One : Single User Service");
            var SingleUser = UserGeneratorService.GetSingleUser().results.ElementAtOrDefault(0);
            Console.WriteLine("USER FOUND: " + SingleUser.name.FormattedName);

            Console.WriteLine("Test Two : Multiple Users Service");
            var MultiUser = UserGeneratorService.GetMultipleUsers(10).results.Count;
            Console.WriteLine("USERS FOUND: " + MultiUser);

            Console.WriteLine("Test Three : Single Spanish User Service");
            var SpanishUser = UserGeneratorService.GetSingleUserSpecificNationality(Nationality.Spain).results.ElementAtOrDefault(0);
            Console.WriteLine("SPANISH USER FOUND: " + SpanishUser.name.FormattedName);

            Console.WriteLine("Test Four : Single Spanish User Service");
            var MultipleSpanishUser = UserGeneratorService.GetMultiUsersSpecificNationality(Nationality.Spain,10).results.Count;
            Console.WriteLine(MultipleSpanishUser + "SPANISH USERS FOUND");

            //GetSingleUserSpecificMixedNationality
            Console.WriteLine("Test Five : Single Random Nationality User Service");
            List<string> Nationalities = new List<string>();
            Nationalities.Add(Nationality.Australia);
            Nationalities.Add(Nationality.Brazil);
            Nationalities.Add(Nationality.Canada);
            Nationalities.Add(Nationality.Denmark);
            var RandomNationalityUser = UserGeneratorService.GetSingleUserSpecificMixedNationality(Nationalities).results.ElementAtOrDefault(0);
            Console.WriteLine("Random User Is Given - " + RandomNationalityUser.nat + "As a Nationality");
        }
    }
}
