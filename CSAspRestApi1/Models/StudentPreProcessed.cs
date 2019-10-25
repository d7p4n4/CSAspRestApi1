using GuidLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSAspRestApi1.Models
{
    [GUID("6b2417ff-7b37-473a-88d6-f13ce284d087")]
    public class StudentPreProcessed : Object

    {
        public Int32 id { get; set; }
        public String GUID { get; set; }
        public Int32 age { get; set; }
        public String name { get; set; }
        public String address { get; set; }

        public StudentPreProcessed()
        {
            GUID = "6b2417ff-7b37-473a-88d6-f13ce284d087";
        }
    }
}