using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using area;


namespace AreaTests
{
    public class AreaTest
    {
        [Test]
        public void Circle1Test()
        {
            Assert.AreEqual(Area.CircleArea(1), Math.PI);
        }

        [Test]
        public void Circle2Test()
        {
            Assert.AreEqual(Area.CircleArea(2), Math.PI * 4);
        }

        [Test]
        public void CircleArgumentTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Area.CircleArea(0));
        }

        [Test]
        public void TriangleArgument1Test()
        {
            Assert.Throws<ArgumentException>(() => Area.TriangleArea(1, 2));
        }

        [Test]
        public void TriangleArgument2Test()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Area.TriangleArea(1, 2, -7));
        }

        [Test]
        public void NotTriangle1Test()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Area.TriangleArea(3, 2, 6));

        }

        [Test]
        public void NotTriangle2Test()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Area.IsRectangular(3, 3, 7));

        }

        [Test]
        public void TriangleArea1Test()
        {
            Assert.AreEqual(Area.TriangleArea(3, 4, 5), 6.0d);

        }

        public void TriangleArea2Test()
        {
            Assert.AreEqual(Area.TriangleArea(3, 6, 5) - 7.483315d < 0.000001, true);
        }

        [Test]
        public void IsRectangular1Test()
        {
            Assert.AreEqual(Area.IsRectangular(3, 4, 5), true);
        }

        [Test]
        public void IsRectangular2Test()
        {
            Assert.AreEqual(Area.IsRectangular(4, 4, 5), false);
        }
    }
}
