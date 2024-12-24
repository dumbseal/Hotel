using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class City
    {
        public City()
        {
            Hotels = new HashSet<Hotel>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; } = null!;
        public int? RegionId { get; set; }

        public virtual Region? Region { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
