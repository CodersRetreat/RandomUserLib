using System;

//==========================================
//Title:  Random User Generator
//Author: Robert Wildgoose
//Date:   15 Dec 2018
//==========================================

namespace RandomUserLib.Models
{
    public class Persona
    {
        public string gender { get; set; }
        public PersonaName name { get; set; }
        public PersonaLocation location { get; set; }
        public string email { get; set; }
        public PersonaLogin login { get; set; }
        public PersonaDateItem dob { get; set; }
        public PersonaDateItem registered { get; set; }
        public string phone { get; set; }
        public string cell { get; set; }
        public PersonaID id { get; set; }
        public PersonaImageSet picture { get; set; }
        public string nat { get; set; }
    }
}