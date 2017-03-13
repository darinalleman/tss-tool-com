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
    public class UploadController : Controller
    {
        [HttpPost, Route("api/Upload")]
        public async Task<IActionResult> Upload()
        {
            try{
                var form = await Request.ReadFormAsync();
                var file = form.Files.First();
                if (file == null) return null;
                long size = file.Length;
                var FilePath = "";
                
                //In test mode gotta access it based on the /bin/debug/ run location..
                if (Convert.ToBoolean(Environment.GetEnvironmentVariable("TestMode")))
                {
                    FilePath= "../../../Uploads/" + file.FileName;
                }
                else{
                    FilePath = "Uploads/" + file.FileName;
                }
            

                Boolean DecodeResult;
                Boolean result = false;

                if (size > 0)
                {
                    using (var stream = new FileStream(FilePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    DecodeResult = TSSTool.GetInstance().DecodeFile(new FileStream(FilePath, FileMode.Open));
                    result = DecodeResult;
                }

                return Ok(new { size, FilePath, result });
            }
            catch (Exception ex) {
                var originalMessage = ex.Message;

                while (ex.InnerException != null)
                    ex = ex.InnerException;
                    return BadRequest($"{originalMessage} | {ex.Message}");
            }
        }
    }
}
