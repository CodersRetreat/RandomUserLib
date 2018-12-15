using System;
using RandomUserLib.Helpers;

//==========================================
//Title:  Random User Generator
//Author: Robert Wildgoose
//Date:   15 Dec 2018
//==========================================

namespace RandomUserLib.Models
{

    public class PersonaName
    {
        public string title { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public string FormattedName{
            get{
                return StringFormatingHelper.FormatTitleCase(title) + " " + StringFormatingHelper.FormatTitleCase(first) + " " + StringFormatingHelper.FormatTitleCase(last);
            }
        }
    }
}