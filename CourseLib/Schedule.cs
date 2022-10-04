using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLib
{
    public class Schedule
    {
        public DateTime startTime;
        public DateTime endTime;
        public List<DayOfWeek> daysOfWeek = new List<DayOfWeek>();
    }
}
