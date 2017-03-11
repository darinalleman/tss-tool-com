using System;
using Xunit;
using Models;
using System.IO;

namespace Test
{
    public class TSSToolTest
    {
        [Fact]
        public void TestInit()
        {
           Assert.NotNull(TSSTool.GetInstance());
        }

        [Fact]
        public void TestDecodeWithFile()
        {
           TSSTool tool = TSSTool.GetInstance();
           FileStream FitFile = new FileStream("../../../Assets/TestFile-KG.fit", FileMode.Open);
           Assert.True(tool.DecodeFile(FitFile));
           FitFile.Dispose();
        }

        [Fact]
        public void TestDecodeWithFileSavesHeartRate()
        {
            TSSTool tool = TSSTool.GetInstance();
            FileStream FitFile = new FileStream("../../../Assets/TestFile-KG.fit", FileMode.Open);
            Assert.True(tool.DecodeFile(FitFile));
            Assert.NotEmpty(HeartRateLogger.Instance.HeartRates);
            FitFile.Dispose();
        }

        [Fact]
        public void TestDecodeWithFileSavesElapsedTime()
        {
            Console.WriteLine("Testing Elapsed time...");
            TSSTool tool = TSSTool.GetInstance();
            FileStream FitFile = new FileStream("../../../Assets/TestFile-KG.fit", FileMode.Open);
            Assert.True(tool.DecodeFile(FitFile));
            Assert.InRange<int>(ElapsedTimeLogger.Instance.ElapsedTime, 1,int.MaxValue);
            FitFile.Dispose();
        }

    }
}