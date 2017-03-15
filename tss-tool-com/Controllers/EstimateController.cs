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
    public class EstimateController : Controller
    {
        [HttpPost, Route("api/Estimate")]
        public async Task<IActionResult> Estimate()
        {
            try{
                var form = await Request.ReadFormAsync();
                Console.WriteLine("In the estimates controller, recieved objects #:" + form.Count);
                var file = form.Count;
                int tss = 0;
                return Ok(new {tss});//size, FilePath, result });
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
