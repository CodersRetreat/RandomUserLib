using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RandomUserLib.Constants;
using RandomUserLib.Enumerations;
using RandomUserLib.Helpers;
using RandomUserLib.Models;

//==========================================
//Title:  Random User Generator
//Author: Robert Wildgoose
//Date:   15 Dec 2018
//==========================================

namespace RandomUserLib.Services
{
    public class UserGeneratorService
    {
        public static InfoResponce GetSingleUser()
        {
            return JsonConvert.DeserializeObject<InfoResponce>(UrlFormingHelper.ProduceJsonStringFromUrl(WebUrls.SingleUserReturn));
        }

        public static InfoResponce GetSpecificUser(string seed)
        {
            return JsonConvert.DeserializeObject<InfoResponce>(UrlFormingHelper.ProduceJsonStringFromUrl(WebUrls.SingleUserReturn+"?seed="+seed));
        }

        public static InfoResponce GetMultipleUsers(int amountOfUsers)
        {
            return JsonConvert.DeserializeObject<InfoResponce>(UrlFormingHelper.ProduceJsonStringFromUrl(WebUrls.SingleUserReturn + "?results=" + amountOfUsers));

        }

        public static InfoResponce GetSingleUserSpecificNationality(string nationality)
        {
            return JsonConvert.DeserializeObject<InfoResponce>(UrlFormingHelper.ProduceJsonStringFromUrl(WebUrls.SingleUserReturn + "?nat=" + nationality));
        }

        public static InfoResponce GetMultiUsersSpecificNationality(string nationality,int amountOfUsers)
        {
            return JsonConvert.DeserializeObject<InfoResponce>(UrlFormingHelper.ProduceJsonStringFromUrl(WebUrls.SingleUserReturn + "?nat=" + nationality+ "&results="+ amountOfUsers));
        }

        public static InfoResponce GetSingleUserSpecificMixedNationality(List<string> nationalities)
        {
            return JsonConvert.DeserializeObject<InfoResponce>(UrlFormingHelper.ProduceJsonStringFromUrl(WebUrls.SingleUserReturn + "?nat=" + UrlFormingHelper.ProduceMultiNationalities(nationalities)));
        }
    }
}
