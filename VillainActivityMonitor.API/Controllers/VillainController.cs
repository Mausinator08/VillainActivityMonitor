using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using VillainActivityMonitor.API.Models;

namespace VillainActivityMonitor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillainController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Villain>>> GetVillains()
        {
            return new List<Villain>
            {
                new Villain
                {
                    Name = "Estella von Hellman",
                    FirstName = "Estella",
                    LastName = "Hellman",
                    Alias = "Cruella de Vil"
                }
            };
        }
    }
}