using System;
using System.Collections.Generic;

namespace EAML_WebAPI.Models
{
    public partial class FarmerRegDetails
    {
        public long Idx { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string AdminBoundaryOne { get; set; }
        public string AdminBoundaryTwo { get; set; }
        public string AdminBoundaryThree { get; set; }
        public string NearestSchool { get; set; }
        public string IdNumber { get; set; }
        public string FarmerId { get; set; }
        public string DeviceId { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string County { get; set; }
        public string SubCounty { get; set; }
        public string Location { get; set; }
        public string Emailaddress { get; set; }
    }
}
