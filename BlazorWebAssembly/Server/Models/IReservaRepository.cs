using BlazorWebAssembly.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Server.Models
{
    public interface IReservaRepository
    {
        Task<IEnumerable<Reserva>> Search(string Num_reserva);
        Task<IEnumerable<Reserva>> GetReservas();
        Task<Reserva> GetReserva(string Num_reserva);
        Task<Reserva> UpdateReserva(Reserva reserva);
    }
}
