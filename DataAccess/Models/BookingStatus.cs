using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class BookingStatus
    {
        public BookingStatus()
        {
            BookingStatusHistories = new HashSet<BookingStatusHistory>();
        }

        public int BookingStatusId { get; set; }
        public string StatusName { get; set; } = null!;

        public virtual ICollection<BookingStatusHistory> BookingStatusHistories { get; set; }
    }
}
