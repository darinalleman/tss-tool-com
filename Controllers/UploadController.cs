using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dynastream.Fit;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class UploadController : Controller
    {
        [HttpPost("UploadFiles")]
        public async Task<IActionResult> Index(IList<IFormFile> files)
        {
            long size = files[0].Length;

            // full path to file in temp location
            var filePath = "Uploads/" + files[0].FileName;

            string DecodeResult = "";
            if (files[0].Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await files[0].CopyToAsync(stream);
                    DecodeResult = "File" + stream.Name + " is "+ new Decode().CheckIntegrity(stream);
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { size, filePath, DecodeResult});
        }
    }
}
