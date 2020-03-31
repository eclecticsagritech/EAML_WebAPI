using System;
using System.Collections.Generic;

namespace EAML_WebAPI.Models
{
    public partial class States
    {
        public States()
        {
            Cities = new HashSet<Cities>();
        }

        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string StateName { get; set; }

        public virtual Countries Country { get; set; }
        public virtual ICollection<Cities> Cities { get; set; }
    }
}
