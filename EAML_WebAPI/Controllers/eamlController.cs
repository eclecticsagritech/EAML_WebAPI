using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAML_WebAPI.DTO_s;
using EAML_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using OtpNet;

namespace EAML_WebAPI.Controllers
{
    [Route("_api/[controller]")]
    [ApiController]
    public class eamlController : ControllerBase
    {
        private string _reusablekey;
        private string _smsEndpoint;

        public eamlController(IOptions<AppSettings> settings)
        {
            _reusablekey = settings.Value.reusablekey;
            _smsEndpoint = settings.Value.smsEndpoint;

        }
        [HttpGet("sendotp")]
        public string sendOTP(string _phonenumber)
        {
            var totp = new Totp(Encoding.ASCII.GetBytes(_reusablekey), step: 300, totpSize: 4);
            var totpCode = totp.ComputeTotp(DateTime.UtcNow);
            return totpCode;
        }
        [HttpPost("farmerregistration")]
        public bool farmer_registration([FromBody]FarmerRegDetails _regDetails)
        {
            bool _saved = false;
            return _saved;
        }

    }
}
