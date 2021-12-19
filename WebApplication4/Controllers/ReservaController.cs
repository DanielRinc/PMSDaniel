using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Contexts;
using WebApplication4.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly AppDbContext context;

        public ReservaController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: api/<ReservaController>
        [HttpGet]
        public IEnumerable<reserva> Get()
        {
            return context.reserva.ToList();
        }

        // GET api/<ReservaController>/5
        [HttpGet("{id}")]
        public reserva Get(string id)
        {
            var Reserva = context.reserva.FirstOrDefault(p => p.num_reserva == id);
            return Reserva;
        }

        // POST api/<ReservaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReservaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReservaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
