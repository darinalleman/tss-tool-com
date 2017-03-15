using System;
using Xunit;
using Models;
using System.IO;

namespace Test
{
    public class TSSToolTest
    {
        public TSSToolTest()
        {
            Environment.SetEnvironmentVariable("TestMode", "true");
        }
        
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
            TSSTool tool = TSSTool.GetInstance();
            FileStream FitFile = new FileStream("../../../Assets/TestFile-KG.fit", FileMode.Open);
            Assert.True(tool.DecodeFile(FitFile));
            Assert.InRange<int>(ElapsedTimeLogger.Instance.ElapsedTime, 1,int.MaxValue);
            FitFile.Dispose();
        }

        
        [Fact]
        public void TestEncode()
        {
            TSSTool tool = TSSTool.GetInstance();
            FileStream FitFile = new FileStream("../../../Assets/TestFile2-MTB.fit", FileMode.Open);
            FileStream EditedFitFile = new FileStream("../../../Uploads/TestFile-KG-edit.fit", FileMode.Create);
            Assert.True(tool.EncodeFile(EditedFitFile, FitFile));
            FitFile.Dispose();
            EditedFitFile.Dispose();
        }


    }
}