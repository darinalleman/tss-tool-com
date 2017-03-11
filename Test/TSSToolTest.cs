using System.Linq;
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
        }

    }
}