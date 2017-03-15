using System;
using Xunit;
using Models;
using System.IO;
using System.Collections.Generic;

namespace Test
{
    public class TSSEstimatorTest
    {
        public TSSEstimatorTest()
        {
            Environment.SetEnvironmentVariable("TestMode", "true");
        }
        
        [Fact]
        public void TestTSSEstimator()
        {
            IList<int> Zones = new List<int>(new int[]{162,176,188,200,215});

            IList<int> HeartRates = new List<int>(new int[]{100,100,100,100,100});
            Assert.Equal((20.0/3600)*5, TSSEstimator.FromHeartRate(Zones,HeartRates), 4);

            HeartRates = new List<int>(new int[]{214,214,214,214,214});
            Assert.Equal((140.0/3600)*5, TSSEstimator.FromHeartRate(Zones,HeartRates), 4);
        }

    }
}