using System;
using System.Collections.Generic;
using FluentAssertions;
using RedStar.TddCourse.DateTimes;
using Xunit;

namespace RedStar.TddCourse.Naming.xUnit
{
    public class DateTimeRangeTests
    {
        public static IEnumerable<object[]> GetOverlappingRanges()
        {
            yield return new object[] {
                new DateTimeRange(new DateTime(2018, 1, 1), new DateTime(2018, 2, 1)),
                new DateTimeRange(new DateTime(2017, 12, 15), new DateTime(2018, 1, 15))};

            yield return new object[] {
                new DateTimeRange(new DateTime(2018, 1, 1), new DateTime(2018, 2, 1)),
                new DateTimeRange(new DateTime(2018, 1, 15), new DateTime(2018, 2, 15))};

            yield return new object[] {
                new DateTimeRange(new DateTime(2018, 1, 1), new DateTime(2018, 2, 1)),
                new DateTimeRange(new DateTime(2018, 1, 15), new DateTime(2018, 1, 16))};

            yield return new object[] {
                new DateTimeRange(new DateTime(2018, 1, 1), new DateTime(2018, 2, 1)),
                new DateTimeRange(new DateTime(2017, 12, 15), new DateTime(2018, 2, 15))};
        }

        [Theory]
        [MemberData(nameof(GetOverlappingRanges))]
        public void Overlaps_ForOverlappingRanges_ShouldReturnTrue(DateTimeRange range1, DateTimeRange range2)
        {
            range1.Overlaps(range2).Should().BeTrue();
            range2.Overlaps(range1).Should().BeTrue();
        }

        public static IEnumerable<object[]> GetNonOverlappingRanges()
        {
            yield return new object[] {
                new DateTimeRange(new DateTime(2018, 1, 1), new DateTime(2018, 2, 1)),
                new DateTimeRange(new DateTime(2017, 12, 15), new DateTime(2017, 12, 31))};

            yield return new object[] {
                new DateTimeRange(new DateTime(2018, 1, 1), new DateTime(2018, 2, 1)),
                new DateTimeRange(new DateTime(2018, 2, 15), new DateTime(2018, 2, 20))};
        }

        [Theory]
        [MemberData(nameof(GetNonOverlappingRanges))]
        public void Overlaps_ForNonOverlappingRanges_ShouldReturnTrue(DateTimeRange range1, DateTimeRange range2)
        {
            range1.Overlaps(range2).Should().BeFalse();
            range2.Overlaps(range1).Should().BeFalse();
        }
        
        [Theory]
        [MemberData(nameof(GetNonOverlappingRanges))]
        public void IntentionallyFailingTheory(DateTimeRange range1, DateTimeRange range2)
        {
            range1.Overlaps(range2).Should().BeTrue();
            range2.Overlaps(range1).Should().BeTrue();
        }
    }
}