using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApi.Data;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActorController : ControllerBase
    {
        private static readonly string[] Stars = new[]
        {
            "Brad Pitt", "Patrick Stewart", "Will Ferrel", "Mike Roberts", "Beyonce"
        };

        private readonly ILogger<ActorController> _logger;

        public ActorController(ILogger<ActorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Actor>> Get()
        {
            using (var ctx = new StarsContext())
            {
              return await ctx.Actor.ToListAsync();
            }
        }
    }
}
