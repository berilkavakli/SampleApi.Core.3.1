using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using SampleAPI.Core._3._1.Models;
using SampleAPI.Core._3._1.Validators;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleAPI.Core._3._1.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody]Product model)
        {
            // Save method is not implemented. 
            // Because our target is to focus on validation.
            // Save(model);

            return Ok();
        }

       
    }
}
