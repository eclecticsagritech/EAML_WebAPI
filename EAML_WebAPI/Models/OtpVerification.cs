using System;
using System.Collections.Generic;

namespace EAML_WebAPI.Models
{
    public partial class OtpVerification
    {
        public long Idx { get; set; }
        public int Otp { get; set; }
        public string Phonenumber { get; set; }
        public bool Confirmed { get; set; }
        public string Token { get; set; }
        public bool Resend { get; set; }
        public DateTime Expiry { get; set; }
        public string Deviceid { get; set; }
        public DateTime DateIssued { get; set; }
        public DateTime DateConfirmed { get; set; }
    }
}
