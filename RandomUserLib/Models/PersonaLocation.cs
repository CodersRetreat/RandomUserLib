using System;
namespace RandomUserLib.Models
{
    public class PersonaLocation
    {
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int postcode { get; set; }
        public PersonaCoordinates coordinates { get; set; }
        public PersonaTimeZone timezone { get; set; }
    }
}