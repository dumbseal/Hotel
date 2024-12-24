using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Log
    {
        public int LogId { get; set; }
        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; } = null!;
    }
}
