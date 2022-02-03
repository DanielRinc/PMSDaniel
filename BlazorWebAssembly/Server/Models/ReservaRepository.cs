using BlazorWebAssembly.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Server.Models
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly AppDbContext appDbContext;

        public ReservaRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        
        public async Task<Reserva> GetReserva(string Num_reserva)
        {
            return await appDbContext.Reservas
                .FirstOrDefaultAsync(e => e.Num_reserva == Num_reserva);
        }

        public async Task<IEnumerable<Reserva>> GetReservas()
        {
            return await appDbContext.Reservas.ToListAsync();//devuelve todos los datos no solo el Numero_reserva
            //futuro: alterar para que al introducir api/reservas solo muestre Numero_Reserva
        }

        public async Task<IEnumerable<Reserva>> Search(string Num_reserva)
        {
            IQueryable<Reserva> query = appDbContext.Reservas;

            if (!string.IsNullOrEmpty(Num_reserva))
            {
                query = query.Where(e => e.Num_reserva.Contains(Num_reserva));
            }

            return await query.ToListAsync();
        }

        public async Task<Reserva> UpdateReserva(Reserva reserva)
        {
            var result = await appDbContext.Reservas
                .FirstOrDefaultAsync(e => e.Num_reserva == reserva.Num_reserva);

            if (result != null)
            {
                result.Num_reserva = reserva.Num_reserva;

                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
