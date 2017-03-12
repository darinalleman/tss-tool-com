using Xunit;
using System.IO;
using WebApplication.Controllers;
using Microsoft.AspNetCore.Http;  
using System.Collections.Generic;
using Moq;
using System;



namespace Test
{
    public class UploadControllerTest
    {
        public UploadControllerTest()
        {
            Environment.SetEnvironmentVariable("TestMode", "True");
        }
        [Fact]
        public async void TestFileInput()
        {
            UploadController controller = new UploadController();

            List<IFormFile> Files = new List<IFormFile>();
            Mock<IFormFile> FileMock = new Mock<IFormFile>();
            Stream FitFile = new FileStream("../../../Assets/TestFile2-MTB.fit",FileMode.Open);

            FileMock.Setup(m => m.OpenReadStream()).Returns(FitFile);
            FileMock.Setup(m => m.FileName).Returns("TestFile2-MTB.fit");
            FileMock.Setup(m => m.Length).Returns(1);
            Files.Add(FileMock.Object);
            Assert.IsType<Microsoft.AspNetCore.Mvc.OkObjectResult>(await controller.Index(Files));
        }


    }
}