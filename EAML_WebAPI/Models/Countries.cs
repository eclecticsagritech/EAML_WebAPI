using System;
using System.Collections.Generic;

namespace EAML_WebAPI.Models
{
    public partial class Countries
    {
        public Countries()
        {
            States = new HashSet<States>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<States> States { get; set; }
    }
}
