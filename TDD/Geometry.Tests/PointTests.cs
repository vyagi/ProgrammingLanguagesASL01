using System;
using FluentAssertions;
using Xunit;

namespace Geometry.Tests
{
    public class PointTests
    {
        [Fact]
        public void Can_create_a_point_with_two_coordinates()
        {
            var point = new Point(1,2);

            point.X.Should().Be(1);
            point.Y.Should().Be(2);
        }

        [Fact]
        public void Can_create_a_point_with_two_double_coordinates()
        {
            var point = new Point(1.5, 2.6);

            point.X.Should().Be(1.5);
            point.Y.Should().Be(2.6);
        }

        [Fact]
        public void Can_create_a_point_with_no_parameters_and_it_will_be_1_1()
        {
            var point = new Point();

            point.X.Should().Be(1);
            point.Y.Should().Be(1);
        }

        [Fact]
        public void Distance_returns_proper_value()
        {
            var point = new Point(3,4);

            var distance = point.Distance();

            distance.Should().Be(5);
        }

        [Fact]
        public void Distance_from_another_point_returns_proper_value()
        {
            var point = new Point(2,-5);
            var anotherPoint = new Point(5,-1);

            var distance = point.Distance(anotherPoint);

            distance.Should().Be(5);
        }
    }
}
