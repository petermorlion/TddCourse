using System;

namespace RedStar.TddCourse.DateTimes
{
    public class DateTimeRange
    {
        public DateTimeRange(DateTime begin, DateTime end)
        {
            Begin = begin;
            End = end;
        }

        public DateTime Begin { get; set; }
        public DateTime End { get; set; }

        public bool Overlaps(DateTimeRange other)
        {
            return other.End >= Begin && other.Begin <= End;
        }
    }
}