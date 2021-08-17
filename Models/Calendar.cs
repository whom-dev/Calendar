using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public class Calendar
    {
        public int CalendarID { get; set; }

        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string ThemeColor { get; set; }
        public bool IsFullDay { get; set; }
    }
}
