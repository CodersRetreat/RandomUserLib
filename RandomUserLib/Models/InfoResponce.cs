using System;
using System.Collections.Generic;

//==========================================
//Title:  Random User Generator
//Author: Robert Wildgoose
//Date:   15 Dec 2018
//==========================================

namespace RandomUserLib.Models
{
    public class InfoResponce
    {
        public string seed { get; set; }
        public List<Persona> results { get; set; }
        public int page { get; set; }
        public string version { get; set; }
    }
}
