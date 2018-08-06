using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prana.Tools;

namespace Prana.Tools.Tests
{
    [TestFixture]
    public class RandomTests
    {
        [Test]
        public void Latitude()
        {
            var random = new Tools.Random();
            var result = random.NextLatitude();

            Console.WriteLine($"Latitude {result}");
            

            // TODO: Add your test code here
            Assert.GreaterOrEqual(result, -90);
            Assert.LessOrEqual(result, 90);
        }

        [Test]
        public void Longitude()
        {
            var random = new Tools.Random();
            var result = random.NextLongitude();

            // TODO: Add your test code here
            Assert.GreaterOrEqual(result, -180);
            Assert.LessOrEqual(result, 180);
        }
    }
}
