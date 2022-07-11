using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DevExpress.Xpo;

using VillainActivityMonitor.API.Models;
using VillainActivityMonitor.API.Models.Xpo;

namespace VillainActivityMonitor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillainController : ControllerBase
    {
        private UnitOfWork unitOfWork;

        public VillainController(UnitOfWork uow)
        {
            unitOfWork = uow;
        }

        [HttpPost]
        [Route("AddVillain")]
        public async Task AddVillain([FromBody] Villain villain)
        {

            new XpoVillain(unitOfWork)
            {
                Name = villain.Name,
                FirstName = villain.FirstName,
                LastName = villain.LastName,
                Alias = villain.Alias
            };

            try
            {
                unitOfWork.CommitChanges();

                Console.WriteLine($"{villain.Name} added to database.");
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.Source}: {e.Message}\n{e.StackTrace}");
            }
        }

        [HttpGet]
        [Route("GetVillains")]
        public async Task<ActionResult<List<Villain>>> GetVillains()
        {
            XPCollection<XpoVillain> xpoVillains = new XPCollection<XpoVillain>(unitOfWork);
            xpoVillains.Load();

            List<Villain> villains = new List<Villain>();
            foreach (var xpoVillain in xpoVillains)
            {
                villains.Add(new Villain()
                {
                    Id = xpoVillain.Oid,
                    Name = xpoVillain.Name,
                    FirstName = xpoVillain.FirstName,
                    LastName = xpoVillain.LastName,
                    Alias = xpoVillain.Alias
                });
            }

            return villains;
        }
    }
}