using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using HangFireCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HangFireExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangFireController : ControllerBase
    {
        public IDemoJob _job;
        public HangFireController(IDemoJob job)
        {
            _job = job;
        }
       [HttpGet]
        public IActionResult Job()
        {
            RecurringJob.AddOrUpdate("demoJob", () => this._job.RunDemoTask(), Cron.Minutely);
            return Ok("Criado");
        }
    }
}