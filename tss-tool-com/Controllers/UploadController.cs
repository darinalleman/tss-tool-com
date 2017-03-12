using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dynastream.Fit;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Models;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class UploadController : Controller
    {
        [HttpPost("UploadFiles")]
        public async Task<IActionResult> Index(IList<IFormFile> files)
        {
            IFormFile file = files.First();
            if (file == null) return null;
            long size = file.Length;
            // full path to file in temp location
            var FilePath = "../../../Uploads/" + file.FileName;

            Boolean DecodeResult;
            String result = "";

            if (size > 0)
            {
                using (var stream = new FileStream(FilePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                DecodeResult = TSSTool.GetInstance().DecodeFile(new FileStream(FilePath, FileMode.Open));
                result = "Success?= " + DecodeResult;
            }

            return Ok(new { size, FilePath, result });
        }
    }
}
