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
                var zonesInt = new List<int>();
                foreach (string z in form.ToDictionary(x => x.Key, x => x.Value).Values.ToArray())
                {
                    zonesInt.Add(Convert.ToInt32(z));
                }
                var tss = TSSEstimator.FromHeartRate(zonesInt, HeartRateLogger.Instance.HeartRates);
                return Ok((new { tss }));
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
