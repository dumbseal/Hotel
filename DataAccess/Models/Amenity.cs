using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Amenity
    {
        public Amenity()
        {
            Hotels = new HashSet<Hotel>();
        }

        public int AmenityId { get; set; }
        public string AmenityName { get; set; } = null!;

        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
