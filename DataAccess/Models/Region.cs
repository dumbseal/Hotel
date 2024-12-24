using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Region
    {
        public Region()
        {
            Cities = new HashSet<City>();
        }

        public int RegionId { get; set; }
        public string RegionName { get; set; } = null!;

        public virtual ICollection<City> Cities { get; set; }
    }
}
