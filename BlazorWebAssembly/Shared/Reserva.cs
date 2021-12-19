using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Shared
{
    public class Reserva
    {
        [Key]
        public string Num_reserva { get; set; }
    }
}
