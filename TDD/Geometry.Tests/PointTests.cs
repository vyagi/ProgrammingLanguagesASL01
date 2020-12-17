using System;
using Xunit;

namespace Geometry.Tests
{
    public class PointTests
    {
        [Fact]
        public void Can_create_a_point_with_two_coordinates()
        {
            var point = new Point(1,2);
        }

        [Fact]
        public void Can_create_a_point_with_two_double_coordinates()
        {
            var point = new Point(1.5, 2.6);
        }
    }
}
