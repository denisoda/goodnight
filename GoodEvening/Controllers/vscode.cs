using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GoodEvening.Controllers
{
    [Route("api/[controller]")]
    public class VscodeController : Controller
    {
        [HttpGet("[action]")]
        public string Result()
        {
            return "z";
        }
    }
}