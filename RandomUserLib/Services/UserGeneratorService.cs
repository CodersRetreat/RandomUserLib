using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RandomUserLib.Constants;
using RandomUserLib.Enumerations;
using RandomUserLib.Helpers;
using RandomUserLib.Models;

namespace RandomUserLib.Services
{
    public class UserGeneratorService
    {
        public static InfoResponce GetSingleUser()
        {
            return JsonConvert.DeserializeObject<InfoResponce>(GetDataFromApi(WebUrls.SingleUserReturn));

        }

        public static InfoResponce GetSpecificUser(string seed)
        {
            return JsonConvert.DeserializeObject<InfoResponce>(GetDataFromApi(WebUrls.SingleUserReturn+"?seed="+seed));
        }

        public static InfoResponce GetMultipleUser(int amountOfUsers)
        {
            return JsonConvert.DeserializeObject<InfoResponce>(GetDataFromApi(WebUrls.SingleUserReturn + "?results=" + amountOfUsers));

        }

        public static InfoResponce GetSingleUserSpecificNationality(string nationality)
        {
            return JsonConvert.DeserializeObject<InfoResponce>(GetDataFromApi(WebUrls.SingleUserReturn + "?nat=" + nationality));
        }

        public static InfoResponce GetMultiUserSpecificNationality(string nationality,int amountOfUsers)
        {
            return JsonConvert.DeserializeObject<InfoResponce>(GetDataFromApi(WebUrls.SingleUserReturn + "?nat=" + nationality+ "&results="+ amountOfUsers));
        }

        public static InfoResponce GetSingleUserSpecificMixedNationality(List<string> nationalities)
        {
            return JsonConvert.DeserializeObject<InfoResponce>(GetDataFromApi(WebUrls.SingleUserReturn + "?nat=" + UrlFormingHelper.ProduceMultiNationalities(nationalities)));
        }

        public static InfoResponce GetMultiUserSpecificMixedNationality(List<string> nationalities, int amountOfUsers)
        {
            return JsonConvert.DeserializeObject<InfoResponce>(GetDataFromApi(WebUrls.SingleUserReturn + "?nat=" +UrlFormingHelper.ProduceMultiNationalities(nationalities) + "&results=" + amountOfUsers));
        }

        private static string GetDataFromApi(string url)
        {
            string JsonData;
            using (WebClient wc = new WebClient())
            {
                JsonData = wc.DownloadString(url);
            }
            return JsonData;
        }
    }
}
