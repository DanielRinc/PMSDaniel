using BlazorWebAssembly.Server.Models;
using BlazorWebAssembly.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        private readonly IReservaRepository reservaRepository;

        public ReservasController(IReservaRepository reservaRepository)
        {
            this.reservaRepository = reservaRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetReservas()
        {
            return Ok(await reservaRepository.GetReservas());
        }
        
        [HttpGet("{Num_reserva}")]
        public async Task<ActionResult<Reserva>> GetReserva(string Num_reserva)
        {
            var result= await reservaRepository.GetReserva(Num_reserva);

            return result;
        }
    }
}
