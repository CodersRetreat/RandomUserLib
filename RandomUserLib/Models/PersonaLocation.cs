using System;

//==========================================
//Title:  Random User Generator
//Author: Robert Wildgoose
//Date:   15 Dec 2018
//==========================================

namespace RandomUserLib.Models
{
    public class PersonaLocation
    {
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public PersonaCoordinates coordinates { get; set; }
        public PersonaTimeZone timezone { get; set; }
    }
}