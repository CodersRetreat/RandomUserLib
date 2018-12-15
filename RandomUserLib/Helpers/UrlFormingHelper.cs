using System;
using System.Collections.Generic;
using System.Net;

//==========================================
//Title:  Random User Generator
//Author: Robert Wildgoose
//Date:   15 Dec 2018
//==========================================

namespace RandomUserLib.Helpers
{
    public class UrlFormingHelper
    {
        public static string ProduceMultiNationalities(List<string> nationalities)
        {
            string nations= "";
            foreach (var item in nationalities)
            {
                nations = item + ",";
            }
            return nations.Substring(0, nations.Length - 1);
        }
        public static string ProduceJsonStringFromUrl(string url)
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
