using System;
using System.Globalization;

//==========================================
//Title:  Random User Generator
//Author: Robert Wildgoose
//Date:   15 Dec 2018
//==========================================

namespace RandomUserLib.Helpers
{
    public static class StringFormatingHelper
    {
        public static string FormatTitleCase(string title)
        {
            return new CultureInfo("en-US", false).TextInfo.ToTitleCase(title.ToLower());
        }
    }
}
