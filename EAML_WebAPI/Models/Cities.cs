using System;
using System.Collections.Generic;

namespace EAML_WebAPI.Models
{
    public partial class Cities
    {
        public int CityId { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }

        public virtual States State { get; set; }
    }
}
