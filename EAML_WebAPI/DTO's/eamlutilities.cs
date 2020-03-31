using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace EAML_WebAPI.DTO_s
{
    public class eamlutilities
    {
        public string _sendSMS(string endpoint, string _farmernumber, string otp)
        {
            var client = new RestClient(endpoint);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n     \"to\" : \"254727916336\",\r\n     \"message\" : \"This is your one time password for registering to the EAML platform\",\r\n     \"from\" : \"ECLECTICS\",\r\n      \"transactionID\": \"@#$%@$%@%@%@@002\"\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
        
    }
    public class AppSettings
    {
        public string reusablekey { get; set; }
        public string smsEndpoint { get; set; }
    }
}
