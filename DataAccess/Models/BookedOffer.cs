using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class BookedOffer
    {
        public int BookedOfferId { get; set; }
        public int? BookingId { get; set; }
        public int? OfferId { get; set; }

        public virtual Booking? Booking { get; set; }
        public virtual SpecialOffer? Offer { get; set; }
    }
}
