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
    public class WritePowerController : Controller
    {
        [HttpPost, Route("api/WritePower")]
        public async Task<IActionResult> WritePower()
        {
            try{
                var form = await Request.ReadFormAsync();
                var formArray = form.ToDictionary(x => x.Key, x => x.Value).Values.ToArray();
                var tss = formArray[0];
                var ftp = formArray[1];
                var EncodeResult = TSSTool.GetInstance().EncodeFile(Convert.ToInt32(tss),Convert.ToInt32(ftp));
                
                return Ok((new { tss, ftp, EncodeResult }));
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
